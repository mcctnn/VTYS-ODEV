using System;
using Excel=Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using Z.Dapper.Plus;
using DataTable = Microsoft.Office.Interop.Excel.DataTable;

namespace DemirbasTakip
{
    public partial class ExcelDepartman : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-202LLLL;initial catalog=demirbas_takip;integrated security=true");
        DataTableCollection tableCollection;
        public ExcelDepartman()
        {
            InitializeComponent();
        }

        private void aktar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel=new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object missing=Type.Missing;
            Workbook workbook = excel.Workbooks.Add(missing);
            Worksheet sheet = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int i = 0;i < dataGridView1.Columns.Count;i++)
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

        private void ExcelDepartman_Load(object sender, EventArgs e)
        {

        }

        private void Geri_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open=new OpenFileDialog()
            {
                Filter="Excel |*.xlsx|Excel Workbook |*.xls"
            })
            {
                if (open.ShowDialog()==DialogResult.OK)
                {
                    textBox1.Text = open.FileName;
                    using (var stream=File.Open(open.FileName,FileMode.Open,FileAccess.Read))
                    {
                        using (IExcelDataReader reader=ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection=result.Tables;
                            comboBox1.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                //comboBox1.Items.Add(table.tableName);
                            }
                        }
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
