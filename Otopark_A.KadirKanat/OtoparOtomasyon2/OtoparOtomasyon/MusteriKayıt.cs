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
    public partial class MusteriKayıt : Form
    {
        //public bool ParkDurumu { get; private set; }

        public MusteriKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var durum = string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text)
                || string.IsNullOrWhiteSpace(textBox3.Text)
                || string.IsNullOrWhiteSpace(textBox4.Text)
                || string.IsNullOrWhiteSpace(textBox5.Text)
                || string.IsNullOrWhiteSpace(textBox6.Text)
                || comboBox1.SelectedIndex == -1;
            if (durum)
            {
                MessageBox.Show("Tüm Alanları Doldurun !");
            }
            else
            {
                if (textBox1.Text.Length < 11)
                {
                    MessageBox.Show("Geçerli Bir Tc Giriniz !");
                }
                else
                {



                    Aboneler ab = new Aboneler();


                    ab.AbonelikDurumu = true;

                    ab.TC = textBox1.Text;
                    ab.Ad = textBox2.Text;
                    ab.Soyad = textBox3.Text;
                    ab.Telefon = textBox4.Text;
                    ab.Email = textBox5.Text;
                    ab.PlakaNo = textBox6.Text;
                    ab.AracTipiID = comboBox1.SelectedIndex + 1;


                    AboneİslemHelper.AboneKayıt(ab);
                    dataGridView1.DataSource = AboneİslemHelper.AboneleriGetir();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aboneID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string tc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string ad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string soyad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string tel = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string email = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string plaka = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            int aractipID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);
            bool AbonelikDurumu = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[8].Value);

            MusteriGuncelle mg =new MusteriGuncelle(aboneID,tc, ad, soyad, tel, email,plaka,aractipID,AbonelikDurumu);
            mg.Show();
            dataGridView1.DataSource = AboneİslemHelper.AboneleriGetir();
        }

        private void MusteriKayıt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AboneİslemHelper.AboneleriGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AboneİslemHelper.AboneleriGetir();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            int aboneID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string tc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string ad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string soyad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string tel = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string email = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string plaka = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            int aractipID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);
            bool AbonelikDurumu = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[8].Value);
            var parkdurum = BosParkHelper.ParkDurumuGetByAboneID(aboneID) ;
            if (AbonelikDurumu==false || parkdurum == true)
            {
                MessageBox.Show("Bu Araç Park Edilemez !!!");

            }
            else
            {
                Form2 frm2 = new Form2(aboneID, tc, ad, soyad, tel, email, plaka, aractipID, AbonelikDurumu,parkdurum);
                frm2.Show();
            }
            
        }

        private void SadeceRakam(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
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
