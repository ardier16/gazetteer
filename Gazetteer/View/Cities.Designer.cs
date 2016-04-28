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
            this.CitiesList = new System.Windows.Forms.ListView();
            this.CityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityPopulation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityLatitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityLongitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InfoField = new System.Windows.Forms.Label();
            this.SearchingInfo = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CitiesList
            // 
            this.CitiesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CitiesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CityName,
            this.CityRegion,
            this.CityArea,
            this.CityPopulation,
            this.CityLatitude,
            this.CityLongitude});
            this.CitiesList.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CitiesList.FullRowSelect = true;
            this.CitiesList.GridLines = true;
            this.CitiesList.Location = new System.Drawing.Point(1, 153);
            this.CitiesList.Margin = new System.Windows.Forms.Padding(4);
            this.CitiesList.Name = "CitiesList";
            this.CitiesList.ShowItemToolTips = true;
            this.CitiesList.Size = new System.Drawing.Size(912, 392);
            this.CitiesList.TabIndex = 0;
            this.CitiesList.UseCompatibleStateImageBehavior = false;
            this.CitiesList.View = System.Windows.Forms.View.Details;
            // 
            // CityName
            // 
            this.CityName.Text = "Название";
            this.CityName.Width = 130;
            // 
            // CityRegion
            // 
            this.CityRegion.Text = "Регион";
            this.CityRegion.Width = 230;
            // 
            // CityArea
            // 
            this.CityArea.Text = "Площадь, кв. км";
            this.CityArea.Width = 135;
            // 
            // CityPopulation
            // 
            this.CityPopulation.Text = "Население, тыс. чел.";
            this.CityPopulation.Width = 170;
            // 
            // CityLatitude
            // 
            this.CityLatitude.Text = "Широта";
            this.CityLatitude.Width = 120;
            // 
            // CityLongitude
            // 
            this.CityLongitude.Text = "Долгота";
            this.CityLongitude.Width = 120;
            // 
            // InfoField
            // 
            this.InfoField.AutoSize = true;
            this.InfoField.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoField.Location = new System.Drawing.Point(22, 48);
            this.InfoField.Name = "InfoField";
            this.InfoField.Size = new System.Drawing.Size(386, 45);
            this.InfoField.TabIndex = 1;
            this.InfoField.Text = "Результаты поиска: ";
            // 
            // SearchingInfo
            // 
            this.SearchingInfo.AutoSize = true;
            this.SearchingInfo.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchingInfo.Location = new System.Drawing.Point(414, 48);
            this.SearchingInfo.Name = "SearchingInfo";
            this.SearchingInfo.Size = new System.Drawing.Size(0, 46);
            this.SearchingInfo.TabIndex = 2;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.LightGreen;
            this.OKButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(747, 40);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(122, 71);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // Cities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(916, 547);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.SearchingInfo);
            this.Controls.Add(this.InfoField);
            this.Controls.Add(this.CitiesList);
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
            this.Text = "Информация о городах";
            this.Activated += new System.EventHandler(this.Cities_Activated);
            this.Load += new System.EventHandler(this.Cities_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CitiesList;
        private System.Windows.Forms.ColumnHeader CityName;
        private System.Windows.Forms.ColumnHeader CityRegion;
        private System.Windows.Forms.ColumnHeader CityArea;
        private System.Windows.Forms.ColumnHeader CityPopulation;
        private System.Windows.Forms.ColumnHeader CityLatitude;
        private System.Windows.Forms.ColumnHeader CityLongitude;
        private System.Windows.Forms.Label InfoField;
        private System.Windows.Forms.Label SearchingInfo;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}