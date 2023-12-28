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
    public partial class KullanıcıEkle : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-202LLLL;initial catalog=demirbas_takip;integrated security=true");
        SqlCommand cmd;
        SqlDataReader dataReader;

        public KullanıcıEkle()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Hesaplar(PerKullanici,PerSifre,PerAlan) values(@KullanıcıAdı,@Parola,@Sorumluluk)", con);
            cmd.Parameters.AddWithValue("@KullanıcıAdı", textBox1.Text);
            cmd.Parameters.AddWithValue("Parola",textBox2.Text);
            cmd.Parameters.AddWithValue("Sorumluluk", textBox3.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kullanıcı Eklendi!!");
        }

        private void geri_Click(object sender, EventArgs e)
        {
            AdminPanel admin=new AdminPanel();
            admin.Show();
            this.Hide();
        }
    }
}
