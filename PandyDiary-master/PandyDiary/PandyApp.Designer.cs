namespace WindowsFormsApplication1
{
    partial class PandyApp
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
            this.lbl_PandyD = new System.Windows.Forms.Label();
            this.prgbar_food = new System.Windows.Forms.ProgressBar();
            this.prgbar_rest = new System.Windows.Forms.ProgressBar();
            this.prgbar_social = new System.Windows.Forms.ProgressBar();
            this.lbl_social = new System.Windows.Forms.Label();
            this.lbl_rest = new System.Windows.Forms.Label();
            this.lbl_food = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerSocial = new System.Windows.Forms.Timer(this.components);
            this.timerRest = new System.Windows.Forms.Timer(this.components);
            this.timerFood = new System.Windows.Forms.Timer(this.components);
            this.graphTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PandyD
            // 
            this.lbl_PandyD.AutoSize = true;
            this.lbl_PandyD.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PandyD.Location = new System.Drawing.Point(258, 9);
            this.lbl_PandyD.Name = "lbl_PandyD";
            this.lbl_PandyD.Size = new System.Drawing.Size(196, 45);
            this.lbl_PandyD.TabIndex = 1;
            this.lbl_PandyD.Text = "Pandy Diary";
            // 
            // prgbar_food
            // 
            this.prgbar_food.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.prgbar_food.ForeColor = System.Drawing.Color.Maroon;
            this.prgbar_food.Location = new System.Drawing.Point(239, 320);
            this.prgbar_food.Name = "prgbar_food";
            this.prgbar_food.Size = new System.Drawing.Size(232, 37);
            this.prgbar_food.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgbar_food.TabIndex = 2;
            this.prgbar_food.Maximum = 200;
            this.prgbar_food.Value = 200;
            this.prgbar_food.Click += new System.EventHandler(this.prgbar_food_Click);
            // 
            // prgbar_rest
            // 
            this.prgbar_rest.Location = new System.Drawing.Point(487, 152);
            this.prgbar_rest.Name = "prgbar_rest";
            this.prgbar_rest.Size = new System.Drawing.Size(211, 37);
            this.prgbar_rest.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgbar_rest.TabIndex = 3;
            this.prgbar_rest.Click += new System.EventHandler(this.prgbar_rest_Click);
            // 
            // prgbar_social
            // 
            this.prgbar_social.Location = new System.Drawing.Point(12, 152);
            this.prgbar_social.Name = "prgbar_social";
            this.prgbar_social.Size = new System.Drawing.Size(212, 37);
            this.prgbar_social.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgbar_social.TabIndex = 4;
            this.prgbar_social.Maximum = 2000;
            this.prgbar_social.Value = 2000;
            this.prgbar_social.Click += new System.EventHandler(this.prgbar_social_Click);
            // 
            // lbl_social
            // 
            this.lbl_social.AutoSize = true;
            this.lbl_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_social.Location = new System.Drawing.Point(85, 124);
            this.lbl_social.Name = "lbl_social";
            this.lbl_social.Size = new System.Drawing.Size(71, 25);
            this.lbl_social.TabIndex = 6;
            this.lbl_social.Text = "Social";
            // 
            // lbl_rest
            // 
            this.lbl_rest.AutoSize = true;
            this.lbl_rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rest.Location = new System.Drawing.Point(552, 124);
            this.lbl_rest.Name = "lbl_rest";
            this.lbl_rest.Size = new System.Drawing.Size(56, 25);
            this.lbl_rest.TabIndex = 7;
            this.lbl_rest.Text = "Rest";
            // 
            // lbl_food
            // 
            this.lbl_food.AutoSize = true;
            this.lbl_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_food.Location = new System.Drawing.Point(331, 292);
            this.lbl_food.Name = "lbl_food";
            this.lbl_food.Size = new System.Drawing.Size(61, 25);
            this.lbl_food.TabIndex = 8;
            this.lbl_food.Text = "Food";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.pandy;
            this.pictureBox1.Location = new System.Drawing.Point(239, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 184);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timerSocial
            // 
            this.timerSocial.Enabled = true;
            this.timerSocial.Interval = 1000;
            this.timerSocial.Tick += new System.EventHandler(this.timerSocial_Tick);
            // 
            // timerRest
            // 
            this.timerRest.Enabled = true;
            this.timerRest.Interval = 1000;
            this.timerRest.Tick += new System.EventHandler(this.timerRest_Tick);
            // 
            // timerFood
            // 
            this.timerFood.Enabled = true;
            this.timerFood.Interval = 1000;
            this.timerFood.Tick += new System.EventHandler(this.timerFood_Tick);
            // 
            // timerFood
            // 
            this.graphTimer.Enabled = true;
            this.graphTimer.Interval = 5000;
            this.graphTimer.Tick += new System.EventHandler(this.graphTimer_Tick);
            // 
            // PandyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 380);
            this.Controls.Add(this.lbl_food);
            this.Controls.Add(this.lbl_rest);
            this.Controls.Add(this.lbl_social);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.prgbar_social);
            this.Controls.Add(this.prgbar_rest);
            this.Controls.Add(this.prgbar_food);
            this.Controls.Add(this.lbl_PandyD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.MinimumSize = new System.Drawing.Size(725, 418);
            this.Name = "PandyApp";
            this.Text = "PandyDiary";
            this.Load += new System.EventHandler(this.PandyApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lbl_PandyD;
        protected System.Windows.Forms.ProgressBar prgbar_food;
        protected System.Windows.Forms.ProgressBar prgbar_rest;
        protected System.Windows.Forms.ProgressBar prgbar_social;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_social;
        private System.Windows.Forms.Label lbl_rest;
        private System.Windows.Forms.Label lbl_food;
        private System.Windows.Forms.Timer timerSocial;
        private System.Windows.Forms.Timer timerRest;
        private System.Windows.Forms.Timer timerFood;
        private System.Windows.Forms.Timer graphTimer;
    }
}

