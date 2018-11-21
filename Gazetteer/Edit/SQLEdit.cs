using System;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class SQLEdit : Form
    {
        public SQLEdit()
        {
            InitializeComponent();
        }


        private void DoSqlBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ResultTable.DataSource = SQLEditor.DoSqlOperation(QueryField.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DBSchemeBtn_Click(object sender, EventArgs e)
        {
            var form = new DBScheme();
            form.Show();
        }
    }
}
