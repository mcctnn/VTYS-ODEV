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
    public partial class GirisEkrani : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-202LLLL;initial catalog=demirbas_takip;integrated security=true");
        SqlCommand cmd;
        SqlDataReader dataReader;
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * from Hesaplar where PerKullanici=@KullanıcıAdı and PerSifre=@Parola ";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@kullanıcıAdı", textBox1.Text);
            cmd.Parameters.AddWithValue("@Parola", textBox2.Text);
           
            con.Open();
            dataReader = cmd.ExecuteReader();
           // cmd.ExecuteNonQuery();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girildi");
            }
            else if(textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                AdminPanel ap = new AdminPanel();
                ap.Show();
                this.Hide();
            }
            else if(dataReader.Read())
            {
                AnaSayfa ana = new AnaSayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!!!");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
