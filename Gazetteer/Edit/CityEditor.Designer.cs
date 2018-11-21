namespace Gazetteer
{
    partial class CityEditor
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LatDegsField = new System.Windows.Forms.NumericUpDown();
            this.LatMinsField = new System.Windows.Forms.NumericUpDown();
            this.LatSecsField = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LatNorthChB = new System.Windows.Forms.RadioButton();
            this.LatSouthChB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LonEastChB = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.LonWestChB = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.LonSecsField = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.LonMinsField = new System.Windows.Forms.NumericUpDown();
            this.LonDegsField = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AreaField = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.LeaderField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BuildYearField = new System.Windows.Forms.NumericUpDown();
            this.PopulationField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LatDegsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatMinsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatSecsField)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LonSecsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LonMinsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LonDegsField)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildYearField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationField)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(247, 428);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(126, 34);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.LightGreen;
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SaveBtn.Location = new System.Drawing.Point(70, 428);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(126, 34);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.Location = new System.Drawing.Point(161, 63);
            this.NameField.MaxLength = 30;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(215, 26);
            this.NameField.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(37, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Longitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Population";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "New City";
            // 
            // LatDegsField
            // 
            this.LatDegsField.Location = new System.Drawing.Point(6, 12);
            this.LatDegsField.Maximum = new decimal(new int[] {
            89,
            0,
            0,
            0});
            this.LatDegsField.Name = "LatDegsField";
            this.LatDegsField.Size = new System.Drawing.Size(59, 24);
            this.LatDegsField.TabIndex = 3;
            // 
            // LatMinsField
            // 
            this.LatMinsField.Location = new System.Drawing.Point(82, 12);
            this.LatMinsField.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.LatMinsField.Name = "LatMinsField";
            this.LatMinsField.Size = new System.Drawing.Size(48, 24);
            this.LatMinsField.TabIndex = 4;
            // 
            // LatSecsField
            // 
            this.LatSecsField.Location = new System.Drawing.Point(153, 12);
            this.LatSecsField.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.LatSecsField.Name = "LatSecsField";
            this.LatSecsField.Size = new System.Drawing.Size(50, 24);
            this.LatSecsField.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "′";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "″";
            // 
            // LatNorthChB
            // 
            this.LatNorthChB.AutoSize = true;
            this.LatNorthChB.Checked = true;
            this.LatNorthChB.Location = new System.Drawing.Point(40, 40);
            this.LatNorthChB.Name = "LatNorthChB";
            this.LatNorthChB.Size = new System.Drawing.Size(36, 21);
            this.LatNorthChB.TabIndex = 6;
            this.LatNorthChB.TabStop = true;
            this.LatNorthChB.Text = "N";
            this.LatNorthChB.UseVisualStyleBackColor = true;
            // 
            // LatSouthChB
            // 
            this.LatSouthChB.AutoSize = true;
            this.LatSouthChB.Location = new System.Drawing.Point(120, 40);
            this.LatSouthChB.Name = "LatSouthChB";
            this.LatSouthChB.Size = new System.Drawing.Size(36, 21);
            this.LatSouthChB.TabIndex = 7;
            this.LatSouthChB.Text = "S";
            this.LatSouthChB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.LatNorthChB);
            this.groupBox1.Controls.Add(this.LatDegsField);
            this.groupBox1.Controls.Add(this.LatMinsField);
            this.groupBox1.Controls.Add(this.LatSecsField);
            this.groupBox1.Controls.Add(this.LatSouthChB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(161, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 67);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // LonEastChB
            // 
            this.LonEastChB.AutoSize = true;
            this.LonEastChB.Checked = true;
            this.LonEastChB.Location = new System.Drawing.Point(49, 44);
            this.LonEastChB.Name = "LonEastChB";
            this.LonEastChB.Size = new System.Drawing.Size(36, 21);
            this.LonEastChB.TabIndex = 11;
            this.LonEastChB.TabStop = true;
            this.LonEastChB.Text = "E";
            this.LonEastChB.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "°";
            // 
            // LonWestChB
            // 
            this.LonWestChB.AutoSize = true;
            this.LonWestChB.Location = new System.Drawing.Point(123, 44);
            this.LonWestChB.Name = "LonWestChB";
            this.LonWestChB.Size = new System.Drawing.Size(41, 21);
            this.LonWestChB.TabIndex = 12;
            this.LonWestChB.Text = "W";
            this.LonWestChB.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(136, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "′";
            // 
            // LonSecsField
            // 
            this.LonSecsField.Location = new System.Drawing.Point(153, 14);
            this.LonSecsField.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.LonSecsField.Name = "LonSecsField";
            this.LonSecsField.Size = new System.Drawing.Size(50, 24);
            this.LonSecsField.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(209, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 17);
            this.label18.TabIndex = 31;
            this.label18.Text = "″";
            // 
            // LonMinsField
            // 
            this.LonMinsField.Location = new System.Drawing.Point(82, 14);
            this.LonMinsField.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.LonMinsField.Name = "LonMinsField";
            this.LonMinsField.Size = new System.Drawing.Size(48, 24);
            this.LonMinsField.TabIndex = 9;
            // 
            // LonDegsField
            // 
            this.LonDegsField.Location = new System.Drawing.Point(6, 12);
            this.LonDegsField.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.LonDegsField.Name = "LonDegsField";
            this.LonDegsField.Size = new System.Drawing.Size(56, 24);
            this.LonDegsField.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LonDegsField);
            this.groupBox2.Controls.Add(this.LonMinsField);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.LonSecsField);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.LonWestChB);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.LonEastChB);
            this.groupBox2.Location = new System.Drawing.Point(161, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 72);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // AreaField
            // 
            this.AreaField.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.AreaField.Location = new System.Drawing.Point(161, 108);
            this.AreaField.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.AreaField.Name = "AreaField";
            this.AreaField.Size = new System.Drawing.Size(164, 24);
            this.AreaField.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(37, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Leader";
            // 
            // LeaderField
            // 
            this.LeaderField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeaderField.Location = new System.Drawing.Point(161, 335);
            this.LeaderField.MaxLength = 100;
            this.LeaderField.Name = "LeaderField";
            this.LeaderField.Size = new System.Drawing.Size(222, 26);
            this.LeaderField.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(37, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 22);
            this.label11.TabIndex = 15;
            this.label11.Text = "Build Year";
            // 
            // BuildYearField
            // 
            this.BuildYearField.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BuildYearField.Location = new System.Drawing.Point(161, 379);
            this.BuildYearField.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.BuildYearField.Name = "BuildYearField";
            this.BuildYearField.Size = new System.Drawing.Size(123, 24);
            this.BuildYearField.TabIndex = 14;
            // 
            // PopulationField
            // 
            this.PopulationField.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PopulationField.Location = new System.Drawing.Point(161, 154);
            this.PopulationField.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PopulationField.Name = "PopulationField";
            this.PopulationField.Size = new System.Drawing.Size(164, 24);
            this.PopulationField.TabIndex = 2;
            // 
            // CityEditor
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(441, 474);
            this.Controls.Add(this.BuildYearField);
            this.Controls.Add(this.PopulationField);
            this.Controls.Add(this.AreaField);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LeaderField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CityEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City Edit";
            this.Load += new System.EventHandler(this.CityEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LatDegsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatMinsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatSecsField)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LonSecsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LonMinsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LonDegsField)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildYearField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LatDegsField;
        private System.Windows.Forms.NumericUpDown LatMinsField;
        private System.Windows.Forms.NumericUpDown LatSecsField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton LatNorthChB;
        private System.Windows.Forms.RadioButton LatSouthChB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LonEastChB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton LonWestChB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown LonSecsField;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown LonMinsField;
        private System.Windows.Forms.NumericUpDown LonDegsField;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown AreaField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LeaderField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown BuildYearField;
        private System.Windows.Forms.NumericUpDown PopulationField;
    }
}