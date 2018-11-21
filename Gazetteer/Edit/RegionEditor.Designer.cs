namespace Gazetteer
{
    partial class RegionEditor
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
            this.LeaderField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CenterList = new System.Windows.Forms.ComboBox();
            this.AreaField = new System.Windows.Forms.NumericUpDown();
            this.TypeList = new System.Windows.Forms.ComboBox();
            this.PopulationField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AreaField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationField)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(222, 349);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(126, 34);
            this.CancelBtn.TabIndex = 25;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // LeaderField
            // 
            this.LeaderField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeaderField.Location = new System.Drawing.Point(167, 301);
            this.LeaderField.Name = "LeaderField";
            this.LeaderField.Size = new System.Drawing.Size(181, 26);
            this.LeaderField.TabIndex = 23;
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.Location = new System.Drawing.Point(166, 78);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(182, 26);
            this.NameField.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(36, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Leader";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(35, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Population";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 78);
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
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "New Region";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.LightGreen;
            this.SaveBtn.Location = new System.Drawing.Point(52, 349);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(126, 34);
            this.SaveBtn.TabIndex = 24;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(35, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Center";
            // 
            // CenterList
            // 
            this.CenterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CenterList.FormattingEnabled = true;
            this.CenterList.Location = new System.Drawing.Point(167, 256);
            this.CenterList.Name = "CenterList";
            this.CenterList.Size = new System.Drawing.Size(181, 26);
            this.CenterList.TabIndex = 27;
            // 
            // AreaField
            // 
            this.AreaField.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AreaField.Location = new System.Drawing.Point(166, 122);
            this.AreaField.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.AreaField.Name = "AreaField";
            this.AreaField.Size = new System.Drawing.Size(182, 24);
            this.AreaField.TabIndex = 26;
            // 
            // TypeList
            // 
            this.TypeList.FormattingEnabled = true;
            this.TypeList.Location = new System.Drawing.Point(167, 211);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(181, 26);
            this.TypeList.TabIndex = 29;
            this.TypeList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.type_KeyPress);
            // 
            // PopulationField
            // 
            this.PopulationField.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PopulationField.Location = new System.Drawing.Point(166, 165);
            this.PopulationField.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.PopulationField.Name = "PopulationField";
            this.PopulationField.Size = new System.Drawing.Size(182, 24);
            this.PopulationField.TabIndex = 26;
            // 
            // RegionEditor
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(409, 404);
            this.Controls.Add(this.TypeList);
            this.Controls.Add(this.CenterList);
            this.Controls.Add(this.PopulationField);
            this.Controls.Add(this.AreaField);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LeaderField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RegionEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Region";
            this.Load += new System.EventHandler(this.RegionEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AreaField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox LeaderField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CenterList;
        private System.Windows.Forms.NumericUpDown AreaField;
        private System.Windows.Forms.ComboBox TypeList;
        private System.Windows.Forms.NumericUpDown PopulationField;
    }
}