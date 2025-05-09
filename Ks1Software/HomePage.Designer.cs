namespace Ks1Software
{
    partial class HomePage
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
            this.HelloLbl2 = new System.Windows.Forms.Label();
            this.HelloLbl1 = new System.Windows.Forms.Label();
            this.EnglishBtn = new System.Windows.Forms.Button();
            this.InternetBtn = new System.Windows.Forms.Button();
            this.MathsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloLbl2
            // 
            this.HelloLbl2.AutoSize = true;
            this.HelloLbl2.BackColor = System.Drawing.Color.Transparent;
            this.HelloLbl2.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLbl2.Location = new System.Drawing.Point(93, 280);
            this.HelloLbl2.Name = "HelloLbl2";
            this.HelloLbl2.Size = new System.Drawing.Size(1291, 74);
            this.HelloLbl2.TabIndex = 0;
            this.HelloLbl2.Text = "What would you like to browse today?";
            // 
            // HelloLbl1
            // 
            this.HelloLbl1.AutoSize = true;
            this.HelloLbl1.BackColor = System.Drawing.Color.Transparent;
            this.HelloLbl1.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLbl1.Location = new System.Drawing.Point(544, 114);
            this.HelloLbl1.Name = "HelloLbl1";
            this.HelloLbl1.Size = new System.Drawing.Size(0, 110);
            this.HelloLbl1.TabIndex = 4;
            // 
            // EnglishBtn
            // 
            this.EnglishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EnglishBtn.BackgroundImage = global::Ks1Software.Properties.Resources.English;
            this.EnglishBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnglishBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EnglishBtn.Location = new System.Drawing.Point(1071, 393);
            this.EnglishBtn.Name = "EnglishBtn";
            this.EnglishBtn.Size = new System.Drawing.Size(360, 290);
            this.EnglishBtn.TabIndex = 3;
            this.EnglishBtn.UseVisualStyleBackColor = false;
            this.EnglishBtn.Click += new System.EventHandler(this.EnglishBtn_Click);
            // 
            // InternetBtn
            // 
            this.InternetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InternetBtn.BackgroundImage = global::Ks1Software.Properties.Resources.Internet;
            this.InternetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InternetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InternetBtn.Location = new System.Drawing.Point(563, 393);
            this.InternetBtn.Name = "InternetBtn";
            this.InternetBtn.Size = new System.Drawing.Size(360, 290);
            this.InternetBtn.TabIndex = 2;
            this.InternetBtn.UseVisualStyleBackColor = false;
            this.InternetBtn.Click += new System.EventHandler(this.InternetBtn_Click);
            // 
            // MathsBtn
            // 
            this.MathsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MathsBtn.BackgroundImage = global::Ks1Software.Properties.Resources.Maths1;
            this.MathsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MathsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MathsBtn.Location = new System.Drawing.Point(67, 393);
            this.MathsBtn.Name = "MathsBtn";
            this.MathsBtn.Size = new System.Drawing.Size(360, 290);
            this.MathsBtn.TabIndex = 1;
            this.MathsBtn.UseVisualStyleBackColor = false;
            this.MathsBtn.Click += new System.EventHandler(this.MathsBtn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Ks1Software.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1480, 807);
            this.Controls.Add(this.HelloLbl1);
            this.Controls.Add(this.EnglishBtn);
            this.Controls.Add(this.InternetBtn);
            this.Controls.Add(this.MathsBtn);
            this.Controls.Add(this.HelloLbl2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLbl2;
        private System.Windows.Forms.Button MathsBtn;
        private System.Windows.Forms.Button InternetBtn;
        private System.Windows.Forms.Button EnglishBtn;
        private System.Windows.Forms.Label HelloLbl1;
    }
}