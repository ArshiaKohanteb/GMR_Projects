using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finnally!!");
            label1.Text = ("\t\t\t\tYou Won");
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            this.BackgroundImage = Properties.Resources.Swag;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oh No, You Are Lower Than A -1,000,000,000,000,000 IQ");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oh No, Now You Are Lower Than A -1,000,000,00,00,00,000,000,000,000,000,000,000,000,000,000 IQ");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finnally!!");
            label1.Text = ("You Didn't Win You Chated!");
        }
    }
}
