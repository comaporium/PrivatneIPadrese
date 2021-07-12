using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace privatneijavneIPadrese
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label7.Visible = false;
            label8.Visible = false;
            button4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox4.Text);
    
            if (a==10)
            {
                label7.Visible = true;
                label8.Visible = true;
                label7.Text = "Unesena IP adresa je privatna";
                label8.Text = "Pripada bloku 10.0.0.0/8";
            } else if ((a==172) && (b>=16) && (b<=31))
            {
                label7.Visible = true;
                label8.Visible = true;
                label7.Text = "Unesena IP adresa je privatna";
                label8.Text = "Pripada bloku 172.16.0.0/12";
            } else if (a==192 && b==168)
            {
                label7.Visible = true;
                label8.Visible = true;
                label7.Text = "Unesena IP adresa je privatna";
                label8.Text = "Pripada bloku 192.168.0.0/16";
            } else
            {
                label7.Visible = true;
                label7.Text = "Unesena IP adresa je javna";
                label8.Text = "";
            }
            if (a > 255 || b > 255 || c > 255 || d > 255)
            {
                button4.Visible = true;
                label7.Visible = true;
                label7.Text = "Pogrešno unesena IP adresa";
                label8.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            label7.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            button4.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label8.Text = "";
        }
    }
}
