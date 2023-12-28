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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemirbasTakip
{
    public partial class Demirbaslar : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-202LLLL;initial catalog=demirbas_takip;integrated security=true");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public void Listele()
        {
            adapter = new SqlDataAdapter("select * from Demirbaslar", con);
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
            textBox7.Text = "";
            textBox8.Text = "";
            

        }
        public Demirbaslar()
        {
            InitializeComponent();
        }

        private void Demirbaslar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //try
            //{

            //    if (textBox1.Text is null)
            //    {
            //        MessageBox.Show("Demirbaş kodu boş bırakılamaz");
            //    }
            //    else
            //    {
                    cmd = new SqlCommand("insert into Demirbaslar (DemirbasKod,DemirbasAd,Marka,Model,AlimTarih,AlimDeger,DepartmanID,CalisanID,Durumu) values(@DemirbasKodu,@Adı,@Marka,@Model,@AlımTarihi,@AlımDeğeri,@DepartmanID,@KisiID,@Durumu)", con);
                    cmd.Parameters.AddWithValue("@DemirbasKodu", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Adı", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Marka", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Model", textBox4.Text);
                    cmd.Parameters.AddWithValue("@AlımTarihi", textBox5.Text);
                    cmd.Parameters.AddWithValue("@AlımDeğeri", float.Parse(textBox6.Text));
                    cmd.Parameters.AddWithValue("@Durumu", textBox7.Text);
                    cmd.Parameters.AddWithValue("DepartmanID", int.Parse(textBox9.Text));
                    cmd.Parameters.AddWithValue("@KisiID", int.Parse(textBox8.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kayıt tamam");
                    Listele();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    //MessageBox.Show("Hatalı işlem yaptınız!!");

            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update Demirbaslar set DemirbasAd=@Adı," +
               "Marka=@Marka," +
               "Model=@Model," +
               "AlimTarih=@AlımTarihi," +
               "AlimDeger=@AlımDeğeri," +
               "Durumu=@Durum where DemirbasID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@DemirbaşKodu",int.Parse( textBox1.Text));
            cmd.Parameters.AddWithValue("@Adı", textBox2.Text);
            cmd.Parameters.AddWithValue("@Marka", textBox3.Text);
            cmd.Parameters.AddWithValue("@Model", textBox4.Text);
            cmd.Parameters.AddWithValue("@AlımTarihi", textBox5.Text);
            cmd.Parameters.AddWithValue("@AlımDeğeri", float.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Durum", textBox7.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme tamam");
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from Demirbaslar where DemirbasID=@ID", con);
            cmd.Parameters.AddWithValue("@ID",dataGridView1.CurrentRow.Cells[0].Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Silme tamam");
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel ana = new AdminPanel();
            ana.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string co = ("select * from Demirbaslar where DemirbasAd like '%" + textBox10.Text + "%'");
            SqlDataAdapter sda = new SqlDataAdapter(co, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dataset = new DataSet();
            sda.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
