namespace Gazetteer
{
    partial class AdminPanel
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
            this.UsersTable = new System.Windows.Forms.DataGridView();
            this.AddAdmBtn = new System.Windows.Forms.Button();
            this.DelAdmBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersTable
            // 
            this.UsersTable.AllowUserToAddRows = false;
            this.UsersTable.AllowUserToDeleteRows = false;
            this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UsersTable.Location = new System.Drawing.Point(13, 113);
            this.UsersTable.Margin = new System.Windows.Forms.Padding(4);
            this.UsersTable.MultiSelect = false;
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.RowHeadersVisible = false;
            this.UsersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersTable.Size = new System.Drawing.Size(413, 286);
            this.UsersTable.TabIndex = 0;
            // 
            // AddAdmBtn
            // 
            this.AddAdmBtn.Location = new System.Drawing.Point(13, 38);
            this.AddAdmBtn.Name = "AddAdmBtn";
            this.AddAdmBtn.Size = new System.Drawing.Size(195, 51);
            this.AddAdmBtn.TabIndex = 1;
            this.AddAdmBtn.Text = "Add Admin";
            this.AddAdmBtn.UseVisualStyleBackColor = true;
            this.AddAdmBtn.Click += new System.EventHandler(this.AddAdmBtn_Click);
            // 
            // DelAdmBtn
            // 
            this.DelAdmBtn.Location = new System.Drawing.Point(238, 38);
            this.DelAdmBtn.Name = "DelAdmBtn";
            this.DelAdmBtn.Size = new System.Drawing.Size(188, 51);
            this.DelAdmBtn.TabIndex = 1;
            this.DelAdmBtn.Text = "Delete Admin";
            this.DelAdmBtn.UseVisualStyleBackColor = true;
            this.DelAdmBtn.Click += new System.EventHandler(this.DelAdmBtn_Click);
            // 
            // AdminPanel
            // 
            this.AcceptButton = this.AddAdmBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 424);
            this.Controls.Add(this.DelAdmBtn);
            this.Controls.Add(this.AddAdmBtn);
            this.Controls.Add(this.UsersTable);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Panel";
            this.Activated += new System.EventHandler(this.AdminPanel_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersTable;
        private System.Windows.Forms.Button AddAdmBtn;
        private System.Windows.Forms.Button DelAdmBtn;
    }
}