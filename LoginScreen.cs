using ClassItemLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimashk_Street
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }


        public clsUser getActiveUser(string username, string password)
        {
            clsUser user = clsUser.findUser(username, password);

            return user;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text; 

            clsUser activeUser = getActiveUser(userName, password);

            if(activeUser != null)
            {
                UserSession.SetActiveUser(activeUser);
                this.Hide();
                Form form = new Form1();

                

                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("wrong user name or password");
            }
        }
    }
}
