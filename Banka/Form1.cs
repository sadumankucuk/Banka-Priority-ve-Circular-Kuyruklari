using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TurgutluBankasi tb = new TurgutluBankasi();
        private void BtnMusteri_Click(object sender, EventArgs e)
        {

            if (txtCircular.Text =="")
            {
                txtCircular.Text = tb.c.Listele();
            }
            else
                MessageBox.Show("Müşteriler eklendi");
            
        }

        private void btnOrtSureCircular_Click(object sender, EventArgs e)
        {
            txtOrtSureCircular.Text = tb.c.OrtamalaITS().ToString();
        }

        private void btnMusteri2_Click(object sender, EventArgs e)
        {
            tb.p.toplamSure = 0;
            if (txtOrtPriority1.Text =="")
            {
                txtPriority1.Text = tb.p.Listele();
            }
            else
                MessageBox.Show("Müşteriler eklendi");

        }

        private void btnOrtPriority1_Click(object sender, EventArgs e)
        {
            tb.p.toplamSure = 0;
            for (int i = 0; i < 20; i++)
            {
                tb.p.toplamSure += ((Musteri)tb.p.Queue[i]).IslemSuresi;
            }
            txtOrtPriority1.Text = (tb.p.toplamSure / 20).ToString();
        }

        private void btnMusteri3_Click(object sender, EventArgs e)
        {
            tb.p2.toplamSure = 0;
            if (txtOrtPriority2.Text =="")
            {
                txtPriority2.Text = tb.p2.Listele();
            }
            else
                MessageBox.Show("Müşteriler eklendi");
        }

        private void btnOrtPriority_Click(object sender, EventArgs e)
        {
            tb.p.toplamSure = 0;
            for (int i = 0; i < 20; i++)
            {
                tb.p.toplamSure += ((Musteri)tb.p.Queue[i]).IslemSuresi;
            }
             

            txtOrtPriority2.Text= (tb.p.toplamSure / 20).ToString();
        }

        private void btnKisalan1_Click(object sender, EventArgs e)
        {
            if (txtKisalan1.Text =="")
            {
                txtKisalan1.Text += tb.KisalanSüreleriBul1();
            }
            else
                MessageBox.Show("Kısalan süreler bulundu");
        }

        private void btnKisalan2_Click(object sender, EventArgs e)
        {
            if (txtKisalan2.Text =="")
            {
                txtKisalan2.Text += tb.KisalanSüreleriBul2();
            }
            else
                MessageBox.Show("Kısalan süreler bulundu");
        }
    }
}
