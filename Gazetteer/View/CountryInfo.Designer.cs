namespace Gazetteer
{
    partial class CountryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryInfo));
            this.Info = new System.Windows.Forms.Label();
            this.CName = new System.Windows.Forms.Label();
            this.CArea = new System.Windows.Forms.Label();
            this.CPopulation = new System.Windows.Forms.Label();
            this.CGovernment = new System.Windows.Forms.Label();
            this.CCapital = new System.Windows.Forms.Label();
            this.CLanguages = new System.Windows.Forms.Label();
            this.CountryRegions = new System.Windows.Forms.ListView();
            this.RegionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegionArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegionPopulation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegionUrban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegionCenter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountryName = new System.Windows.Forms.Label();
            this.CountryArea = new System.Windows.Forms.Label();
            this.CountryPop = new System.Windows.Forms.Label();
            this.CountryGov = new System.Windows.Forms.Label();
            this.CountryCap = new System.Windows.Forms.Label();
            this.CountryLangs = new System.Windows.Forms.Label();
            this.CRegions = new System.Windows.Forms.Label();
            this.CUrbanization = new System.Windows.Forms.Label();
            this.CountryUrban = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.Name = "Info";
            // 
            // CName
            // 
            resources.ApplyResources(this.CName, "CName");
            this.CName.Name = "CName";
            // 
            // CArea
            // 
            resources.ApplyResources(this.CArea, "CArea");
            this.CArea.Name = "CArea";
            // 
            // CPopulation
            // 
            resources.ApplyResources(this.CPopulation, "CPopulation");
            this.CPopulation.Name = "CPopulation";
            // 
            // CGovernment
            // 
            resources.ApplyResources(this.CGovernment, "CGovernment");
            this.CGovernment.Name = "CGovernment";
            // 
            // CCapital
            // 
            resources.ApplyResources(this.CCapital, "CCapital");
            this.CCapital.Name = "CCapital";
            // 
            // CLanguages
            // 
            resources.ApplyResources(this.CLanguages, "CLanguages");
            this.CLanguages.Name = "CLanguages";
            // 
            // CountryRegions
            // 
            resources.ApplyResources(this.CountryRegions, "CountryRegions");
            this.CountryRegions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RegionName,
            this.RegionType,
            this.RegionArea,
            this.RegionPopulation,
            this.RegionUrban,
            this.RegionCenter});
            this.CountryRegions.FullRowSelect = true;
            this.CountryRegions.GridLines = true;
            this.CountryRegions.Name = "CountryRegions";
            this.CountryRegions.ShowItemToolTips = true;
            this.CountryRegions.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.CountryRegions.UseCompatibleStateImageBehavior = false;
            this.CountryRegions.View = System.Windows.Forms.View.Details;
            this.CountryRegions.DoubleClick += new System.EventHandler(this.CountryRegions_DoubleClick);
            // 
            // RegionName
            // 
            resources.ApplyResources(this.RegionName, "RegionName");
            // 
            // RegionType
            // 
            resources.ApplyResources(this.RegionType, "RegionType");
            // 
            // RegionArea
            // 
            resources.ApplyResources(this.RegionArea, "RegionArea");
            // 
            // RegionPopulation
            // 
            resources.ApplyResources(this.RegionPopulation, "RegionPopulation");
            // 
            // RegionUrban
            // 
            resources.ApplyResources(this.RegionUrban, "RegionUrban");
            // 
            // RegionCenter
            // 
            resources.ApplyResources(this.RegionCenter, "RegionCenter");
            // 
            // CountryName
            // 
            resources.ApplyResources(this.CountryName, "CountryName");
            this.CountryName.Name = "CountryName";
            // 
            // CountryArea
            // 
            resources.ApplyResources(this.CountryArea, "CountryArea");
            this.CountryArea.Name = "CountryArea";
            // 
            // CountryPop
            // 
            resources.ApplyResources(this.CountryPop, "CountryPop");
            this.CountryPop.Name = "CountryPop";
            // 
            // CountryGov
            // 
            resources.ApplyResources(this.CountryGov, "CountryGov");
            this.CountryGov.Name = "CountryGov";
            // 
            // CountryCap
            // 
            resources.ApplyResources(this.CountryCap, "CountryCap");
            this.CountryCap.Name = "CountryCap";
            // 
            // CountryLangs
            // 
            resources.ApplyResources(this.CountryLangs, "CountryLangs");
            this.CountryLangs.Name = "CountryLangs";
            // 
            // CRegions
            // 
            resources.ApplyResources(this.CRegions, "CRegions");
            this.CRegions.Name = "CRegions";
            // 
            // CUrbanization
            // 
            resources.ApplyResources(this.CUrbanization, "CUrbanization");
            this.CUrbanization.Name = "CUrbanization";
            // 
            // CountryUrban
            // 
            resources.ApplyResources(this.CountryUrban, "CountryUrban");
            this.CountryUrban.Name = "CountryUrban";
            // 
            // CountryInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.CountryUrban);
            this.Controls.Add(this.CUrbanization);
            this.Controls.Add(this.CRegions);
            this.Controls.Add(this.CountryLangs);
            this.Controls.Add(this.CountryCap);
            this.Controls.Add(this.CountryGov);
            this.Controls.Add(this.CountryPop);
            this.Controls.Add(this.CountryArea);
            this.Controls.Add(this.CountryName);
            this.Controls.Add(this.CountryRegions);
            this.Controls.Add(this.CLanguages);
            this.Controls.Add(this.CCapital);
            this.Controls.Add(this.CGovernment);
            this.Controls.Add(this.CPopulation);
            this.Controls.Add(this.CArea);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CountryInfo";
            this.Load += new System.EventHandler(this.CountryInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label CName;
        private System.Windows.Forms.Label CArea;
        private System.Windows.Forms.Label CPopulation;
        private System.Windows.Forms.Label CGovernment;
        private System.Windows.Forms.Label CCapital;
        private System.Windows.Forms.Label CLanguages;
        private System.Windows.Forms.ListView CountryRegions;
        private System.Windows.Forms.Label CountryName;
        private System.Windows.Forms.Label CountryArea;
        private System.Windows.Forms.Label CountryPop;
        private System.Windows.Forms.Label CountryGov;
        private System.Windows.Forms.Label CountryCap;
        private System.Windows.Forms.Label CountryLangs;
        private System.Windows.Forms.Label CRegions;
        private System.Windows.Forms.ColumnHeader RegionName;
        private System.Windows.Forms.ColumnHeader RegionType;
        private System.Windows.Forms.ColumnHeader RegionArea;
        private System.Windows.Forms.ColumnHeader RegionPopulation;
        private System.Windows.Forms.ColumnHeader RegionCenter;
        private System.Windows.Forms.Label CUrbanization;
        private System.Windows.Forms.Label CountryUrban;
        private System.Windows.Forms.ColumnHeader RegionUrban;
    }
}