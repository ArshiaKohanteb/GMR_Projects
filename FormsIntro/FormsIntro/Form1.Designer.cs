namespace FormsIntro
{
    partial class Hello
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.UserName_Label = new System.Windows.Forms.Label();
            this.UserName_TextBox = new System.Windows.Forms.TextBox();
            this.PassWord_TextBox = new System.Windows.Forms.TextBox();
            this.PassWord_Label = new System.Windows.Forms.Label();
            this.HeadQuarters_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.loginButton.Font = new System.Drawing.Font("Motorwerk", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginButton.Location = new System.Drawing.Point(1455, 670);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(330, 102);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // UserName_Label
            // 
            this.UserName_Label.Font = new System.Drawing.Font("Motorwerk", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_Label.ForeColor = System.Drawing.SystemColors.Info;
            this.UserName_Label.Location = new System.Drawing.Point(475, 411);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(505, 93);
            this.UserName_Label.TabIndex = 1;
            this.UserName_Label.Text = "UserName:";
            this.UserName_Label.Click += new System.EventHandler(this.UserName_Label_Click);
            // 
            // UserName_TextBox
            // 
            this.UserName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_TextBox.Location = new System.Drawing.Point(1006, 401);
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.Size = new System.Drawing.Size(397, 116);
            this.UserName_TextBox.TabIndex = 2;
            // 
            // PassWord_TextBox
            // 
            this.PassWord_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord_TextBox.Location = new System.Drawing.Point(1006, 656);
            this.PassWord_TextBox.Name = "PassWord_TextBox";
            this.PassWord_TextBox.Size = new System.Drawing.Size(397, 116);
            this.PassWord_TextBox.TabIndex = 3;
            this.PassWord_TextBox.UseSystemPasswordChar = true;
            // 
            // PassWord_Label
            // 
            this.PassWord_Label.AutoSize = true;
            this.PassWord_Label.Font = new System.Drawing.Font("Motorwerk", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord_Label.ForeColor = System.Drawing.SystemColors.Info;
            this.PassWord_Label.Location = new System.Drawing.Point(475, 678);
            this.PassWord_Label.Name = "PassWord_Label";
            this.PassWord_Label.Size = new System.Drawing.Size(504, 73);
            this.PassWord_Label.TabIndex = 4;
            this.PassWord_Label.Text = "PassWord:";
            // 
            // HeadQuarters_Label
            // 
            this.HeadQuarters_Label.AutoSize = true;
            this.HeadQuarters_Label.Font = new System.Drawing.Font("Motorwerk", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadQuarters_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeadQuarters_Label.Location = new System.Drawing.Point(39, 46);
            this.HeadQuarters_Label.Name = "HeadQuarters_Label";
            this.HeadQuarters_Label.Size = new System.Drawing.Size(1808, 153);
            this.HeadQuarters_Label.TabIndex = 5;
            this.HeadQuarters_Label.Text = "HeadQuarter LOgin";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Motorwerk", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(905, 793);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(880, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Click Here If You Forgot Your HeadQuarter Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1924, 1006);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HeadQuarters_Label);
            this.Controls.Add(this.PassWord_Label);
            this.Controls.Add(this.PassWord_TextBox);
            this.Controls.Add(this.UserName_TextBox);
            this.Controls.Add(this.UserName_Label);
            this.Controls.Add(this.loginButton);
            this.Name = "Hello";
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.Hello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label UserName_Label;
        private System.Windows.Forms.TextBox UserName_TextBox;
        private System.Windows.Forms.TextBox PassWord_TextBox;
        private System.Windows.Forms.Label PassWord_Label;
        private System.Windows.Forms.Label HeadQuarters_Label;
        private System.Windows.Forms.Button button1;
    }
}

