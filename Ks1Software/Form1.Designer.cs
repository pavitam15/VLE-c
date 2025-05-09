namespace Ks1Software
{
    partial class Form1
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
            this.WelcomeLbl1 = new System.Windows.Forms.Label();
            this.WelcomeLbl2 = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SubmitNameBtn = new System.Windows.Forms.Button();
            this.MathsImg = new System.Windows.Forms.PictureBox();
            this.InternetImg = new System.Windows.Forms.PictureBox();
            this.EnglishImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MathsImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InternetImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnglishImg)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLbl1
            // 
            this.WelcomeLbl1.AutoSize = true;
            this.WelcomeLbl1.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLbl1.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl1.Location = new System.Drawing.Point(499, 42);
            this.WelcomeLbl1.Name = "WelcomeLbl1";
            this.WelcomeLbl1.Size = new System.Drawing.Size(497, 110);
            this.WelcomeLbl1.TabIndex = 0;
            this.WelcomeLbl1.Text = "Hi There!";
            this.WelcomeLbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLbl1.Click += new System.EventHandler(this.WelcomeLbl1_Click);
            // 
            // WelcomeLbl2
            // 
            this.WelcomeLbl2.AutoSize = true;
            this.WelcomeLbl2.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLbl2.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl2.Location = new System.Drawing.Point(329, 171);
            this.WelcomeLbl2.Name = "WelcomeLbl2";
            this.WelcomeLbl2.Size = new System.Drawing.Size(821, 74);
            this.WelcomeLbl2.TabIndex = 1;
            this.WelcomeLbl2.Text = "Welcome to KS1 Browse";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameLbl.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(445, 282);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(603, 55);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Please enter your name:";
            this.NameLbl.Click += new System.EventHandler(this.NameLbl_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NameTxt.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.ForeColor = System.Drawing.Color.Gray;
            this.NameTxt.Location = new System.Drawing.Point(519, 363);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(333, 48);
            this.NameTxt.TabIndex = 3;
            this.NameTxt.Text = "First Name";
            this.NameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.NameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxt_KeyPressed);
            // 
            // SubmitNameBtn
            // 
            this.SubmitNameBtn.BackColor = System.Drawing.Color.Gray;
            this.SubmitNameBtn.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitNameBtn.Location = new System.Drawing.Point(868, 363);
            this.SubmitNameBtn.Name = "SubmitNameBtn";
            this.SubmitNameBtn.Size = new System.Drawing.Size(94, 49);
            this.SubmitNameBtn.TabIndex = 4;
            this.SubmitNameBtn.Text = "Submit";
            this.SubmitNameBtn.UseVisualStyleBackColor = false;
            this.SubmitNameBtn.Click += new System.EventHandler(this.SubmitNameBtn_Click);
            // 
            // MathsImg
            // 
            this.MathsImg.BackColor = System.Drawing.Color.Transparent;
            this.MathsImg.BackgroundImage = global::Ks1Software.Properties.Resources.MathOwl;
            this.MathsImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MathsImg.Location = new System.Drawing.Point(1085, 411);
            this.MathsImg.Name = "MathsImg";
            this.MathsImg.Size = new System.Drawing.Size(367, 387);
            this.MathsImg.TabIndex = 8;
            this.MathsImg.TabStop = false;
            // 
            // InternetImg
            // 
            this.InternetImg.BackColor = System.Drawing.Color.Transparent;
            this.InternetImg.BackgroundImage = global::Ks1Software.Properties.Resources.wifi;
            this.InternetImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InternetImg.Location = new System.Drawing.Point(496, 483);
            this.InternetImg.Name = "InternetImg";
            this.InternetImg.Size = new System.Drawing.Size(492, 315);
            this.InternetImg.TabIndex = 7;
            this.InternetImg.TabStop = false;
            // 
            // EnglishImg
            // 
            this.EnglishImg.BackColor = System.Drawing.Color.Transparent;
            this.EnglishImg.BackgroundImage = global::Ks1Software.Properties.Resources.PencilIcon;
            this.EnglishImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnglishImg.Location = new System.Drawing.Point(12, 411);
            this.EnglishImg.Name = "EnglishImg";
            this.EnglishImg.Size = new System.Drawing.Size(302, 387);
            this.EnglishImg.TabIndex = 6;
            this.EnglishImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Ks1Software.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1464, 810);
            this.Controls.Add(this.MathsImg);
            this.Controls.Add(this.InternetImg);
            this.Controls.Add(this.EnglishImg);
            this.Controls.Add(this.SubmitNameBtn);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.WelcomeLbl2);
            this.Controls.Add(this.WelcomeLbl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "KS1Browse";
            ((System.ComponentModel.ISupportInitialize)(this.MathsImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InternetImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnglishImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLbl1;
        private System.Windows.Forms.Label WelcomeLbl2;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Button SubmitNameBtn;
        private System.Windows.Forms.PictureBox EnglishImg;
        private System.Windows.Forms.PictureBox InternetImg;
        private System.Windows.Forms.PictureBox MathsImg;
    }
}

