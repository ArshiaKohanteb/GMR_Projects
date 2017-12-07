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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Move On");
            Form4 thisismyform3 = new Form4();
            Hide();
            thisismyform3.ShowDialog();
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aww : (");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cheater!!");
        }

        
    }
}
