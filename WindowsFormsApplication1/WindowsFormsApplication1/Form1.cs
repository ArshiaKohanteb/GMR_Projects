using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Draw : Form
    {
        Graphics gfx;
        public Draw()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Axis.Text = string.Format("X: {0}, Y: {1}", e.X, e.Y);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gfx.FillEllipse(Brushes.Sienna, 573, 226, 50, 50);
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            gfx = CreateGraphics();
        }

        
    
        
    
    
    
    }
}
