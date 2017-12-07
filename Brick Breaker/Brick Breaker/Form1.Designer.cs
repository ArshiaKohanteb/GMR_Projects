namespace Brick_Breaker
{
    partial class BlockBreaker
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
            this.components = new System.ComponentModel.Container();
            this.X_Y = new System.Windows.Forms.Label();
            this.Paddle_Checker = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OverLoad = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // X_Y
            // 
            this.X_Y.AutoSize = true;
            this.X_Y.BackColor = System.Drawing.Color.Transparent;
            this.X_Y.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_Y.ForeColor = System.Drawing.Color.Gold;
            this.X_Y.Location = new System.Drawing.Point(12, 9);
            this.X_Y.Name = "X_Y";
            this.X_Y.Size = new System.Drawing.Size(46, 28);
            this.X_Y.TabIndex = 0;
            this.X_Y.Text = "X ,Y";
            // 
            // Paddle_Checker
            // 
            this.Paddle_Checker.Interval = 10;
            this.Paddle_Checker.Tick += new System.EventHandler(this.Paddle_Checker_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Brick_Breaker.Properties.Resources.Image_1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1903, 977);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BlockBreaker_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Brick_Breaker.Properties.Resources.Computer;
            this.pictureBox2.Location = new System.Drawing.Point(556, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 194);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Brick_Breaker.Properties.Resources.Keyboard;
            this.pictureBox3.Location = new System.Drawing.Point(489, 356);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(275, 171);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Brick_Breaker.Properties.Resources.Mouse;
            this.pictureBox4.Location = new System.Drawing.Point(791, 356);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(251, 184);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(564, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Computer Overload";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(300, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bricks Left:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OverLoad
            // 
            this.OverLoad.Enabled = true;
            this.OverLoad.Interval = 20;
            this.OverLoad.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Motorwerk", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Start.Location = new System.Drawing.Point(625, 9);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(200, 28);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // BlockBreaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Brick_Breaker.Properties.Resources.Image_1;
            this.ClientSize = new System.Drawing.Size(1903, 977);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.X_Y);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "BlockBreaker";
            this.Text = "Block_Breaker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BlockBreaker_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlockBreaker_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BlockBreaker_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BlockBreaker_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X_Y;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer OverLoad;
        private System.Windows.Forms.Timer Paddle_Checker;
        private System.Windows.Forms.Button Start;

    }
}

