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
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Globalization;
using ExcelDataReader;
using System.IO;

namespace DemirbasTakip
{
    public partial class ExcelCalisan : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-202LLLL;initial catalog=demirbas_takip;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter;
        public void Listele()
        {
            adapter = new SqlDataAdapter("select * from Calisanlar", con);
            System.Data.DataTable dataTable = new System.Data.DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        public ExcelCalisan()
        {
            InitializeComponent();
        }

        private void ExcelCalisan_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void aktar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.Filter = " Xlsx Dosyaları |*.xlsx| Bütün Dosyalar|*.*";
            ac.ShowDialog();
            txt_excel.Text = ac.FileName.ToString();

        }


        private void geri_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }

        private void cktAl_Click(object sender, EventArgs e)
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

        private void txt_excel_TextChanged(object sender, EventArgs e)
        {
            if (txt_excel.Text.Trim().Length > 0)
            {
                System.Data.DataTable dtexcel = new System.Data.DataTable();
                string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +txt_excel.Text + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=0\"";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                System.Data.DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                DataRow schemaRow = schemaTable.Rows[0];
                string sheet = schemaRow["TABLE_NAME"].ToString();
                if (!sheet.EndsWith("_"))
                {
                    string query = "SELECT  * FROM [" + sheet + "]";
                    OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
                    dtexcel.Locale = CultureInfo.CurrentCulture;
                    daexcel.Fill(dtexcel);
                }
                conn.Close();
                dataGridView1.DataSource= dtexcel;
            }
            else
            {
                MessageBox.Show("Excel seçmediniz.");
            }
        }
    }
}
