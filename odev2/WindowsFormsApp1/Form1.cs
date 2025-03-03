﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                double sinav1 = Convert.ToDouble(numericUpDown1.Value);
                double sinav2 = Convert.ToDouble(numericUpDown2.Value);
                label3.Visible = true;

                if (sinav1 >= 0 && sinav1 <= 100 && sinav2 >= 0 && sinav2 <= 100)
                {
                    double ortalama = (sinav1 * 0.4) + (sinav2 * 0.6);
                    if (ortalama > 80)
                    {
                        label3.ForeColor = Color.Green;
                        label3.Text = "Geçti\n" + "ortalama:" + ortalama + "\nHarf Notu AA";
                    }

                    else if (ortalama > 70)
                    {
                        label3.ForeColor = Color.Green;
                        label3.Text = "Geçti\n" + "ortalama:" + ortalama + "\nHarf Notu BB";
                    }

                    else if (ortalama > 60)
                    {
                        label3.ForeColor = Color.Green;
                        label3.Text = "Geçti\n" + "ortalama:" + ortalama + "\nHarf Notu CC";
                    }

                    else if (ortalama > 49.5)
                    {
                        label3.ForeColor = Color.Green;
                        label3.Text = "Geçti\n" + "ortalama:" + ortalama + "\nHarf Notu DD";
                    }

                    else if (ortalama < 49.5)
                    {
                        label3.ForeColor = Color.Red;
                        label3.Text = "Kaldı\n" + "ortalama:" + ortalama + "\nHarf Notu FF";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu\n{ex.Message}\n{ex.Data}");
            }
        }
    }
}
