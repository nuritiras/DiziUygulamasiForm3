using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziUygulamasiForm3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] isimler = new string[5]; //Global dizi
        public int[] notlar = new int[5]; //Global dizi
        public int index = 0; //Global değişken
        private void btnListe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] != null)
                {
                    lbListe.Items.Add(isimler[i] +" > "+notlar[i]);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (index < isimler.Length)
            {
                isimler[index] = txtAdSoyad.Text;
                notlar[index] = int.Parse(txtDersNotu.Text);
                // int.Parse fonksiyonu girilen değeri "int" veri türüne dönüştürür
                index++;
                txtAdSoyad.Text = "";
                txtDersNotu.Text = "";
            }
        }
    }
}
