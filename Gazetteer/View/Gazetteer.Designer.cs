namespace Gazetteer
{
    partial class Gazetteer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gazetteer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ContPopResult = new System.Windows.Forms.Label();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.ContsList = new System.Windows.Forms.ComboBox();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.ContinentPop = new System.Windows.Forms.Label();
            this.SearchHomonyms = new System.Windows.Forms.Label();
            this.StartSearchPos = new System.Windows.Forms.RadioButton();
            this.AnySearchPos = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WorldCountries = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SignInUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.top10CountriesByAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10CountriesByPopulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10CitiesByAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10CitiesByPopulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10MostUsedCurrenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10MostSuccessfullGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCountryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SQLEditorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.requestAdminRootsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CountriesTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CtsSearch = new System.Windows.Forms.RadioButton();
            this.CounSearch = new System.Windows.Forms.RadioButton();
            this.MinAreaField = new System.Windows.Forms.NumericUpDown();
            this.MinPopField = new System.Windows.Forms.NumericUpDown();
            this.MaxAreaField = new System.Windows.Forms.NumericUpDown();
            this.MaxPopField = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountriesTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinAreaField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPopField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxAreaField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPopField)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.SearchBtn, "SearchBtn");
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ContPopResult
            // 
            resources.ApplyResources(this.ContPopResult, "ContPopResult");
            this.ContPopResult.Name = "ContPopResult";
            // 
            // SearchField
            // 
            this.SearchField.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.SearchField, "SearchField");
            this.SearchField.Name = "SearchField";
            // 
            // ContsList
            // 
            this.ContsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContsList.FormattingEnabled = true;
            resources.ApplyResources(this.ContsList, "ContsList");
            this.ContsList.Name = "ContsList";
            // 
            // FilterBtn
            // 
            this.FilterBtn.BackColor = System.Drawing.SystemColors.Control;
            this.FilterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.FilterBtn, "FilterBtn");
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.UseVisualStyleBackColor = false;
            this.FilterBtn.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // ContinentPop
            // 
            resources.ApplyResources(this.ContinentPop, "ContinentPop");
            this.ContinentPop.Name = "ContinentPop";
            // 
            // SearchHomonyms
            // 
            resources.ApplyResources(this.SearchHomonyms, "SearchHomonyms");
            this.SearchHomonyms.Name = "SearchHomonyms";
            // 
            // StartSearchPos
            // 
            resources.ApplyResources(this.StartSearchPos, "StartSearchPos");
            this.StartSearchPos.Checked = true;
            this.StartSearchPos.Name = "StartSearchPos";
            this.StartSearchPos.TabStop = true;
            this.StartSearchPos.UseVisualStyleBackColor = true;
            // 
            // AnySearchPos
            // 
            resources.ApplyResources(this.AnySearchPos, "AnySearchPos");
            this.AnySearchPos.Name = "AnySearchPos";
            this.AnySearchPos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // WorldCountries
            // 
            resources.ApplyResources(this.WorldCountries, "WorldCountries");
            this.WorldCountries.Name = "WorldCountries";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.SignInUpMenu,
            this.AboutMenu,
            this.StatisticsMenu,
            this.NewGameMenu,
            this.EditCountryMenu,
            this.AdminMenu,
            this.SQLEditorMenu,
            this.requestAdminRootsToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            resources.ApplyResources(this.FileMenu, "FileMenu");
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            resources.ApplyResources(this.ExitMenu, "ExitMenu");
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // SignInUpMenu
            // 
            this.SignInUpMenu.Name = "SignInUpMenu";
            resources.ApplyResources(this.SignInUpMenu, "SignInUpMenu");
            this.SignInUpMenu.Click += new System.EventHandler(this.SignInUpMenu_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            resources.ApplyResources(this.AboutMenu, "AboutMenu");
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // StatisticsMenu
            // 
            this.StatisticsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.top10CountriesByAreaToolStripMenuItem,
            this.top10CountriesByPopulationToolStripMenuItem,
            this.top10CitiesByAreaToolStripMenuItem,
            this.top10CitiesByPopulationToolStripMenuItem,
            this.top10MostUsedCurrenciesToolStripMenuItem,
            this.top10MostSuccessfullGamesToolStripMenuItem});
            this.StatisticsMenu.Name = "StatisticsMenu";
            resources.ApplyResources(this.StatisticsMenu, "StatisticsMenu");
            // 
            // top10CountriesByAreaToolStripMenuItem
            // 
            this.top10CountriesByAreaToolStripMenuItem.Name = "top10CountriesByAreaToolStripMenuItem";
            resources.ApplyResources(this.top10CountriesByAreaToolStripMenuItem, "top10CountriesByAreaToolStripMenuItem");
            this.top10CountriesByAreaToolStripMenuItem.Click += new System.EventHandler(this.top10CountriesByAreaToolStripMenuItem_Click);
            // 
            // top10CountriesByPopulationToolStripMenuItem
            // 
            this.top10CountriesByPopulationToolStripMenuItem.Name = "top10CountriesByPopulationToolStripMenuItem";
            resources.ApplyResources(this.top10CountriesByPopulationToolStripMenuItem, "top10CountriesByPopulationToolStripMenuItem");
            this.top10CountriesByPopulationToolStripMenuItem.Click += new System.EventHandler(this.top10CountriesByPopulationToolStripMenuItem_Click);
            // 
            // top10CitiesByAreaToolStripMenuItem
            // 
            this.top10CitiesByAreaToolStripMenuItem.Name = "top10CitiesByAreaToolStripMenuItem";
            resources.ApplyResources(this.top10CitiesByAreaToolStripMenuItem, "top10CitiesByAreaToolStripMenuItem");
            this.top10CitiesByAreaToolStripMenuItem.Click += new System.EventHandler(this.top10CitiesByAreaToolStripMenuItem_Click);
            // 
            // top10CitiesByPopulationToolStripMenuItem
            // 
            this.top10CitiesByPopulationToolStripMenuItem.Name = "top10CitiesByPopulationToolStripMenuItem";
            resources.ApplyResources(this.top10CitiesByPopulationToolStripMenuItem, "top10CitiesByPopulationToolStripMenuItem");
            this.top10CitiesByPopulationToolStripMenuItem.Click += new System.EventHandler(this.top10CitiesByPopulationToolStripMenuItem_Click);
            // 
            // top10MostUsedCurrenciesToolStripMenuItem
            // 
            this.top10MostUsedCurrenciesToolStripMenuItem.Name = "top10MostUsedCurrenciesToolStripMenuItem";
            resources.ApplyResources(this.top10MostUsedCurrenciesToolStripMenuItem, "top10MostUsedCurrenciesToolStripMenuItem");
            this.top10MostUsedCurrenciesToolStripMenuItem.Click += new System.EventHandler(this.top10MostUsedCurrenciesToolStripMenuItem_Click);
            // 
            // top10MostSuccessfullGamesToolStripMenuItem
            // 
            this.top10MostSuccessfullGamesToolStripMenuItem.Name = "top10MostSuccessfullGamesToolStripMenuItem";
            resources.ApplyResources(this.top10MostSuccessfullGamesToolStripMenuItem, "top10MostSuccessfullGamesToolStripMenuItem");
            this.top10MostSuccessfullGamesToolStripMenuItem.Click += new System.EventHandler(this.top10MostSuccessfullGamesToolStripMenuItem_Click);
            // 
            // NewGameMenu
            // 
            this.NewGameMenu.Name = "NewGameMenu";
            resources.ApplyResources(this.NewGameMenu, "NewGameMenu");
            this.NewGameMenu.Click += new System.EventHandler(this.NewGameMenu_Click);
            // 
            // EditCountryMenu
            // 
            this.EditCountryMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenu,
            this.EditMenu,
            this.DeleteMenu});
            this.EditCountryMenu.Name = "EditCountryMenu";
            resources.ApplyResources(this.EditCountryMenu, "EditCountryMenu");
            // 
            // AddMenu
            // 
            this.AddMenu.Name = "AddMenu";
            resources.ApplyResources(this.AddMenu, "AddMenu");
            this.AddMenu.Click += new System.EventHandler(this.AddMenu_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.Name = "EditMenu";
            resources.ApplyResources(this.EditMenu, "EditMenu");
            this.EditMenu.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // DeleteMenu
            // 
            this.DeleteMenu.Name = "DeleteMenu";
            resources.ApplyResources(this.DeleteMenu, "DeleteMenu");
            this.DeleteMenu.Click += new System.EventHandler(this.DeleteMenu_Click);
            // 
            // AdminMenu
            // 
            this.AdminMenu.Name = "AdminMenu";
            resources.ApplyResources(this.AdminMenu, "AdminMenu");
            this.AdminMenu.Click += new System.EventHandler(this.adminPanelToolStripMenuItem_Click);
            // 
            // SQLEditorMenu
            // 
            this.SQLEditorMenu.Name = "SQLEditorMenu";
            resources.ApplyResources(this.SQLEditorMenu, "SQLEditorMenu");
            this.SQLEditorMenu.Click += new System.EventHandler(this.sQLEditorToolStripMenuItem_Click);
            // 
            // requestAdminRootsToolStripMenuItem
            // 
            this.requestAdminRootsToolStripMenuItem.Name = "requestAdminRootsToolStripMenuItem";
            resources.ApplyResources(this.requestAdminRootsToolStripMenuItem, "requestAdminRootsToolStripMenuItem");
            this.requestAdminRootsToolStripMenuItem.Click += new System.EventHandler(this.requestAdminRootsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Data.xml";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // CountriesTable
            // 
            this.CountriesTable.AllowUserToAddRows = false;
            this.CountriesTable.AllowUserToDeleteRows = false;
            this.CountriesTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CountriesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.CountriesTable, "CountriesTable");
            this.CountriesTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CountriesTable.MultiSelect = false;
            this.CountriesTable.Name = "CountriesTable";
            this.CountriesTable.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CountriesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CountriesTable.RowHeadersVisible = false;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.CountriesTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.CountriesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CountriesTable.ShowEditingIcon = false;
            this.CountriesTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CountriesTable_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AnySearchPos);
            this.groupBox1.Controls.Add(this.StartSearchPos);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CtsSearch);
            this.groupBox2.Controls.Add(this.CounSearch);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // CtsSearch
            // 
            resources.ApplyResources(this.CtsSearch, "CtsSearch");
            this.CtsSearch.Name = "CtsSearch";
            this.CtsSearch.UseVisualStyleBackColor = true;
            // 
            // CounSearch
            // 
            resources.ApplyResources(this.CounSearch, "CounSearch");
            this.CounSearch.Checked = true;
            this.CounSearch.Name = "CounSearch";
            this.CounSearch.TabStop = true;
            this.CounSearch.UseVisualStyleBackColor = true;
            // 
            // MinAreaField
            // 
            this.MinAreaField.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            resources.ApplyResources(this.MinAreaField, "MinAreaField");
            this.MinAreaField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MinAreaField.Name = "MinAreaField";
            // 
            // MinPopField
            // 
            this.MinPopField.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            resources.ApplyResources(this.MinPopField, "MinPopField");
            this.MinPopField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MinPopField.Name = "MinPopField";
            // 
            // MaxAreaField
            // 
            this.MaxAreaField.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            resources.ApplyResources(this.MaxAreaField, "MaxAreaField");
            this.MaxAreaField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MaxAreaField.Name = "MaxAreaField";
            // 
            // MaxPopField
            // 
            this.MaxPopField.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            resources.ApplyResources(this.MaxPopField, "MaxPopField");
            this.MaxPopField.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MaxPopField.Name = "MaxPopField";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Gazetteer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.MaxPopField);
            this.Controls.Add(this.MaxAreaField);
            this.Controls.Add(this.MinPopField);
            this.Controls.Add(this.MinAreaField);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CountriesTable);
            this.Controls.Add(this.WorldCountries);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchHomonyms);
            this.Controls.Add(this.ContinentPop);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.ContsList);
            this.Controls.Add(this.SearchField);
            this.Controls.Add(this.ContPopResult);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Gazetteer";
            this.Activated += new System.EventHandler(this.Gazetteer_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gazetteer_FormClosing);
            this.Load += new System.EventHandler(this.Gazetteer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountriesTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinAreaField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPopField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxAreaField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPopField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label ContPopResult;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.ComboBox ContsList;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Label ContinentPop;
        private System.Windows.Forms.Label SearchHomonyms;
        private System.Windows.Forms.RadioButton StartSearchPos;
        private System.Windows.Forms.RadioButton AnySearchPos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WorldCountries;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem EditCountryMenu;
        private System.Windows.Forms.ToolStripMenuItem AddMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView CountriesTable;
        private System.Windows.Forms.ToolStripMenuItem SignInUpMenu;
        private System.Windows.Forms.ToolStripMenuItem StatisticsMenu;
        private System.Windows.Forms.ToolStripMenuItem NewGameMenu;
        private System.Windows.Forms.ToolStripMenuItem AdminMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton CtsSearch;
        private System.Windows.Forms.RadioButton CounSearch;
        private System.Windows.Forms.NumericUpDown MinAreaField;
        private System.Windows.Forms.NumericUpDown MinPopField;
        private System.Windows.Forms.NumericUpDown MaxAreaField;
        private System.Windows.Forms.NumericUpDown MaxPopField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem top10CountriesByAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top10CountriesByPopulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top10CitiesByAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top10CitiesByPopulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SQLEditorMenu;
        private System.Windows.Forms.ToolStripMenuItem top10MostUsedCurrenciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top10MostSuccessfullGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestAdminRootsToolStripMenuItem;
    }
}

