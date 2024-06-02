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
    public partial class UpdateUser : Form 
    {
        public UpdateUser()
        {
            InitializeComponent();
            InitializeCheckBoxHandlers();
        }


        //--------------------------------------------------------------------------------------
        // Permissions

        private void InitializeCheckBoxHandlers()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                }
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSum();
        }

        private int UpdateSum()
        {
            int sum = 0;


            foreach (Control control in groupBox1.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    if (int.TryParse(checkBox.Tag.ToString(), out int value))
                    {
                        if (value == -1)
                        {

                            sum = -1;
                            MessageBox.Show($"Total Sum: {sum}", "Sum of Checked Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return sum;
                        }

                        sum += value;
                    }
                }
            }

            MessageBox.Show($"Total Sum: {sum}", "Sum of Checked Values", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return sum;
        }



        //--------------------------------------------------------------------------------------

        public void reset()
        {

            txtusernameforupdate.Clear();
            listViewIUpdateUser.Clear();


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

        public string updateUserPassword()
        {

            string password = txtpassword.Text;

            return password;
        }

        public int updateUserPermissions()
        {
            return UpdateSum();
        }

        private void btnfinduserfordelete_Click(object sender, EventArgs e)
        {
            foundUser = getUser(txtusernameforupdate.Text);

            if (foundUser != null)
            {
                listViewIUpdateUser.Columns.Add("User Name", 150);
                listViewIUpdateUser.Columns.Add("Password", 100);
                listViewIUpdateUser.Columns.Add("Permissions", 100);

                ListViewItem listViewItem = new ListViewItem(getUser(txtusernameforupdate.Text)._userName);

                listViewItem.SubItems.Add(getUser(txtusernameforupdate.Text)._password);

                listViewItem.SubItems.Add(getUser(txtusernameforupdate.Text)._permissions.ToString());

                listViewIUpdateUser.Items.Add(listViewItem);

                gbUpdate.Enabled = true;
            }
            else
            {
                MessageBox.Show("User not found!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(updateUserPassword()))
            {
                MessageBox.Show("Please enter a password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foundUser._password = updateUserPassword();
            foundUser._permissions = updateUserPermissions();

            foundUser.updateUser();
            MessageBox.Show(foundUser._userName + " Updated successfully :)");
            reset();

            gbUpdate.Enabled = false;
           

        }


    }
}
