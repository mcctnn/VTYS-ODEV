using System;
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
    public partial class Calisanlar : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-202LLLL;initial catalog=demirbas_takip;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter;
        public void Listele()
        {
            adapter = new SqlDataAdapter("select * from Calisanlar", con);
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
            textBox5.Text = "";
            textBox6.Text = "";

        }
        public Calisanlar()
        {
            InitializeComponent();
        }

        private void Calisanlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                cmd = new SqlCommand("insert into Calisanlar(CalisanKod,CalisanAd,CalisanSoyad,SicilNumara,DepartmanID,Gorev,TelefonNumara,Epostaadres) values(@ÇalışanKodu,@ÇalışanAdı,@ÇalışanSoyadı,@SicilNumarası,@DepartmanID,@Görev,@TelefonNumarası,@Eposta)", con);
                cmd.Parameters.AddWithValue("ÇalışanKodu",int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@ÇalışanAdı", textBox2.Text);
                cmd.Parameters.AddWithValue("@ÇalışanSoyadı", textBox3.Text);
                cmd.Parameters.AddWithValue("@SicilNumarası", textBox4.Text);
                cmd.Parameters.AddWithValue("@Görev", textBox5.Text);
                cmd.Parameters.AddWithValue("@TelefonNumarası", textBox6.Text);
                cmd.Parameters.AddWithValue("@Eposta", textBox7.Text);
                cmd.Parameters.AddWithValue("DepartmanID",int.Parse(textBox8.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt tamam!!");
                Listele();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Hatalı işlem yaptınız!!");
            //}
        }

            private void button2_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("update Calisanlar set CalisanAd=@Adı,CalisanSoyad=@Soyadı,SicilNumara=@SicilNumarası,DepartmanID=@DepartmanID,Gorev=@Görevi,TelefonNumara=@TelefonNumarası,Epostaadres=@Eposta where CalisanID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@ÇalışanKodu",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Adı", textBox2.Text);
            cmd.Parameters.AddWithValue("@Soyadı", textBox3.Text);
            cmd.Parameters.AddWithValue("@SicilNumarası", textBox4.Text);
            cmd.Parameters.AddWithValue("@Görevi", textBox5.Text);
            cmd.Parameters.AddWithValue("@TelefonNumarası", textBox6.Text);
            cmd.Parameters.AddWithValue("@Eposta", textBox7.Text);
            cmd.Parameters.AddWithValue("DepartmanID", int.Parse(textBox8.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme tamam!!");
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Delete from Calisanlar where CalisanID=@ID  ", con);
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Silme tamam!!");
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
            string co = ("select * from Calisanlar where CalisanAd like '%" + textBox9.Text + "%'");
            SqlDataAdapter sda = new SqlDataAdapter(co, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            con.Close();
        }
    }
}
