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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pop = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.latD = new System.Windows.Forms.NumericUpDown();
            this.latM = new System.Windows.Forms.NumericUpDown();
            this.latS = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.latN = new System.Windows.Forms.RadioButton();
            this.latSou = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lonE = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.lonW = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.lonS = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.lonM = new System.Windows.Forms.NumericUpDown();
            this.lonD = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.latD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lonS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lonM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lonD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pop
            // 
            this.pop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pop.Location = new System.Drawing.Point(168, 177);
            this.pop.Name = "pop";
            this.pop.Size = new System.Drawing.Size(100, 26);
            this.pop.TabIndex = 21;
            // 
            // area
            // 
            this.area.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.area.Location = new System.Drawing.Point(168, 131);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(100, 26);
            this.area.TabIndex = 20;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(168, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(182, 26);
            this.name.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(37, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Долгота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Широта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Население";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Площадь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Новый город";
            // 
            // latD
            // 
            this.latD.Location = new System.Drawing.Point(6, 12);
            this.latD.Maximum = new decimal(new int[] {
            89,
            0,
            0,
            0});
            this.latD.Name = "latD";
            this.latD.Size = new System.Drawing.Size(59, 24);
            this.latD.TabIndex = 26;
            // 
            // latM
            // 
            this.latM.Location = new System.Drawing.Point(82, 12);
            this.latM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.latM.Name = "latM";
            this.latM.Size = new System.Drawing.Size(48, 24);
            this.latM.TabIndex = 27;
            // 
            // latS
            // 
            this.latS.Location = new System.Drawing.Point(153, 12);
            this.latS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.latS.Name = "latS";
            this.latS.Size = new System.Drawing.Size(50, 24);
            this.latS.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 15);
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
            // latN
            // 
            this.latN.AutoSize = true;
            this.latN.Checked = true;
            this.latN.Location = new System.Drawing.Point(40, 40);
            this.latN.Name = "latN";
            this.latN.Size = new System.Drawing.Size(57, 21);
            this.latN.TabIndex = 29;
            this.latN.TabStop = true;
            this.latN.Text = "с. ш.";
            this.latN.UseVisualStyleBackColor = true;
            // 
            // latSou
            // 
            this.latSou.AutoSize = true;
            this.latSou.Location = new System.Drawing.Point(120, 40);
            this.latSou.Name = "latSou";
            this.latSou.Size = new System.Drawing.Size(60, 21);
            this.latSou.TabIndex = 30;
            this.latSou.Text = "ю. ш.";
            this.latSou.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.latN);
            this.groupBox1.Controls.Add(this.latD);
            this.groupBox1.Controls.Add(this.latM);
            this.groupBox1.Controls.Add(this.latS);
            this.groupBox1.Controls.Add(this.latSou);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(161, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 67);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // lonE
            // 
            this.lonE.AutoSize = true;
            this.lonE.Checked = true;
            this.lonE.Location = new System.Drawing.Point(49, 44);
            this.lonE.Name = "lonE";
            this.lonE.Size = new System.Drawing.Size(55, 21);
            this.lonE.TabIndex = 29;
            this.lonE.TabStop = true;
            this.lonE.Text = "в. д.";
            this.lonE.UseVisualStyleBackColor = true;
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
            // lonW
            // 
            this.lonW.AutoSize = true;
            this.lonW.Location = new System.Drawing.Point(123, 44);
            this.lonW.Name = "lonW";
            this.lonW.Size = new System.Drawing.Size(54, 21);
            this.lonW.TabIndex = 30;
            this.lonW.Text = "з. д.";
            this.lonW.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(142, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "′";
            // 
            // lonS
            // 
            this.lonS.Location = new System.Drawing.Point(159, 13);
            this.lonS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.lonS.Name = "lonS";
            this.lonS.Size = new System.Drawing.Size(50, 24);
            this.lonS.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(215, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 17);
            this.label18.TabIndex = 31;
            this.label18.Text = "″";
            // 
            // lonM
            // 
            this.lonM.Location = new System.Drawing.Point(88, 14);
            this.lonM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.lonM.Name = "lonM";
            this.lonM.Size = new System.Drawing.Size(48, 24);
            this.lonM.TabIndex = 27;
            // 
            // lonD
            // 
            this.lonD.Location = new System.Drawing.Point(6, 12);
            this.lonD.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.lonD.Name = "lonD";
            this.lonD.Size = new System.Drawing.Size(56, 24);
            this.lonD.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lonD);
            this.groupBox2.Controls.Add(this.lonM);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lonS);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lonW);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lonE);
            this.groupBox2.Location = new System.Drawing.Point(161, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 72);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // CityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pop);
            this.Controls.Add(this.area);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CityEditor";
            this.Text = "CityEditor";
            this.Load += new System.EventHandler(this.CityEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.latD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lonS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lonM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lonD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pop;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown latD;
        private System.Windows.Forms.NumericUpDown latM;
        private System.Windows.Forms.NumericUpDown latS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton latN;
        private System.Windows.Forms.RadioButton latSou;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton lonE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton lonW;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown lonS;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown lonM;
        private System.Windows.Forms.NumericUpDown lonD;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}