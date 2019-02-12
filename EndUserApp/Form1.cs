using FakeDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndUserApp
{
    public partial class Form1 : Form
    {
        DataAccess data = new DataAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //N - tier uygulama, bir den fazla katmanli uygulama.
            //textbox degerini al (sira no)
            //data accesse git
            //sorgula
            //sonucu 
            //ekrana yazdir.

            //Separation of Concern (Gerekliligin Ayrimi)
            //Front end, backend e karismasin.
            //backend frontende karismasin.

            int girilen = int.Parse(textBox1.Text);
        
            var ogr = data.Sorgula(girilen);
            if (ogr != null)
            {
                lblSira.Text = ogr.Sira.ToString();
                lblAd.Text = ogr.OgrenciAdi;
                lblSoyad.Text = ogr.OgrenciSoyadi;
            }
            else
                MessageBox.Show("Boyle bir id yok!");
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Modeli (Ogrenci) doldurup,
            //DataAccessin Add metoduna arguman olarak gondermeniz
            //gerek.

            Ogrenci ogr = new Ogrenci();
            ogr.Sira = int.Parse(txtSira.Text);
            ogr.OgrenciAdi = txtAd.Text;
            ogr.OgrenciSoyadi = txtSoyad.Text;
           
            int sonuc = data.Add(ogr);
            if (sonuc != -1)
                MessageBox.Show("Eklendi!");
            else
                MessageBox.Show("Eklenemedi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1=Adi=Soyadi
            listBox1.Items.Clear();
                    
            foreach (var item in data.SelectAll())
            {
                //listBox1.Items.Add(item.Sira + "=" + item.OgrenciAdi + "=" + item.OgrenciSoyadi);
                listBox1.Items.Add(item);
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = (Ogrenci)listBox1.SelectedItem; //unboxing
            //Nesne kontrollere binding oluyor.
            lblSira.Text = ogr.Sira.ToString();
            lblAd.Text = ogr.OgrenciAdi;
            lblSoyad.Text = ogr.OgrenciSoyadi;
        }
    }
}
