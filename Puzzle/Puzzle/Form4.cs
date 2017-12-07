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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string info = Clock.Text;
            if (info == "clock")
            {
                MessageBox.Show("Move On");
                Form5 thisismyform5 = new Form5();
                Hide();
                thisismyform5.ShowDialog();
                Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cheater!!");
        }
    }
}
