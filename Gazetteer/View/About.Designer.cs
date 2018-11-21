namespace Gazetteer
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Title = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.Copy = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(147, 23);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(139, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "Gazetteer";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(49, 75);
            this.Info.MaximumSize = new System.Drawing.Size(400, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(329, 50);
            this.Info.TabIndex = 1;
            this.Info.Text = "Course Work made by SE-15-5\'s student  Maxim Shopinsky";
            this.Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Copy
            // 
            this.Copy.AutoSize = true;
            this.Copy.Location = new System.Drawing.Point(150, 334);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(108, 18);
            this.Copy.TabIndex = 6;
            this.Copy.Text = "NURE © 2016";
            // 
            // pic
            // 
            this.pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic.BackgroundImage")));
            this.pic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic.InitialImage")));
            this.pic.Location = new System.Drawing.Point(113, 128);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(196, 193);
            this.pic.TabIndex = 24;
            this.pic.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(426, 361);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Copy;
        private System.Windows.Forms.PictureBox pic;
    }
}