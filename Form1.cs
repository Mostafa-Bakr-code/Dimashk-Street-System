using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassItemLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Dimashk_Street
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //--------------------------------------------------------------------------------------------------------
        // Changing Tabs
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlneworder.SelectedTab != null && tabControlneworder.SelectedTab.Name == "tablistitems")
            {
                showListViewTab(listView1);
            }

            if (tabControlneworder.SelectedTab != null && tabControlneworder.SelectedTab.Name == "tabcontrolneworders")
            {
                showListViewTab(listViewNewOrders);

            }

            if (tabControlneworder.SelectedTab != null && tabControlneworder.SelectedTab.Name == "taborderhistory")
            {
                showListViewHistory(listViewOrderHistory);
            }
        }



        //--------------------------------------------------------------------------------------------------------
        // List View Methods
        private void showListViewTab(ListView myListView)
        {
            myListView.Columns.Add("Name", 150); 
            myListView.Columns.Add("Price", 100); 

       
            List<clsItem> itemRecordList = clsItem.LoadDataFromFileToObjList();

       
            foreach (clsItem item in itemRecordList)
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.Tag = item;
                myListView.Items.Add(listViewItem);
                
            }
        }

        private void SortListViewByName(ListView myListView)
        {
            // Get the ListView items
            ListViewItem[] items = new ListViewItem[myListView.Items.Count];
            myListView.Items.CopyTo(items, 0);

            // Sort the items by name
            Array.Sort(items, (item1, item2) =>
            {
                return string.Compare(item1.Text, item2.Text);
            });

            // Clear existing items in the ListView
            myListView.Items.Clear();

            // Add the sorted items back to the ListView
            myListView.Items.AddRange(items);
        }

        private void SortListViewByFileOrder(ListView myListView)
        {
            // Clear existing items in the ListView
            myListView.Items.Clear();

            // Load data from file to object list
            List<clsItem> itemRecordList = clsItem.LoadDataFromFileToObjList();

            // Populate the ListView control with items in the original order
            foreach (clsItem item in itemRecordList)
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Price.ToString());
                myListView.Items.Add(listViewItem);
            }
        }

        private void SortListViewByPrice(bool lowToHigh, ListView myListView)
        {
            // Get the ListView items
            ListViewItem[] items = new ListViewItem[myListView.Items.Count];
            myListView.Items.CopyTo(items, 0);

            // Sort the items by price
            Array.Sort(items, (item1, item2) =>
            {
                float price1 = float.Parse(item1.SubItems[1].Text);
                float price2 = float.Parse(item2.SubItems[1].Text);
                if (lowToHigh)
                    return price1.CompareTo(price2);
                else
                    return price2.CompareTo(price1);
            });

            // Clear existing items in the ListView
            myListView.Items.Clear();

            // Add the sorted items back to the ListView
            myListView.Items.AddRange(items);
        }


        //--------------------------------------------------------------------------------------------------------
        // List Items Tab
        private void btnsortlowprice_Click(object sender, EventArgs e)
        {
            SortListViewByPrice(lowToHigh: true, listView1);
        }

        private void btnsorthighprice_Click(object sender, EventArgs e)
        {
            SortListViewByPrice(lowToHigh: false, listView1);
        }

        private void btnsortbyname_Click(object sender, EventArgs e)
        {
            SortListViewByName(listView1);
        }

        private void btnsortbyfileorder_Click(object sender, EventArgs e)
        {
            SortListViewByFileOrder(listView1);
        }



        //--------------------------------------------------------------------------------------------------------
        // Add Tab

        private void btnadditem_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            float price;
            try
            {
                price = Convert.ToSingle(txtprice.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for the price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }

            // If conversion succeeds, continue with the rest of the method
            MessageBox.Show(name);
            MessageBox.Show(price.ToString());

            DialogResult result = MessageBox.Show("Are you sure you want to add this new item?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                clsItem newItem = new clsItem(name, price);
                newItem.addItemToList();
                MessageBox.Show("Item added successfully :)");
                txtname.Clear();
                txtprice.Clear();
            }


        }



        //--------------------------------------------------------------------------------------------------------
        // Update Tab


        private clsItem foundItem = null;

        private void btnupdateitem_Click(object sender, EventArgs e)
        {
           
            float price;
            try
            {
                price = Convert.ToSingle(txtupdateprice.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for the price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }

            foundItem.Price = price;

            DialogResult result = MessageBox.Show("Are you sure you want to update item?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                MessageBox.Show(foundItem.Price.ToString());
                foundItem.updateItem();
                MessageBox.Show("Item updated successfully :)");
                txtupdateprice.Clear();
                listViewupdateitem.Items.Clear();
                txtfinditemname.Clear();

            }

        }

        private clsItem getItem(string name)
        {
           
            foundItem = clsItem.findItem(name);

            if (foundItem != null)
            {
  
                return foundItem;

            }

            else
            {
                
                return null;
            }
        }

        private void btnfinditem_Click(object sender, EventArgs e)
        {
            if(getItem(txtfinditemname.Text) != null)
            {
                listViewupdateitem.Columns.Add("Name", 150);
                listViewupdateitem.Columns.Add("Price", 100);

                ListViewItem listViewItem = new ListViewItem(getItem(txtfinditemname.Text).Name);
                listViewItem.SubItems.Add(getItem(txtfinditemname.Text).Price.ToString());
                listViewupdateitem.Items.Add(listViewItem);

                gbupdateitem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Item not found!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }

        //--------------------------------------------------------------------------------------------------------
        // Delete Tab

        private void btnfinditemfordelete_Click(object sender, EventArgs e)
        {
            if (getItem(txtnamefordelete.Text) != null)
            {
                listViewDeleteitem.Columns.Add("Name", 150);
                listViewDeleteitem.Columns.Add("Price", 100);

                ListViewItem listViewItem = new ListViewItem(getItem(txtnamefordelete.Text).Name);
                listViewItem.SubItems.Add(getItem(txtnamefordelete.Text).Price.ToString());
                listViewDeleteitem.Items.Add(listViewItem);

                btnDeleteItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Item not found!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + foundItem.Name + "?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                
                foundItem.deleteItem();
                MessageBox.Show("Item deleted successfully :)");
                txtnamefordelete.Clear();
                listViewDeleteitem.Items.Clear();
                btnDeleteItem.Enabled = false;

            }

            txtnamefordelete.Clear();
            listViewDeleteitem.Items.Clear();
            foundItem = null;
            btnDeleteItem.Enabled = false;
        }


        //--------------------------------------------------------------------------------------------------------
        // Orders History Tab

       public void showListViewHistory(ListView myListView)
        {
            myListView.Items.Clear();

            myListView.Columns.Add("Date", 100);
            myListView.Columns.Add("Time", 100);
            myListView.Columns.Add("Total", 100);
            myListView.Columns.Add("Order Number", 100);
            myListView.Columns.Add("Items Details", 300);



            List<clsOrder> ordersRecordList = clsOrder.LoadDataFromFileToOrderList();



            foreach (clsOrder order in ordersRecordList)
            {
                ListViewItem listViewOrders = new ListViewItem(order.Date);
                listViewOrders.SubItems.Add(order.Time);
                listViewOrders.SubItems.Add(order.Total.ToString());
                listViewOrders.SubItems.Add(order.orderNumber.ToString());

                string AllOrderItems = "";
                
                for(int i = 0; i < order.orderItems.Count; i++)
                {
                     AllOrderItems += order.orderItems[i].Name + order.orderItems[i].Price.ToString() + "/";
                    
                }

                listViewOrders.SubItems.Add(AllOrderItems);
                myListView.Items.Add(listViewOrders);

            }
        }


        //--------------------------------------------------------------------------------------------------------
        // New Order Tab

        void reset()
        {
            btnOrderSubmit.Enabled = false;
            txtOrderDate.Clear();
            txtOrderTime.Clear();
            txtOrderTotal.Clear();
            txtOrderItems.Clear();
            txtOrderNumber.Clear();
        }

        private void listViewNewOrders_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ListViewItem item = listViewNewOrders.Items[e.Index];

            clsItem Item = (clsItem)item.Tag;

            StringBuilder orderItems = new StringBuilder(txtOrderItems.Text);

            if (orderItems.Length > 0 && orderItems[orderItems.Length - 1] != '-')
            {
                orderItems.Append('-');
            }

            orderItems.Append(clsItem.ConvertItemObjectToLine(Item, "/"));

            txtOrderItems.Text = orderItems.ToString();

           
            if (txtOrderItems.Text.EndsWith("-"))
            {
                txtOrderItems.Text = txtOrderItems.Text.TrimEnd('-');
            }


            txtOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtOrderTime.Text = DateTime.Now.ToString("HH:mm");

            List<clsItem> items = clsOrder.ConvertArrItemsToclsItems(clsOrder.ConvertLineToItemsArr(txtOrderItems.Text));

            float total = clsOrder.getTotal(items);

            txtOrderTotal.Text = total.ToString();

            txtOrderNumber.Text = clsOrder.getOrderNumber().ToString();

            btnOrderSubmit.Enabled = true;
        }

        private void btnOrderSubmit_Click(object sender, EventArgs e)
        {

            string date = txtOrderDate.Text;
            string time = txtOrderTime.Text;
           
            int orderNumber = clsOrder.getOrderNumber();
            List<clsItem> items = clsOrder.ConvertArrItemsToclsItems(clsOrder.ConvertLineToItemsArr(txtOrderItems.Text));

            float total = clsOrder.getTotal(items);

            clsOrder newOrder = new clsOrder(date, time, total, orderNumber, items);
            MessageBox.Show(clsOrder.ConvertOrderObjectToLine(newOrder));
            newOrder.addOrder();
            reset();


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }




    }
}
