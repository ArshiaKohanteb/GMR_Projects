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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Move On\n P.S. Both Work!");
            Form3 thisismyform2 = new Form3();
            Hide();
            thisismyform2.ShowDialog();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Move On\n P.S. Both Work!");
            Form3 thisismyform2 = new Form3();
            Hide();
            thisismyform2.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox4.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cheater!!");
        }
    }
}
