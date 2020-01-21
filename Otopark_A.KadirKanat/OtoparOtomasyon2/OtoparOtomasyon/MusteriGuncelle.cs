using OtoparOtomasyon.Helpers;
using OtoparOtomasyon.Models;
using OtoparOtomasyon.MyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparOtomasyon
{
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle(int musteriID ,string tc, string ad,string soyad ,string tel ,string email, string plaka , int aractıpID,bool AbonelikDurumu)
        {
            this.AbonelikDurumu = AbonelikDurumu;
            this.musteriID = musteriID;
          this.tc  = tc;
          this.ad  = ad;
          this.soyad = soyad;
          this.tel= tel;
          this.email= email;
          this.plaka= plaka;
          this.aractıpID = aractıpID;

            InitializeComponent();
        }
        string tc, ad, soyad, tel, email, plaka;
        int aractıpID, musteriID;
        bool AbonelikDurumu;

        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {
            textBox1.Text = tc;
            textBox2.Text = ad;
            textBox3.Text = soyad;
            textBox4.Text = tel;
            textBox5.Text = email;
            textBox6.Text = plaka;
            comboBox1.SelectedIndex = aractıpID - 1;
            comboBox2.SelectedIndex =  Convert.ToInt32(AbonelikDurumu);
            
 
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            var durum = string.IsNullOrEmpty(textBox1.Text) ||
                          string.IsNullOrWhiteSpace(textBox2.Text)
                          || string.IsNullOrWhiteSpace(textBox3.Text)
                          || string.IsNullOrWhiteSpace(textBox4.Text)
                          || string.IsNullOrWhiteSpace(textBox5.Text)
                          || string.IsNullOrWhiteSpace(textBox6.Text)
                           || comboBox1.SelectedIndex == -1
                            || comboBox2.SelectedIndex == -1;

            if (durum)
            {
                MessageBox.Show("Tüm Alanları Doldurun !");
            }
            else
            {
                if (textBox1.Text.Length < 11)
                {
                    MessageBox.Show("Geçerli Bir TC Giriniz !");
                }
                else
                {


                    AbonelerModel ab = new AbonelerModel();
                    ab.AbonelikDurumu = Convert.ToBoolean(comboBox2.SelectedIndex);
                    ab.AboneID = musteriID;
                    ab.TC = textBox1.Text;
                    ab.Ad = textBox2.Text;
                    ab.Soyad = textBox3.Text;
                    ab.Telefon = textBox4.Text;
                    ab.Email = textBox5.Text;
                    ab.PlakaNo = textBox6.Text;
                    ab.AracTipiID = (comboBox1.SelectedIndex + 1);

                    Aboneler k = new Aboneler();

                    k.AbonelikDurumu = ab.AbonelikDurumu;
                    k.AboneID = ab.AboneID;
                    k.TC = ab.TC;
                    k.Ad = ab.Ad;
                    k.Soyad = ab.Soyad;
                    k.Telefon = ab.Telefon;
                    k.Email = ab.Email;
                    k.PlakaNo = ab.PlakaNo;
                    k.AracTipiID = ab.AracTipiID;
                    AboneİslemHelper.MusteriAptade(k);
                    MusteriKayıt mk = new MusteriKayıt();
                    mk.Refresh();
                    Hide();
                }
            }

        }
        private void SadeceRakam(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void SadeceHarf(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}

