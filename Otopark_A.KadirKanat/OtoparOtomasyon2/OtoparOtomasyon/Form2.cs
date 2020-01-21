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
    public partial class Form2 : Form
    {
        List<Button> buttons = new List<Button>();
       

        public Form2(int musteriID, string tc, string ad, string soyad, string tel, string email, string plaka, int aractıpID, bool AbonelikDurum, bool parkdurum)
        {
            this.parkdurum = parkdurum;
            this.AbonelikDurumu = AbonelikDurum;
            this.musteriID = musteriID;
            this.tc = tc;
            this.ad = ad;
            this.soyad = soyad;
            this.tel = tel;
            this.email = email;
            this.plaka = plaka;
            this.aractıpID = aractıpID;
            InitializeComponent();
        }
        string tc, ad, soyad, tel, email, plaka;
        bool parkdurum;
        int aractıpID, musteriID;
        bool AbonelikDurumu;
    

        private void btn2_Click(object sender, EventArgs e)
        {
            
            
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 2;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(2) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn2.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn2.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            
            
            
            Hide();
        }
        

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 3;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(3) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn3.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn3.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
            
            Hide();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 4;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(4) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn4.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn4.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
            
            Hide();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 5;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(5) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn5.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn5.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
           
            Hide();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 6;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(6) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn6.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn6.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
            
            Hide();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 7;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(7) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn7.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn7.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
           
            Hide();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 8;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(8) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn8.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn8.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
          
            Hide();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 9;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(9) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn9.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn9.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
           
            Hide();
        }

        private void btn10_Click(object sender, EventArgs e)
        {


            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 10;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(10) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn10.Image = (System.Drawing.Image)(Properties.Resources.dp2);
                        
                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn10.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
          
            Hide();

        }


        private void btn11_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 11;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(11) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn11.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn11.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
           
            Hide();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 12;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(12) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn12.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn12.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
           
            Hide();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 13;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(13) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn13.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn13.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
          
            Hide();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 14;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(14) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn14.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn14.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
            MessageBox.Show("Park Başarılı !!");
            Hide();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 15;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(15) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn15.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn15.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
           
            Hide();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 16;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(16) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn16.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn16.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
            
            Hide();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 17;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(17) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn17.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn17.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
            
            Hide();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 18;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(18) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn18.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn18.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
           
            Hide();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 19;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(19) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn19.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn19.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
        
            Hide();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 20;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(20) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn20.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn20.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
           
            Hide();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 21;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(21) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn21.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn20.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
            
            Hide();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 23;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(23) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn23.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn23.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
           
            Hide();

        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 22;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(22) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn22.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn22.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
            
            Hide();
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 24;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(24) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn24.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn24.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
           
            Hide();
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 25;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(25) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn25.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn25.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
            ;
            Hide();
        }

        private void ButtonKontrol(List<ParkYeri> parkyerleri)
        {
            foreach (var p in parkyerleri)
            {
                switch (p.ParkYeriID)
                {
                    case 1:
                        if (p.ParkDurumu)
                        {
                            btn1.Image = (System.Drawing.Image)(Properties.Resources.dp2);
                        }
                        else
                        {
                            btn1.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                        }
                        break;
                    case 2:
                        if (p.ParkDurumu)
                        {
                            btn2.Image = (System.Drawing.Image)(Properties.Resources.dp2);
                        }
                        else
                        {
                            btn2.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                        }
                        break;
                    case 3:
                        if (p.ParkDurumu)
                        {
                            btn3.Image = (System.Drawing.Image)(Properties.Resources.dp2);
                        }
                        else
                        {
                            btn3.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                        }
                        break;
                    case 4:
                        if (p.ParkDurumu)
                        {
                            btn4.Image = (System.Drawing.Image)(Properties.Resources.dp2);
                        }
                        else
                        {
                            btn4.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                        }
                        break;
                    case 5:
                        if (p.ParkDurumu)
                        {
                            btn5.Image = (System.Drawing.Image)(Properties.Resources.dp2);
                        }
                        else
                        {
                            btn5.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                        }
                        break;
                    case 6:
                        if (p.ParkDurumu)
                        {
                            btn6.Image = (System.Drawing.Image)(Properties.Resources.dp2);
                        }
                        else
                        {
                            btn6.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                        }
                        break;
                    case 7:
                        if (p.ParkDurumu)
                        {
                            btn7.Image = (System.Drawing.Image)(Properties.Resources.dp2);
                        }
                        else
                        {
                            btn7.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                        }
                        break;
                    case 8:
                        if (p.ParkDurumu)
                        {
                            btn8.Image = (System.Drawing.Image)(Properties.Resources.dp2);
                        }
                        else
                        {
                            btn8.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                        }
                        break;
                    case 9:
                        if (p.ParkDurumu)
                        {
                            btn9.Image = (System.Drawing.Image)(Properties.Resources.dp2);
                        }
                        else
                        {
                            btn9.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                        }
                        break;
                    case 10:
                        if (p.ParkDurumu)
                        {
                            btn10.Image = (System.Drawing.Image)(Properties.Resources.dp2);
                        }
                        else
                        {
                            btn10.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                        }
                        break;
                    case 11:
                        if (p.ParkDurumu)
                        {
                            btn11.Image = (System.Drawing.Image)(Properties.Resources.dp2);
                        }
                        else
                        {
                            btn11.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                        }
                        break;
                   

                    default:
                        break;
                }




            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            buttons.Add(btn1);
            buttons.Add(btn2);
            buttons.Add(btn3);
            buttons.Add(btn4);
            buttons.Add(btn5);
            buttons.Add(btn6);
            buttons.Add(btn7);
            buttons.Add(btn8);
            buttons.Add(btn9);
            buttons.Add(btn10);
            buttons.Add(btn11);
            buttons.Add(btn12);
            buttons.Add(btn13);
            buttons.Add(btn14);
            buttons.Add(btn15);
            buttons.Add(btn16);
            buttons.Add(btn17);
            buttons.Add(btn18);
            buttons.Add(btn19);
            buttons.Add(btn20);
            buttons.Add(btn21);
            buttons.Add(btn22);
            buttons.Add(btn23);
            buttons.Add(btn24);
            buttons.Add(btn25);
            ParkYeriYenile();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!parkdurum)
            {
                ParkYeriModel pym = new ParkYeriModel();
                ParkYeri py = new ParkYeri();
                py.AboneID = musteriID;
                pym.ParkYeriID = 1;
                pym.ParkDurumu = true;
                pym.TarihGiriş = DateTime.Now;
                pym.TarihÇıkış = null;

                py.ParkYeriID = pym.ParkYeriID;
                py.ParkDurumu = pym.ParkDurumu;
                py.TarihGiriş = pym.TarihGiriş;
                py.TarihÇıkış = pym.TarihÇıkış;
                if (BosParkHelper.Bosmu(1) == true)
                {


                    if (py.ParkDurumu == true)
                    {
                        btn1.Image = (System.Drawing.Image)(Properties.Resources.dp2);

                        BosParkHelper.ParkYeriVer(py);
                        MessageBox.Show("Park Başarılı !!");
                    }
                    else
                    {
                        btn1.Image = (System.Drawing.Image)(Properties.Resources.boşpark);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Park Yeri Şuanda Dolu !!");

                }
            }
            else
            {
                MessageBox.Show("1den Fazla Park Edemezsin !!");
            }
            
            Hide();


        }
        public void ParkYeriYenile()
        {

            List<ParkYeri> parkYerleri = BosParkHelper.ParkYeriGetir();
            for (int i = 0; i < parkYerleri.Count; i++)
            {
                if (parkYerleri[i].ParkDurumu == true)
                {
                    buttons[i].Image = (System.Drawing.Image)(Properties.Resources.dp2);
                }
            }
        }


    }
}