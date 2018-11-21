namespace Gazetteer
{
    partial class SQLEdit
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
            this.QueryField = new System.Windows.Forms.RichTextBox();
            this.ResultTable = new System.Windows.Forms.DataGridView();
            this.DoSqlBtn = new System.Windows.Forms.Button();
            this.DBSchemeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryField
            // 
            this.QueryField.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryField.Location = new System.Drawing.Point(33, 34);
            this.QueryField.Name = "QueryField";
            this.QueryField.Size = new System.Drawing.Size(347, 96);
            this.QueryField.TabIndex = 0;
            this.QueryField.Text = "SELECT";
            // 
            // ResultTable
            // 
            this.ResultTable.AllowUserToAddRows = false;
            this.ResultTable.AllowUserToDeleteRows = false;
            this.ResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ResultTable.Location = new System.Drawing.Point(33, 175);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.RowHeadersVisible = false;
            this.ResultTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultTable.Size = new System.Drawing.Size(556, 204);
            this.ResultTable.TabIndex = 1;
            // 
            // DoSqlBtn
            // 
            this.DoSqlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoSqlBtn.Location = new System.Drawing.Point(398, 34);
            this.DoSqlBtn.Name = "DoSqlBtn";
            this.DoSqlBtn.Size = new System.Drawing.Size(191, 56);
            this.DoSqlBtn.TabIndex = 2;
            this.DoSqlBtn.Text = "DO SQL";
            this.DoSqlBtn.UseVisualStyleBackColor = true;
            this.DoSqlBtn.Click += new System.EventHandler(this.DoSqlBtn_Click);
            // 
            // DBSchemeBtn
            // 
            this.DBSchemeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DBSchemeBtn.Location = new System.Drawing.Point(398, 96);
            this.DBSchemeBtn.Name = "DBSchemeBtn";
            this.DBSchemeBtn.Size = new System.Drawing.Size(191, 56);
            this.DBSchemeBtn.TabIndex = 3;
            this.DBSchemeBtn.Text = "DB Scheme";
            this.DBSchemeBtn.UseVisualStyleBackColor = true;
            this.DBSchemeBtn.Click += new System.EventHandler(this.DBSchemeBtn_Click);
            // 
            // SQLEdit
            // 
            this.AcceptButton = this.DoSqlBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 391);
            this.Controls.Add(this.DBSchemeBtn);
            this.Controls.Add(this.DoSqlBtn);
            this.Controls.Add(this.ResultTable);
            this.Controls.Add(this.QueryField);
            this.Name = "SQLEdit";
            this.Text = "SQL Editor";
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox QueryField;
        private System.Windows.Forms.DataGridView ResultTable;
        private System.Windows.Forms.Button DoSqlBtn;
        private System.Windows.Forms.Button DBSchemeBtn;
    }
}