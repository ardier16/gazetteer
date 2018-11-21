using System;
using System.Data;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }


        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = new Gazetteer();
            form.Show();
        }


        private void SignInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MakeSigningIn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            var form = new SignUp();
            form.Show();
            this.Hide();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            var form = new Gazetteer();
            form.Show();
            this.Hide();
        }

        
        private void MakeSigningIn()
        {
            string login = LoginField.Text;
            string pass = PassField.Text;
            DataTable dt = SQLEditor.DoSqlOperation(String.Format("SELECT UserLogin, UserPassword, UserIsAdmin FROM [User] WHERE UserLogin='{0}'", login));


            if (dt.Rows.Count > 0 && pass == dt.Rows[0].ItemArray[1].ToString())
            {
                MessageBox.Show("You've signed in!");
                var form = new Gazetteer(login);
                form.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Incorrect login/password");
        }
    }
}
