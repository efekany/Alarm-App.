using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Visible = true;
            label2.Visible = true;
            label5.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();

            if (comboBox2.Text == label1.Text&&comboBox1.Text==label2.Text)
            {
                timer1.Enabled = false;
                MessageBox.Show("ALARM ZAMANI GELDİ");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label5.Visible = false;
            for(int a=0;a <= 60; a++)
            {
                comboBox1.Items.Add(a);
            }

            for(int b=0;b < 24; b++)
            {
                comboBox2.Items.Add(b);
            }
        }
    }
}
