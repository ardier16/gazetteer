namespace Gazetteer
{
    partial class CountryEditor
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
            this.NameField = new System.Windows.Forms.TextBox();
            this.GovernmentField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ContList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.GDPField = new System.Windows.Forms.NumericUpDown();
            this.LeaderField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CapitalList = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LanguagesList = new System.Windows.Forms.ListBox();
            this.CurrencyList = new System.Windows.Forms.ComboBox();
            this.PopulationField = new System.Windows.Forms.NumericUpDown();
            this.AreaField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GDPField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaField)).BeginInit();
            this.SuspendLayout();
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(138, 93);
            this.NameField.MaxLength = 30;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(162, 24);
            this.NameField.TabIndex = 0;
            // 
            // GovernmentField
            // 
            this.GovernmentField.Location = new System.Drawing.Point(138, 262);
            this.GovernmentField.MaxLength = 60;
            this.GovernmentField.Name = "GovernmentField";
            this.GovernmentField.Size = new System.Drawing.Size(233, 24);
            this.GovernmentField.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Population";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Government";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Capital";
            // 
            // ContList
            // 
            this.ContList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContList.FormattingEnabled = true;
            this.ContList.Items.AddRange(new object[] {
            "Africa",
            "Asia",
            "Australia & Oceania",
            "Europe",
            "North America",
            "South America"});
            this.ContList.Location = new System.Drawing.Point(138, 135);
            this.ContList.Name = "ContList";
            this.ContList.Size = new System.Drawing.Size(162, 25);
            this.ContList.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Continent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(251, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "New Country";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(379, 390);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(191, 40);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.LightGreen;
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SaveBtn.Location = new System.Drawing.Point(117, 390);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(183, 40);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(406, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "GDP";
            // 
            // GDPField
            // 
            this.GDPField.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.GDPField.Location = new System.Drawing.Point(489, 98);
            this.GDPField.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.GDPField.Name = "GDPField";
            this.GDPField.Size = new System.Drawing.Size(132, 24);
            this.GDPField.TabIndex = 6;
            this.GDPField.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LeaderField
            // 
            this.LeaderField.Location = new System.Drawing.Point(489, 139);
            this.LeaderField.MaxLength = 30;
            this.LeaderField.Name = "LeaderField";
            this.LeaderField.Size = new System.Drawing.Size(190, 24);
            this.LeaderField.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(406, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "Leader";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(406, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "Currency";
            // 
            // CapitalList
            // 
            this.CapitalList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CapitalList.FormattingEnabled = true;
            this.CapitalList.Location = new System.Drawing.Point(138, 303);
            this.CapitalList.Name = "CapitalList";
            this.CapitalList.Size = new System.Drawing.Size(162, 25);
            this.CapitalList.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(484, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "Languages";
            // 
            // LanguagesList
            // 
            this.LanguagesList.FormattingEnabled = true;
            this.LanguagesList.ItemHeight = 17;
            this.LanguagesList.Location = new System.Drawing.Point(440, 262);
            this.LanguagesList.Name = "LanguagesList";
            this.LanguagesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LanguagesList.Size = new System.Drawing.Size(181, 106);
            this.LanguagesList.TabIndex = 9;
            // 
            // CurrencyList
            // 
            this.CurrencyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyList.FormattingEnabled = true;
            this.CurrencyList.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four"});
            this.CurrencyList.Location = new System.Drawing.Point(489, 178);
            this.CurrencyList.Name = "CurrencyList";
            this.CurrencyList.Size = new System.Drawing.Size(162, 25);
            this.CurrencyList.TabIndex = 8;
            // 
            // PopulationField
            // 
            this.PopulationField.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PopulationField.Location = new System.Drawing.Point(138, 220);
            this.PopulationField.Maximum = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            this.PopulationField.Name = "PopulationField";
            this.PopulationField.Size = new System.Drawing.Size(162, 24);
            this.PopulationField.TabIndex = 3;
            // 
            // AreaField
            // 
            this.AreaField.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AreaField.Location = new System.Drawing.Point(138, 178);
            this.AreaField.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.AreaField.Name = "AreaField";
            this.AreaField.Size = new System.Drawing.Size(162, 24);
            this.AreaField.TabIndex = 2;
            // 
            // CountryEditor
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(724, 462);
            this.Controls.Add(this.LanguagesList);
            this.Controls.Add(this.CurrencyList);
            this.Controls.Add(this.CapitalList);
            this.Controls.Add(this.AreaField);
            this.Controls.Add(this.PopulationField);
            this.Controls.Add(this.GDPField);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ContList);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LeaderField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GovernmentField);
            this.Controls.Add(this.NameField);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CountryEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Country";
            this.Load += new System.EventHandler(this.AddCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GDPField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox GovernmentField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ContList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown GDPField;
        private System.Windows.Forms.TextBox LeaderField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CapitalList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox LanguagesList;
        private System.Windows.Forms.ComboBox CurrencyList;
        private System.Windows.Forms.NumericUpDown PopulationField;
        private System.Windows.Forms.NumericUpDown AreaField;
    }
}