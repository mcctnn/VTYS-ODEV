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
    public partial class AdminPanel : Form
    {
        
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void dmrbas_Click(object sender, EventArgs e)
        {
            Demirbaslar demirbaslar = new Demirbaslar();
            demirbaslar.Show();
            this.Hide();
        }

        private void clsnlar_Click(object sender, EventArgs e)
        {
            Calisanlar calisanlar = new Calisanlar();
            calisanlar.Show();
            this.Hide();
        }

        private void deps_Click(object sender, EventArgs e)
        {
            Departmanlar departmanlar = new Departmanlar();
            departmanlar.Show();
            this.Hide();
        }

        private void slndmr_Click(object sender, EventArgs e)
        {
            SilinenDemirbaslar silinenDemirbaslar=new SilinenDemirbaslar();
            silinenDemirbaslar.Show();
            this.Hide();
        }

        private void slnclsn_Click(object sender, EventArgs e)
        {
            SilinenCalisanlar silinenCalisanlar=new SilinenCalisanlar();
            silinenCalisanlar.Show();
            this.Hide();
        }

        private void cksyap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cktal_Click(object sender, EventArgs e)
        {
            ExcelCalisan excelCalisan = new ExcelCalisan();
            excelCalisan.Show();
            this.Hide();
            //ExcelDepartman excelDepartman= new ExcelDepartman();
            //excelDepartman.Show();
            //this.Hide();
        }

        private void ydkle_Click(object sender, EventArgs e)
        {
            Yedekleme   yedeklem=new Yedekleme();
            yedeklem.Show();
            this.Hide();
        }

        private void klnEkle_Click(object sender, EventArgs e)
        {
            KullanıcıEkle kullanıcıEkle=new KullanıcıEkle();
            kullanıcıEkle.Show();
            this.Hide();
        }
    }
}
