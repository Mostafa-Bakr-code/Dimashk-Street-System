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
    public partial class ListUsers : Form
    {
        public ListUsers()
        {
            InitializeComponent();
        }

        private void showListViewUsers(ListView myListView)
        {
            myListView.Columns.Add("User Name", 150);
            myListView.Columns.Add("Password", 100);
            myListView.Columns.Add("Permissions", 100);


            List<clsUser> usersRecordList = clsUser.LoadDataFromFileToUserList();


            foreach (clsUser user in usersRecordList)
            {
                ListViewItem listViewItem = new ListViewItem(user._userName);
                listViewItem.SubItems.Add(user._password);
                listViewItem.SubItems.Add(user._permissions.ToString());
                
                myListView.Items.Add(listViewItem);

            }
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            showListViewUsers(listViewUsers);
        }
    }
}
