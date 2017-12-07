using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsIntro
{
    public partial class Hello : Form
    {
        string[] username = new string[3];
        string[] password = new string[3];

        public Hello()
        {
            InitializeComponent();
        }

        private void Hello_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            username[0] = "a";
            username[1] = "b";
            username[2] = "c";                       
            
            password[0] = "a";
            password[1] = "b";
            password[2] = "c";
        
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            for (int i=0; i < username.Length; i++)
            {
                if (UserName_TextBox.Text == username[i] && PassWord_TextBox.Text == password[i])
                {
                    MessageBox.Show("You Have Officially Logged In To HeadQuarters");
                    HeadQuarters form = new HeadQuarters();
                    form.Show();
                }
                if (UserName_TextBox.Text != username[i] || PassWord_TextBox.Text != password[i])
                {
                    MessageBox.Show("You Failed To Login To Headquarters");
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Your PassWord is {0}",password));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UserName_Label_Click(object sender, EventArgs e)
        {
            
        }
    }
}
