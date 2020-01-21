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
    public partial class Form3 : Form
    {
        public Form3()
        {

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var name = textBox1.Text;
            var pass = textBox2.Text;

            var bilgi = KullanıcıHelper.GirisYap(name, pass);

            if (bilgi)
            {
                var form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı   Tekrar Deneyiniz!!");
            }
            

        }
    }
}
