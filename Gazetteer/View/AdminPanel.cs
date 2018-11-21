using System;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }


        private void AddAdmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                User.UpdateAdmin("Yes", UsersTable.SelectedRows[0].Cells[0].Value.ToString());
                RefreshTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelAdmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                User.UpdateAdmin("No", UsersTable.SelectedRows[0].Cells[0].Value.ToString());
                RefreshTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminPanel_Activated(object sender, EventArgs e)
        {
            RefreshTable();
        }


        private void RefreshTable()
        {
            UsersTable.DataSource = SQLEditor.DoSqlOperation("SELECT UserLogin, UserEMail, UserMaxScore, UserIsAdmin FROM [User]");
        }
    }
}
