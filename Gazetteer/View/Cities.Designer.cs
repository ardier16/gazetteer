namespace Gazetteer
{
    partial class Cities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cities));
            this.InfoField = new System.Windows.Forms.Label();
            this.SearchingInfo = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMapBtn = new System.Windows.Forms.Button();
            this.CitiesTable = new System.Windows.Forms.DataGridView();
            this.AreaMinField = new System.Windows.Forms.NumericUpDown();
            this.AreaMaxField = new System.Windows.Forms.NumericUpDown();
            this.PopMinField = new System.Windows.Forms.NumericUpDown();
            this.PopMaxField = new System.Windows.Forms.NumericUpDown();
            this.YearMinField = new System.Windows.Forms.NumericUpDown();
            this.YearMaxField = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CitiesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaMinField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaMaxField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopMinField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopMaxField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearMinField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearMaxField)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoField
            // 
            this.InfoField.AutoSize = true;
            this.InfoField.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoField.Location = new System.Drawing.Point(22, 48);
            this.InfoField.Name = "InfoField";
            this.InfoField.Size = new System.Drawing.Size(239, 36);
            this.InfoField.TabIndex = 1;
            this.InfoField.Text = "Search Results:";
            // 
            // SearchingInfo
            // 
            this.SearchingInfo.AutoSize = true;
            this.SearchingInfo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchingInfo.Location = new System.Drawing.Point(414, 48);
            this.SearchingInfo.Name = "SearchingInfo";
            this.SearchingInfo.Size = new System.Drawing.Size(0, 37);
            this.SearchingInfo.TabIndex = 2;
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.LightGreen;
            this.OKBtn.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKBtn.Location = new System.Drawing.Point(661, 27);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(205, 52);
            this.OKBtn.TabIndex = 3;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenu,
            this.EditMenu,
            this.DeleteMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddMenu
            // 
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(65, 20);
            this.AddMenu.Text = "Add City";
            this.AddMenu.Click += new System.EventHandler(this.AddMenu_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(63, 20);
            this.EditMenu.Text = "Edit City";
            this.EditMenu.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // DeleteMenu
            // 
            this.DeleteMenu.Name = "DeleteMenu";
            this.DeleteMenu.Size = new System.Drawing.Size(76, 20);
            this.DeleteMenu.Text = "Delete City";
            this.DeleteMenu.Click += new System.EventHandler(this.DeleteMenu_Click);
            // 
            // ShowMapBtn
            // 
            this.ShowMapBtn.BackColor = System.Drawing.Color.LightBlue;
            this.ShowMapBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowMapBtn.Location = new System.Drawing.Point(661, 85);
            this.ShowMapBtn.Name = "ShowMapBtn";
            this.ShowMapBtn.Size = new System.Drawing.Size(205, 46);
            this.ShowMapBtn.TabIndex = 5;
            this.ShowMapBtn.Text = "Show Map";
            this.ShowMapBtn.UseVisualStyleBackColor = false;
            this.ShowMapBtn.Click += new System.EventHandler(this.ShowMapBtn_Click);
            // 
            // CitiesTable
            // 
            this.CitiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CitiesTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CitiesTable.Location = new System.Drawing.Point(40, 210);
            this.CitiesTable.Name = "CitiesTable";
            this.CitiesTable.ReadOnly = true;
            this.CitiesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CitiesTable.Size = new System.Drawing.Size(826, 345);
            this.CitiesTable.TabIndex = 6;
            // 
            // AreaMinField
            // 
            this.AreaMinField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AreaMinField.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.AreaMinField.Location = new System.Drawing.Point(112, 111);
            this.AreaMinField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AreaMinField.Name = "AreaMinField";
            this.AreaMinField.Size = new System.Drawing.Size(111, 26);
            this.AreaMinField.TabIndex = 7;
            // 
            // AreaMaxField
            // 
            this.AreaMaxField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AreaMaxField.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.AreaMaxField.Location = new System.Drawing.Point(247, 112);
            this.AreaMaxField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AreaMaxField.Name = "AreaMaxField";
            this.AreaMaxField.Size = new System.Drawing.Size(116, 26);
            this.AreaMaxField.TabIndex = 7;
            // 
            // PopMinField
            // 
            this.PopMinField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PopMinField.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PopMinField.Location = new System.Drawing.Point(112, 161);
            this.PopMinField.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.PopMinField.Name = "PopMinField";
            this.PopMinField.Size = new System.Drawing.Size(111, 26);
            this.PopMinField.TabIndex = 7;
            // 
            // PopMaxField
            // 
            this.PopMaxField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PopMaxField.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PopMaxField.Location = new System.Drawing.Point(247, 162);
            this.PopMaxField.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.PopMaxField.Name = "PopMaxField";
            this.PopMaxField.Size = new System.Drawing.Size(116, 26);
            this.PopMaxField.TabIndex = 7;
            // 
            // YearMinField
            // 
            this.YearMinField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearMinField.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.YearMinField.Location = new System.Drawing.Point(453, 110);
            this.YearMinField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.YearMinField.Name = "YearMinField";
            this.YearMinField.Size = new System.Drawing.Size(74, 26);
            this.YearMinField.TabIndex = 7;
            // 
            // YearMaxField
            // 
            this.YearMaxField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearMaxField.Location = new System.Drawing.Point(562, 110);
            this.YearMaxField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.YearMaxField.Name = "YearMaxField";
            this.YearMaxField.Size = new System.Drawing.Size(73, 26);
            this.YearMaxField.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Population";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(225, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(225, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(545, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(397, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Year";
            // 
            // FilterBtn
            // 
            this.FilterBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterBtn.Location = new System.Drawing.Point(401, 150);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(234, 44);
            this.FilterBtn.TabIndex = 8;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetBtn.Location = new System.Drawing.Point(661, 150);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(205, 44);
            this.ResetBtn.TabIndex = 9;
            this.ResetBtn.Text = "Reset Filter Data";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Cities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(916, 581);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.YearMaxField);
            this.Controls.Add(this.PopMaxField);
            this.Controls.Add(this.YearMinField);
            this.Controls.Add(this.PopMinField);
            this.Controls.Add(this.AreaMaxField);
            this.Controls.Add(this.AreaMinField);
            this.Controls.Add(this.CitiesTable);
            this.Controls.Add(this.ShowMapBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.SearchingInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoField);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Cities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cities\' Info";
            this.Activated += new System.EventHandler(this.Cities_Activated);
            this.Load += new System.EventHandler(this.Cities_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CitiesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaMinField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaMaxField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopMinField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopMaxField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearMinField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearMaxField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InfoField;
        private System.Windows.Forms.Label SearchingInfo;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenu;
        private System.Windows.Forms.Button ShowMapBtn;
        private System.Windows.Forms.DataGridView CitiesTable;
        private System.Windows.Forms.NumericUpDown AreaMinField;
        private System.Windows.Forms.NumericUpDown AreaMaxField;
        private System.Windows.Forms.NumericUpDown PopMinField;
        private System.Windows.Forms.NumericUpDown PopMaxField;
        private System.Windows.Forms.NumericUpDown YearMinField;
        private System.Windows.Forms.NumericUpDown YearMaxField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Button ResetBtn;
    }
}