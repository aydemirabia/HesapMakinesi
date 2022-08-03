using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sayi3;
            double toplam, fark, carpim, bolum, us;
            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);
            sayi3 = Convert.ToDouble(txtKarekok.Text);

            toplam = sayi1 + sayi2;
            lblToplam.Text = toplam.ToString();

            fark = sayi1 - sayi2;
            lblFark.Text = fark.ToString();

            carpim = sayi1 * sayi2;
            lblCarpim.Text = carpim.ToString();

            bolum = sayi1 / sayi2;
            lblBolum.Text = bolum.ToString();

            us = Math.Pow(sayi1, sayi2);
            lblUs.Text = us.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi, karekok;
            sayi = Convert.ToDouble(txtKarekok.Text);

            karekok = Math.Sqrt(sayi);
            lblKarekok.Text = karekok.ToString();
        }
    }
}
