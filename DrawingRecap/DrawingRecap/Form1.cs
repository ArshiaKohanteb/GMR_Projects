using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingRecap
{
    public partial class Form1 : Form
    { /*gfx.FillEllipse(Brushes.Purple, 100, 100, 50, 100);                             For Next Clas Draw Glasses And Paddles And Balls
     gfx.DrawRectangle(Pens.Red, 200, 200, 50, 50);*/
        
        Graphics gfx;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gfx.FillEllipse(Brushes.SeaGreen, 516, 37, 900, 900);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = CreateGraphics();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = string.Format("X: {0}, Y: {1}", e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gfx.FillEllipse(Brushes.SandyBrown, 771, 171, 80, 80);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gfx.FillEllipse(Brushes.SandyBrown, 1051, 171, 80,80);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gfx.FillEllipse(Brushes.Sienna, 694,352, 500, 500);
            gfx.FillEllipse(Brushes.SeaGreen, 693,281, 500, 500);
        }
        
        private void button5_Click_1(object sender, EventArgs e)
        {
            gfx.DrawLine(Pens.Sienna, 930, 439, 1049, 589);
            gfx.DrawLine(Pens.Sienna, 1049, 589, 855, 579);
            gfx.DrawLine(Pens.Sienna, 855, 579, 930, 439);
            Point[] points = new Point[3];
            points[0] = new Point(930, 439);
            points[1] = new Point(1049, 589);
            points[2] = new Point(855,579);
            gfx.FillPolygon(Brushes.DarkTurquoise, points);
            gfx.FillEllipse(Brushes.Sienna, 900, 537, 37,37);
            gfx.FillEllipse(Brushes.Sienna, 950, 537, 37, 37);
            gfx.DrawLine(Pens.Sienna, 856, 579, 941, 506);
            gfx.DrawLine(Pens.Sienna, 941, 506, 1042, 582);
            gfx.DrawLine(Pens.Sienna, 928, 441, 941, 506);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gfx.DrawLine(Pens.Sienna, 745, 125, 889, 120);
            gfx.DrawLine(Pens.Sienna, 889, 120, 897, 291);
            gfx.DrawLine(Pens.Sienna, 897, 291, 696, 291);
            gfx.DrawLine(Pens.Sienna, 696, 291, 745, 125);
            gfx.DrawLine(Pens.Sienna, 890 , 202, 1025, 202);
            gfx.DrawLine(Pens.Sienna, 1025, 214, 1025, 284);
            gfx.DrawLine(Pens.Sienna, 1025, 284, 1025, 136);
            gfx.DrawLine(Pens.Sienna, 1025, 136, 1164, 131);
            gfx.DrawLine(Pens.Sienna, 1164, 121, 1179, 285);
            gfx.DrawLine(Pens.Sienna, 1179, 285, 1025 , 284);
            gfx.DrawLine(Pens.Sienna, 721, 201, 604, 107);
            gfx.DrawLine(Pens.Sienna, 1173, 211, 1295, 119);
        }
    }
}
