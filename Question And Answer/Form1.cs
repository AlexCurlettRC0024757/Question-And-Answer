using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_And_Answer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + textBox1.Text + " The Question Is: 17-2X8=1,Yes or No?");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct " + textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect " + textBox1.Text);
        }
    }
}
