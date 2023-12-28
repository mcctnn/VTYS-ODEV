using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemirbasTakip
{
    public partial class Departmanlar : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-202LLLL;initial catalog=demirbas_takip;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter;
        public void Listele()
        {
            adapter = new SqlDataAdapter("select * from Departmanlar", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


        }
        public Departmanlar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (textBox1.Text is null)
                {
                    MessageBox.Show("Departman kodu boş bırakılamaz!!");
                }
                else
                {
                    cmd = new SqlCommand("insert into Departmanlar(DepartmanKod,DepartmanAd,TelefonNumara,Adres) values(@DepartmanKodu,@DepartmanAdı,@TelefonNumarası,@Adres)", con);
                    cmd.Parameters.AddWithValue("@DepartmanKodu", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@DepartmanAdı", textBox2.Text);
                    cmd.Parameters.AddWithValue("@TelefonNumarası", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Adres", textBox4.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kayıt tamam!!");
                    Listele();
                }
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Hatalı işlem yaptınız!!");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update  Departmanlar set DepartmanAd=@DepartmanAdı,TelefonNumara=@TelefonNumarası,Adres=@Adres where DepartmanID=@ID", con);
            cmd.Parameters.AddWithValue("@ID",dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@DepartmanKodu", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@DepartmanAdı", textBox2.Text);
            cmd.Parameters.AddWithValue("@TelefonNumarası", textBox3.Text);
            cmd.Parameters.AddWithValue("@Adres", textBox4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme tamam!!");
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("delete from Departmanlar where DepartmanID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Silme tamam!!");
            Listele();
        }

        private void Departmanlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string co = ("select * from Departmanlar where DepartmanAd like '%"+textBox5.Text+"%'");
            SqlDataAdapter sda = new SqlDataAdapter(co, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            con.Close();
        }
    }
}
