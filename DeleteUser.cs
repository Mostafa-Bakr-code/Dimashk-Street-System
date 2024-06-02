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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private clsUser foundUser = null;

        private clsUser getUser(string userName)
        {

            foundUser = clsUser.findUser(userName);

            if (foundUser != null)
            {

                return foundUser;

            }

            else
            {

                return null;
            }
        }

        private void btnfinditemfordelete_Click(object sender, EventArgs e)
        {
            if (getUser(txtusernamefordelete.Text) != null)
            {
                listViewDeleteUser.Columns.Add("User Name", 150);
                listViewDeleteUser.Columns.Add("Password", 100);
                listViewDeleteUser.Columns.Add("Permissions", 100);

                ListViewItem listViewItem = new ListViewItem(getUser(txtusernamefordelete.Text)._userName);

                listViewItem.SubItems.Add(getUser(txtusernamefordelete.Text)._password);

                listViewItem.SubItems.Add(getUser(txtusernamefordelete.Text)._permissions.ToString());

                listViewDeleteUser.Items.Add(listViewItem);

                btnDeleteUser.Enabled = true;
            }
            else
            {
                MessageBox.Show("User not found!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + foundUser._userName + "?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {

                foundUser.deleteUser();
                MessageBox.Show("User deleted successfully :)");
                txtusernamefordelete.Clear();
                listViewDeleteUser.Items.Clear();
                btnDeleteUser.Enabled = false;

            }

            txtusernamefordelete.Clear();
            listViewDeleteUser.Items.Clear();
            foundUser = null;
            btnDeleteUser.Enabled = false;
        }



    }
}
