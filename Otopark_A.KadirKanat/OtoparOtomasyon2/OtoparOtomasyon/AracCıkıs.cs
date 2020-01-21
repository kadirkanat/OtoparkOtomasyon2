using OtoparOtomasyon.Helpers;
using OtoparOtomasyon.Models;
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
    public partial class AracCıkıs : Form
    {
        int aractipi = 0;
       private double süre;
        
        ParkYeri park = new ParkYeri();
       
     
        public AracCıkıs()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(textBox1.Text);
            var abonedurum = AboneİslemHelper.AboneVarMI(id);
            if (abonedurum)
            {



                var durum = BosParkHelper.ParkDurumuGetByAboneID(id);
                if (durum)
                {
                    var abone = AboneİslemHelper.AboneGetirID(id);
                     park = BosParkHelper.ParkBilgiGetirID(id);
                    

                    textBox3.Text = park.ParkYeriID.ToString();
                    textBox5.Text = abone.PlakaNo;

                    textBox6.Text = abone.TC;
                    textBox7.Text = abone.Ad;
                    textBox8.Text = abone.Soyad;
                    label7.Text = park.TarihGiriş.ToString();
                    label8.Text = DateTime.Now.ToString();
                    var tarih = DateTime.Now - park.TarihGiriş;
                    süre = tarih.Value.TotalHours;
                    aractipi = (int)abone.AracTipiID;
                    button1.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Müşterinin Otoparkta Aracı Bulunmamaktadır !");
                }
            }
            else
            {
                MessageBox.Show("Böyle Bir Abone Yoktur !");
            }
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double ücret;
            label9.Text = süre.ToString("0.00");
            if (aractipi == 1)
            {
                ücret = süre * 15;
            }
            else if (aractipi == 2)
            {
                ücret = süre * 10;
            }
            else
            {
                ücret = süre * 5;
            }
            label10.Text = ücret.ToString("0.00");
            ParkYeri py = new ParkYeri();
            py.ParkYeriID = park.ParkYeriID;
            py.TarihGiriş = null;
            py.AboneID = 1;
            py.ParkDurumu = false;

            DialogResult result = MessageBox.Show($"Ödenecek Tutar : {ücret.ToString("0.00")} \n Devam Edilsin Mi ? ", "Ödeme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                BosParkHelper.ParkYeriUpdate(py);
                MessageBox.Show("Ödeme Gerçekleşmiştir !");
                button1.Enabled = false;
                textBox1.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
                
            }
            else
            {
                button1.Enabled = false;
            }
           


            



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AracCıkıs_Load(object sender, EventArgs e)
        {

        }
    }
}
