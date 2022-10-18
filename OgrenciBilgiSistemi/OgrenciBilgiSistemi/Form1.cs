using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2  dersprogrami = new Form2();
            dersprogrami.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 notlistesi = new Form3();
            notlistesi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string adsoyad="", ogrencino="";
            adsoyad = textBox1.Text;
            ogrencino = textBox2.Text;
            listBox1.Items.Add("AD SOYAD:" + adsoyad + " | " + "ÖĞRENCİ NO:" + ogrencino );
        }
    }
}
