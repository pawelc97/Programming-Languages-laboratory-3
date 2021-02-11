using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            label8.Text = null;
            label9.Text = null;
            label10.Text = null;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, d = 0, f = 0, obj_nap = 0, obj_spiryt = 0;
            if((textBox1.Text == null)){ label8.Text = "Wprowadź poprawne dane!"; }
            else { a = Convert.ToDouble(textBox1.Text); }
            if ((textBox2.Text == null) || (Convert.ToDouble(textBox2.Text) < 1)) { label9.Text = "Wprowadź poprawne dane!"; }
            else { b = Convert.ToDouble(textBox2.Text); }
            if ((textBox3.Text == null) || (Convert.ToDouble(textBox3.Text) < 1) || (Convert.ToDouble(textBox3.Text) > 100)) { label10.Text = "Wprowadź poprawne dane!"; }
            else { c = Convert.ToDouble(textBox3.Text); }
            d = (a - ((c/100)*a))*b;
            f = ((c / 100) * a) * b; 
            obj_nap = d * 1000;
            obj_spiryt = f * 1000;
            textBox4.Text = Convert.ToString(obj_nap) + "cm^3";
            textBox5.Text = Convert.ToString(obj_spiryt) + "cm^3";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
