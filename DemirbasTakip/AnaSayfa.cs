using System;
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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void dmr_Click(object sender, EventArgs e)
        {
            Demirbaslar demirbaslar = new Demirbaslar();
            demirbaslar.Show();
            this.Hide();
        }

        private void dep_Click(object sender, EventArgs e)
        {
            Departmanlar departmanlar = new Departmanlar(); 
            departmanlar.Show();
            this.Hide();
        }

        private void cks_Click(object sender, EventArgs e)
        {
            GirisEkrani giris=new GirisEkrani();
            giris.Show();
            this.Hide();
        }
    }
}
