using System;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemirbasTakip
{
    public partial class ExcelDemirbas : Form
    {
        public ExcelDemirbas()
        {
            InitializeComponent();
        }

        private void ExcelDemirbas_Load(object sender, EventArgs e)
        {

        }

        private void aktar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(missing);
            Worksheet sheet = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Range range1 = (Range)sheet.Cells[StartRow, StartCol + i];
                range1.Value2 = dataGridView1.Columns[i].HeaderText;
            }
            StartRow++;
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    Range range2 = (Range)sheet.Cells[StartRow + j, StartCol + i];
                    range2.Value2 = dataGridView1[i, j].Value == null ? "" : dataGridView1[i, j].Value;
                    range2.Select();
                }
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }
    }
}
