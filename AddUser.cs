using ClassItemLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimashk_Street
{
    public partial class AddUser : Form
    {
        public AddUser()
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
                        if(value == -1)
                        {

                            sum = -1;
                            
                            return sum;
                        }

                        sum += value;
                    }
                }
            }

         

            return sum;
        }



        //--------------------------------------------------------------------------------------
        public void reset()
        {

            txtusername.Clear();
            txtpassword.Clear();
        }

        public string getUserName()
        {
            string userName = txtusername.Text;

            return userName;
        }
        
        public string getUserPassword()
        {
            
             string password = txtpassword.Text;

             return password; 
        }

        public int getUserPermissions()
        {
            return UpdateSum();
        }

        public clsUser getUser(string userName, string password, int permissions)
        {
            clsUser user = new clsUser(userName,password,permissions);

            return user;
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
         

            if (string.IsNullOrWhiteSpace(getUserName()))
            {
                MessageBox.Show("Please enter a username.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(getUserPassword()))
            {
                MessageBox.Show("Please enter a password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsUser user = getUser(getUserName(), getUserPassword(), getUserPermissions());

            MessageBox.Show(user._userName + " added successfully :)");
       

            user.addUser();

            reset();



        }



    }
}
