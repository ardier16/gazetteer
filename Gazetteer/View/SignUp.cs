using System;
using System.Windows.Forms;

namespace Gazetteer
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = new Gazetteer();
            form.Show();
        }


        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            MakeSigningUp();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            var form = new Gazetteer();
            form.Show();
            this.Hide();
        }


        private void MakeSigningUp()
        {
            string user = LoginField.Text;
            string email = EMailField.Text;
            string pass = PassField.Text;
            bool cPass = pass == ConfPassField.Text;

            if (user != "" && email.Contains("@") && email.Length > 5 && pass.Length >= 4 && cPass)
            {
                try
                {
                    User.InsertUser(user, pass, email);
                    MessageBox.Show("You've signed up!");
                    HomeBtn_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Your data are incorrect");
        }
    }
}
