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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Move On");
            Form2 thisismyform1 = new Form2();
            Hide();
            thisismyform1.ShowDialog();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apparently Your Not That Smart!! :(");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cheater!!");
        }
    }
}
