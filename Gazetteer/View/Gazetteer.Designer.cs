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
            this.CountriesList = new System.Windows.Forms.ListView();
            this.Continent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Population = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Government = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchButton = new System.Windows.Forms.Button();
            this.ContPopResult = new System.Windows.Forms.Label();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.ContsPopBox = new System.Windows.Forms.ComboBox();
            this.GetContPopulation = new System.Windows.Forms.Button();
            this.ContinentPop = new System.Windows.Forms.Label();
            this.SearchHomonyms = new System.Windows.Forms.Label();
            this.StartSearchPos = new System.Windows.Forms.RadioButton();
            this.AnySearchPos = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WorldCountries = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountriesList
            // 
            this.CountriesList.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.CountriesList, "CountriesList");
            this.CountriesList.BackgroundImageTiled = true;
            this.CountriesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Continent,
            this.CName,
            this.Area,
            this.Population,
            this.Government,
            this.Capital});
            this.CountriesList.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CountriesList.FullRowSelect = true;
            this.CountriesList.GridLines = true;
            this.CountriesList.Name = "CountriesList";
            this.CountriesList.ShowItemToolTips = true;
            this.CountriesList.UseCompatibleStateImageBehavior = false;
            this.CountriesList.View = System.Windows.Forms.View.Details;
            this.CountriesList.DoubleClick += new System.EventHandler(this.CountriesList_DoubleClick);
            // 
            // Continent
            // 
            resources.ApplyResources(this.Continent, "Continent");
            // 
            // CName
            // 
            resources.ApplyResources(this.CName, "CName");
            // 
            // Area
            // 
            resources.ApplyResources(this.Area, "Area");
            // 
            // Population
            // 
            resources.ApplyResources(this.Population, "Population");
            // 
            // Government
            // 
            resources.ApplyResources(this.Government, "Government");
            // 
            // Capital
            // 
            resources.ApplyResources(this.Capital, "Capital");
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.SearchButton, "SearchButton");
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ContPopResult
            // 
            resources.ApplyResources(this.ContPopResult, "ContPopResult");
            this.ContPopResult.Name = "ContPopResult";
            // 
            // SearchField
            // 
            resources.ApplyResources(this.SearchField, "SearchField");
            this.SearchField.Name = "SearchField";
            // 
            // ContsPopBox
            // 
            this.ContsPopBox.FormattingEnabled = true;
            resources.ApplyResources(this.ContsPopBox, "ContsPopBox");
            this.ContsPopBox.Name = "ContsPopBox";
            // 
            // GetContPopulation
            // 
            this.GetContPopulation.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.GetContPopulation, "GetContPopulation");
            this.GetContPopulation.Name = "GetContPopulation";
            this.GetContPopulation.UseVisualStyleBackColor = false;
            this.GetContPopulation.Click += new System.EventHandler(this.GetContPopulation_Click);
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
            this.файлToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.справкаToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem1,
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // создатьToolStripMenuItem1
            // 
            this.создатьToolStripMenuItem1.Name = "создатьToolStripMenuItem1";
            resources.ApplyResources(this.создатьToolStripMenuItem1, "создатьToolStripMenuItem1");
            this.создатьToolStripMenuItem1.Click += new System.EventHandler(this.создатьToolStripMenuItem1_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            resources.ApplyResources(this.открытьToolStripMenuItem, "открытьToolStripMenuItem");
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            resources.ApplyResources(this.выходToolStripMenuItem, "выходToolStripMenuItem");
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            resources.ApplyResources(this.редактированиеToolStripMenuItem, "редактированиеToolStripMenuItem");
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            resources.ApplyResources(this.добавитьToolStripMenuItem, "добавитьToolStripMenuItem");
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            resources.ApplyResources(this.изменитьToolStripMenuItem, "изменитьToolStripMenuItem");
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            resources.ApplyResources(this.удалитьToolStripMenuItem, "удалитьToolStripMenuItem");
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            resources.ApplyResources(this.справкаToolStripMenuItem, "справкаToolStripMenuItem");
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gazetteer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WorldCountries);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CountriesList);
            this.Controls.Add(this.AnySearchPos);
            this.Controls.Add(this.StartSearchPos);
            this.Controls.Add(this.SearchHomonyms);
            this.Controls.Add(this.ContinentPop);
            this.Controls.Add(this.GetContPopulation);
            this.Controls.Add(this.ContsPopBox);
            this.Controls.Add(this.SearchField);
            this.Controls.Add(this.ContPopResult);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Gazetteer";
            this.Activated += new System.EventHandler(this.Gazetteer_Activated);
            this.Load += new System.EventHandler(this.Gazetteer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView CountriesList;
        private System.Windows.Forms.ColumnHeader CName;
        private System.Windows.Forms.ColumnHeader Area;
        private System.Windows.Forms.ColumnHeader Population;
        private System.Windows.Forms.ColumnHeader Capital;
        private System.Windows.Forms.ColumnHeader Government;
        private System.Windows.Forms.ColumnHeader Continent;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label ContPopResult;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.ComboBox ContsPopBox;
        private System.Windows.Forms.Button GetContPopulation;
        private System.Windows.Forms.Label ContinentPop;
        private System.Windows.Forms.Label SearchHomonyms;
        private System.Windows.Forms.RadioButton StartSearchPos;
        private System.Windows.Forms.RadioButton AnySearchPos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WorldCountries;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}

