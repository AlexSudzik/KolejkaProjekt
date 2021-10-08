using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolejkaProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataTeraz.Text = DateTime.Now.Date.ToShortDateString();
            GodzinaTeraz.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GodzinaTeraz.Text = DateTime.Now.ToString("hh:mm:ss");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
