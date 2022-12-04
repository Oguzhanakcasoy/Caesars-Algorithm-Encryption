using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezaralgoritma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//1 buton için atamaları yaptım.
        {
            string mesaj = "";//string türünde belirledim. 
            mesaj = textBox1.Text;//mesaj değişkeninin geleceği yeri tanımladım.
            int anahtar = Convert.ToInt32(textBox2.Text);//anahtarı tanımladım. Burada convert ile dönüştürdüm. Textbox2(anahtar) içerisine yazdığım yazı için tanımladım.
            char[] veri = mesaj.ToCharArray();//mesajı stringden char veri tipine dönüştürdüm. Sonra diziye ekledim.
            foreach(char eleman in veri)
            {
                textBox3.Text += Convert.ToChar(eleman + anahtar).ToString();//3 textbox(Şifre)
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sifre = "";
            sifre = textBox3.Text;
            int anahtar = Convert.ToInt32(textBox2.Text);
            char[] veri2 = sifre.ToCharArray();
            foreach(char eleman2 in veri2) 
            {
                textBox1.Text += Convert.ToChar(eleman2 - anahtar).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)// temizle butonu ile textboxları sildiriyorum.
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox2.Text= "0";
        }
    }
}
