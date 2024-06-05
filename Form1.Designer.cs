namespace Dimashk_Street
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabcontrolmaintab = new System.Windows.Forms.TabControl();
            this.tabadditems = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnadditem = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabupdateitems = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnfinditem = new System.Windows.Forms.Button();
            this.txtfinditemname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewupdateitem = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.gbupdateitem = new System.Windows.Forms.GroupBox();
            this.btnupdateitem = new System.Windows.Forms.Button();
            this.txtupdateprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tablistitems = new System.Windows.Forms.TabPage();
            this.btnsortbyfileorder = new System.Windows.Forms.Button();
            this.btnsortbyname = new System.Windows.Forms.Button();
            this.btnsorthighprice = new System.Windows.Forms.Button();
            this.btnsortlowprice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabdeleteitems = new System.Windows.Forms.TabPage();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.listViewDeleteitem = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnfinditemfordelete = new System.Windows.Forms.Button();
            this.txtnamefordelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.taborderhistory = new System.Windows.Forms.TabPage();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btnTotal = new System.Windows.Forms.Button();
            this.listViewOrderHistory = new System.Windows.Forms.ListView();
            this.tabcontrolneworders = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOrderSubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtOrderItems = new System.Windows.Forms.TextBox();
            this.txtOrderTime = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNewOrdersortfile = new System.Windows.Forms.Button();
            this.btnNewOrdersortname = new System.Windows.Forms.Button();
            this.btnNewOrdersorthigh = new System.Windows.Forms.Button();
            this.btnNewOrdersortlow = new System.Windows.Forms.Button();
            this.listViewNewOrders = new System.Windows.Forms.ListView();
            this.tabloginhistory = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.listViewLogs = new System.Windows.Forms.ListView();
            this.tabadmins = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tablogout = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbshowTotal = new System.Windows.Forms.Label();
            this.tabcontrolmaintab.SuspendLayout();
            this.tabadditems.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabupdateitems.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbupdateitem.SuspendLayout();
            this.tablistitems.SuspendLayout();
            this.tabdeleteitems.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.taborderhistory.SuspendLayout();
            this.tabcontrolneworders.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabloginhistory.SuspendLayout();
            this.tabadmins.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrolmaintab
            // 
            this.tabcontrolmaintab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabcontrolmaintab.Controls.Add(this.tabadditems);
            this.tabcontrolmaintab.Controls.Add(this.tabupdateitems);
            this.tabcontrolmaintab.Controls.Add(this.tablistitems);
            this.tabcontrolmaintab.Controls.Add(this.tabdeleteitems);
            this.tabcontrolmaintab.Controls.Add(this.taborderhistory);
            this.tabcontrolmaintab.Controls.Add(this.tabcontrolneworders);
            this.tabcontrolmaintab.Controls.Add(this.tabloginhistory);
            this.tabcontrolmaintab.Controls.Add(this.tabadmins);
            this.tabcontrolmaintab.Controls.Add(this.tablogout);
            this.tabcontrolmaintab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrolmaintab.Location = new System.Drawing.Point(-4, -3);
            this.tabcontrolmaintab.Name = "tabcontrolmaintab";
            this.tabcontrolmaintab.SelectedIndex = 0;
            this.tabcontrolmaintab.Size = new System.Drawing.Size(1118, 650);
            this.tabcontrolmaintab.TabIndex = 0;
            this.tabcontrolmaintab.Tag = "";
            this.tabcontrolmaintab.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabadditems
            // 
            this.tabadditems.Controls.Add(this.groupBox1);
            this.tabadditems.Controls.Add(this.label4);
            this.tabadditems.Location = new System.Drawing.Point(4, 28);
            this.tabadditems.Name = "tabadditems";
            this.tabadditems.Padding = new System.Windows.Forms.Padding(3);
            this.tabadditems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabadditems.Size = new System.Drawing.Size(1110, 618);
            this.tabadditems.TabIndex = 0;
            this.tabadditems.Tag = "1";
            this.tabadditems.Text = "Add Items";
            this.tabadditems.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnadditem);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(103, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item here";
            // 
            // btnadditem
            // 
            this.btnadditem.Location = new System.Drawing.Point(112, 143);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(140, 58);
            this.btnadditem.TabIndex = 5;
            this.btnadditem.Text = "Add Item";
            this.btnadditem.UseVisualStyleBackColor = true;
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(112, 83);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(151, 22);
            this.txtprice.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(112, 36);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(151, 22);
            this.txtname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add Items";
            // 
            // tabupdateitems
            // 
            this.tabupdateitems.Controls.Add(this.groupBox3);
            this.tabupdateitems.Controls.Add(this.listViewupdateitem);
            this.tabupdateitems.Controls.Add(this.label7);
            this.tabupdateitems.Controls.Add(this.gbupdateitem);
            this.tabupdateitems.Location = new System.Drawing.Point(4, 28);
            this.tabupdateitems.Name = "tabupdateitems";
            this.tabupdateitems.Padding = new System.Windows.Forms.Padding(3);
            this.tabupdateitems.Size = new System.Drawing.Size(1110, 618);
            this.tabupdateitems.TabIndex = 1;
            this.tabupdateitems.Tag = "2";
            this.tabupdateitems.Text = "Update Items";
            this.tabupdateitems.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnfinditem);
            this.groupBox3.Controls.Add(this.txtfinditemname);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(111, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 161);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Find Item here";
            // 
            // btnfinditem
            // 
            this.btnfinditem.Location = new System.Drawing.Point(112, 82);
            this.btnfinditem.Name = "btnfinditem";
            this.btnfinditem.Size = new System.Drawing.Size(140, 58);
            this.btnfinditem.TabIndex = 5;
            this.btnfinditem.Text = "Find Item to update";
            this.btnfinditem.UseVisualStyleBackColor = true;
            this.btnfinditem.Click += new System.EventHandler(this.btnfinditem_Click);
            // 
            // txtfinditemname
            // 
            this.txtfinditemname.Location = new System.Drawing.Point(112, 36);
            this.txtfinditemname.Name = "txtfinditemname";
            this.txtfinditemname.Size = new System.Drawing.Size(151, 22);
            this.txtfinditemname.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name";
            // 
            // listViewupdateitem
            // 
            this.listViewupdateitem.HideSelection = false;
            this.listViewupdateitem.Location = new System.Drawing.Point(552, 147);
            this.listViewupdateitem.Name = "listViewupdateitem";
            this.listViewupdateitem.Size = new System.Drawing.Size(310, 244);
            this.listViewupdateitem.TabIndex = 9;
            this.listViewupdateitem.UseCompatibleStateImageBehavior = false;
            this.listViewupdateitem.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(432, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Update Items";
            // 
            // gbupdateitem
            // 
            this.gbupdateitem.Controls.Add(this.btnupdateitem);
            this.gbupdateitem.Controls.Add(this.txtupdateprice);
            this.gbupdateitem.Controls.Add(this.label5);
            this.gbupdateitem.Enabled = false;
            this.gbupdateitem.Location = new System.Drawing.Point(111, 310);
            this.gbupdateitem.Name = "gbupdateitem";
            this.gbupdateitem.Size = new System.Drawing.Size(356, 242);
            this.gbupdateitem.TabIndex = 7;
            this.gbupdateitem.TabStop = false;
            this.gbupdateitem.Text = "Update Item here";
            // 
            // btnupdateitem
            // 
            this.btnupdateitem.Location = new System.Drawing.Point(112, 96);
            this.btnupdateitem.Name = "btnupdateitem";
            this.btnupdateitem.Size = new System.Drawing.Size(140, 58);
            this.btnupdateitem.TabIndex = 5;
            this.btnupdateitem.Text = "Update Item";
            this.btnupdateitem.UseVisualStyleBackColor = true;
            this.btnupdateitem.Click += new System.EventHandler(this.btnupdateitem_Click);
            // 
            // txtupdateprice
            // 
            this.txtupdateprice.Location = new System.Drawing.Point(112, 51);
            this.txtupdateprice.Name = "txtupdateprice";
            this.txtupdateprice.Size = new System.Drawing.Size(151, 22);
            this.txtupdateprice.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Price";
            // 
            // tablistitems
            // 
            this.tablistitems.Controls.Add(this.btnsortbyfileorder);
            this.tablistitems.Controls.Add(this.btnsortbyname);
            this.tablistitems.Controls.Add(this.btnsorthighprice);
            this.tablistitems.Controls.Add(this.btnsortlowprice);
            this.tablistitems.Controls.Add(this.label1);
            this.tablistitems.Controls.Add(this.listView1);
            this.tablistitems.Location = new System.Drawing.Point(4, 28);
            this.tablistitems.Name = "tablistitems";
            this.tablistitems.Padding = new System.Windows.Forms.Padding(3);
            this.tablistitems.Size = new System.Drawing.Size(1110, 618);
            this.tablistitems.TabIndex = 2;
            this.tablistitems.Tag = "8";
            this.tablistitems.Text = "List Items";
            this.tablistitems.UseVisualStyleBackColor = true;
            // 
            // btnsortbyfileorder
            // 
            this.btnsortbyfileorder.Location = new System.Drawing.Point(653, 423);
            this.btnsortbyfileorder.Name = "btnsortbyfileorder";
            this.btnsortbyfileorder.Size = new System.Drawing.Size(114, 51);
            this.btnsortbyfileorder.TabIndex = 5;
            this.btnsortbyfileorder.Text = "Sort by File Order";
            this.btnsortbyfileorder.UseVisualStyleBackColor = true;
            this.btnsortbyfileorder.Click += new System.EventHandler(this.btnsortbyfileorder_Click);
            // 
            // btnsortbyname
            // 
            this.btnsortbyname.Location = new System.Drawing.Point(509, 423);
            this.btnsortbyname.Name = "btnsortbyname";
            this.btnsortbyname.Size = new System.Drawing.Size(114, 51);
            this.btnsortbyname.TabIndex = 4;
            this.btnsortbyname.Text = "Sort by Name";
            this.btnsortbyname.UseVisualStyleBackColor = true;
            this.btnsortbyname.Click += new System.EventHandler(this.btnsortbyname_Click);
            // 
            // btnsorthighprice
            // 
            this.btnsorthighprice.Location = new System.Drawing.Point(365, 423);
            this.btnsorthighprice.Name = "btnsorthighprice";
            this.btnsorthighprice.Size = new System.Drawing.Size(114, 51);
            this.btnsorthighprice.TabIndex = 3;
            this.btnsorthighprice.Text = "Sort by Price Highest";
            this.btnsorthighprice.UseVisualStyleBackColor = true;
            this.btnsorthighprice.Click += new System.EventHandler(this.btnsorthighprice_Click);
            // 
            // btnsortlowprice
            // 
            this.btnsortlowprice.Location = new System.Drawing.Point(226, 423);
            this.btnsortlowprice.Name = "btnsortlowprice";
            this.btnsortlowprice.Size = new System.Drawing.Size(114, 51);
            this.btnsortlowprice.TabIndex = 2;
            this.btnsortlowprice.Text = "Sort by Price lowest";
            this.btnsortlowprice.UseVisualStyleBackColor = true;
            this.btnsortlowprice.Click += new System.EventHandler(this.btnsortlowprice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listing All Items";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(164, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(753, 306);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tabdeleteitems
            // 
            this.tabdeleteitems.Controls.Add(this.btnDeleteItem);
            this.tabdeleteitems.Controls.Add(this.listViewDeleteitem);
            this.tabdeleteitems.Controls.Add(this.label8);
            this.tabdeleteitems.Controls.Add(this.groupBox2);
            this.tabdeleteitems.Location = new System.Drawing.Point(4, 28);
            this.tabdeleteitems.Name = "tabdeleteitems";
            this.tabdeleteitems.Padding = new System.Windows.Forms.Padding(3);
            this.tabdeleteitems.Size = new System.Drawing.Size(1110, 618);
            this.tabdeleteitems.TabIndex = 3;
            this.tabdeleteitems.Tag = "4";
            this.tabdeleteitems.Text = "Delete Items";
            this.tabdeleteitems.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Enabled = false;
            this.btnDeleteItem.Location = new System.Drawing.Point(603, 400);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(140, 58);
            this.btnDeleteItem.TabIndex = 6;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // listViewDeleteitem
            // 
            this.listViewDeleteitem.HideSelection = false;
            this.listViewDeleteitem.Location = new System.Drawing.Point(508, 140);
            this.listViewDeleteitem.Name = "listViewDeleteitem";
            this.listViewDeleteitem.Size = new System.Drawing.Size(310, 244);
            this.listViewDeleteitem.TabIndex = 11;
            this.listViewDeleteitem.UseCompatibleStateImageBehavior = false;
            this.listViewDeleteitem.View = System.Windows.Forms.View.Details;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(421, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "Delete Items";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnfinditemfordelete);
            this.groupBox2.Controls.Add(this.txtnamefordelete);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(100, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 161);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find Item here";
            // 
            // btnfinditemfordelete
            // 
            this.btnfinditemfordelete.Location = new System.Drawing.Point(112, 82);
            this.btnfinditemfordelete.Name = "btnfinditemfordelete";
            this.btnfinditemfordelete.Size = new System.Drawing.Size(140, 58);
            this.btnfinditemfordelete.TabIndex = 5;
            this.btnfinditemfordelete.Text = "Find Item to delete";
            this.btnfinditemfordelete.UseVisualStyleBackColor = true;
            this.btnfinditemfordelete.Click += new System.EventHandler(this.btnfinditemfordelete_Click);
            // 
            // txtnamefordelete
            // 
            this.txtnamefordelete.Location = new System.Drawing.Point(112, 36);
            this.txtnamefordelete.Name = "txtnamefordelete";
            this.txtnamefordelete.Size = new System.Drawing.Size(151, 22);
            this.txtnamefordelete.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // taborderhistory
            // 
            this.taborderhistory.Controls.Add(this.lbshowTotal);
            this.taborderhistory.Controls.Add(this.label18);
            this.taborderhistory.Controls.Add(this.label17);
            this.taborderhistory.Controls.Add(this.dateTimePickerTo);
            this.taborderhistory.Controls.Add(this.dateTimePickerFrom);
            this.taborderhistory.Controls.Add(this.btnTotal);
            this.taborderhistory.Controls.Add(this.listViewOrderHistory);
            this.taborderhistory.Location = new System.Drawing.Point(4, 28);
            this.taborderhistory.Name = "taborderhistory";
            this.taborderhistory.Padding = new System.Windows.Forms.Padding(3);
            this.taborderhistory.Size = new System.Drawing.Size(1110, 618);
            this.taborderhistory.TabIndex = 4;
            this.taborderhistory.Tag = "64";
            this.taborderhistory.Text = "Orders History";
            this.taborderhistory.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(121, 412);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(279, 22);
            this.dateTimePickerTo.TabIndex = 7;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(121, 384);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(279, 22);
            this.dateTimePickerFrom.TabIndex = 6;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(160, 452);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(148, 48);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // listViewOrderHistory
            // 
            this.listViewOrderHistory.HideSelection = false;
            this.listViewOrderHistory.Location = new System.Drawing.Point(121, 67);
            this.listViewOrderHistory.Name = "listViewOrderHistory";
            this.listViewOrderHistory.Size = new System.Drawing.Size(816, 255);
            this.listViewOrderHistory.TabIndex = 0;
            this.listViewOrderHistory.UseCompatibleStateImageBehavior = false;
            this.listViewOrderHistory.View = System.Windows.Forms.View.Details;
            // 
            // tabcontrolneworders
            // 
            this.tabcontrolneworders.Controls.Add(this.btnReset);
            this.tabcontrolneworders.Controls.Add(this.btnOrderSubmit);
            this.tabcontrolneworders.Controls.Add(this.panel1);
            this.tabcontrolneworders.Controls.Add(this.btnNewOrdersortfile);
            this.tabcontrolneworders.Controls.Add(this.btnNewOrdersortname);
            this.tabcontrolneworders.Controls.Add(this.btnNewOrdersorthigh);
            this.tabcontrolneworders.Controls.Add(this.btnNewOrdersortlow);
            this.tabcontrolneworders.Controls.Add(this.listViewNewOrders);
            this.tabcontrolneworders.Location = new System.Drawing.Point(4, 28);
            this.tabcontrolneworders.Name = "tabcontrolneworders";
            this.tabcontrolneworders.Padding = new System.Windows.Forms.Padding(3);
            this.tabcontrolneworders.Size = new System.Drawing.Size(1110, 618);
            this.tabcontrolneworders.TabIndex = 5;
            this.tabcontrolneworders.Text = "New Order";
            this.tabcontrolneworders.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(601, 417);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 42);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOrderSubmit
            // 
            this.btnOrderSubmit.Enabled = false;
            this.btnOrderSubmit.Location = new System.Drawing.Point(722, 405);
            this.btnOrderSubmit.Name = "btnOrderSubmit";
            this.btnOrderSubmit.Size = new System.Drawing.Size(216, 66);
            this.btnOrderSubmit.TabIndex = 8;
            this.btnOrderSubmit.Text = "Order";
            this.btnOrderSubmit.UseVisualStyleBackColor = true;
            this.btnOrderSubmit.Click += new System.EventHandler(this.btnOrderSubmit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtOrderTotal);
            this.panel1.Controls.Add(this.txtOrderItems);
            this.panel1.Controls.Add(this.txtOrderTime);
            this.panel1.Controls.Add(this.txtOrderDate);
            this.panel1.Controls.Add(this.txtOrderNumber);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(601, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 354);
            this.panel1.TabIndex = 7;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(111, 323);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(148, 22);
            this.txtOrderTotal.TabIndex = 17;
            // 
            // txtOrderItems
            // 
            this.txtOrderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderItems.Location = new System.Drawing.Point(75, 176);
            this.txtOrderItems.Multiline = true;
            this.txtOrderItems.Name = "txtOrderItems";
            this.txtOrderItems.Size = new System.Drawing.Size(248, 130);
            this.txtOrderItems.TabIndex = 16;
            // 
            // txtOrderTime
            // 
            this.txtOrderTime.Location = new System.Drawing.Point(111, 128);
            this.txtOrderTime.Name = "txtOrderTime";
            this.txtOrderTime.Size = new System.Drawing.Size(148, 22);
            this.txtOrderTime.TabIndex = 15;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(111, 85);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(148, 22);
            this.txtOrderDate.TabIndex = 14;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(111, 45);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(148, 22);
            this.txtOrderNumber.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Order # :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Items:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Date:";
            // 
            // btnNewOrdersortfile
            // 
            this.btnNewOrdersortfile.Location = new System.Drawing.Point(21, 205);
            this.btnNewOrdersortfile.Name = "btnNewOrdersortfile";
            this.btnNewOrdersortfile.Size = new System.Drawing.Size(103, 22);
            this.btnNewOrdersortfile.TabIndex = 6;
            this.btnNewOrdersortfile.Text = "File Order";
            this.btnNewOrdersortfile.UseVisualStyleBackColor = true;
            // 
            // btnNewOrdersortname
            // 
            this.btnNewOrdersortname.Location = new System.Drawing.Point(21, 166);
            this.btnNewOrdersortname.Name = "btnNewOrdersortname";
            this.btnNewOrdersortname.Size = new System.Drawing.Size(103, 24);
            this.btnNewOrdersortname.TabIndex = 5;
            this.btnNewOrdersortname.Text = "A-Z";
            this.btnNewOrdersortname.UseVisualStyleBackColor = true;
            // 
            // btnNewOrdersorthigh
            // 
            this.btnNewOrdersorthigh.Location = new System.Drawing.Point(21, 126);
            this.btnNewOrdersorthigh.Name = "btnNewOrdersorthigh";
            this.btnNewOrdersorthigh.Size = new System.Drawing.Size(103, 25);
            this.btnNewOrdersorthigh.TabIndex = 4;
            this.btnNewOrdersorthigh.Text = " Price Highest";
            this.btnNewOrdersorthigh.UseVisualStyleBackColor = true;
            // 
            // btnNewOrdersortlow
            // 
            this.btnNewOrdersortlow.Location = new System.Drawing.Point(21, 86);
            this.btnNewOrdersortlow.Name = "btnNewOrdersortlow";
            this.btnNewOrdersortlow.Size = new System.Drawing.Size(103, 24);
            this.btnNewOrdersortlow.TabIndex = 3;
            this.btnNewOrdersortlow.Text = " Price lowest";
            this.btnNewOrdersortlow.UseVisualStyleBackColor = true;
            // 
            // listViewNewOrders
            // 
            this.listViewNewOrders.CheckBoxes = true;
            this.listViewNewOrders.HideSelection = false;
            this.listViewNewOrders.Location = new System.Drawing.Point(181, 79);
            this.listViewNewOrders.Name = "listViewNewOrders";
            this.listViewNewOrders.Size = new System.Drawing.Size(253, 392);
            this.listViewNewOrders.TabIndex = 1;
            this.listViewNewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewNewOrders.View = System.Windows.Forms.View.Details;
            this.listViewNewOrders.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewNewOrders_ItemCheck);
            // 
            // tabloginhistory
            // 
            this.tabloginhistory.Controls.Add(this.label16);
            this.tabloginhistory.Controls.Add(this.listViewLogs);
            this.tabloginhistory.Location = new System.Drawing.Point(4, 28);
            this.tabloginhistory.Name = "tabloginhistory";
            this.tabloginhistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabloginhistory.Size = new System.Drawing.Size(1110, 618);
            this.tabloginhistory.TabIndex = 6;
            this.tabloginhistory.Tag = "16";
            this.tabloginhistory.Text = "LogIns History";
            this.tabloginhistory.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(438, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "LogIn History";
            // 
            // listViewLogs
            // 
            this.listViewLogs.HideSelection = false;
            this.listViewLogs.Location = new System.Drawing.Point(117, 132);
            this.listViewLogs.Name = "listViewLogs";
            this.listViewLogs.Size = new System.Drawing.Size(803, 365);
            this.listViewLogs.TabIndex = 1;
            this.listViewLogs.UseCompatibleStateImageBehavior = false;
            this.listViewLogs.View = System.Windows.Forms.View.Details;
            // 
            // tabadmins
            // 
            this.tabadmins.Controls.Add(this.label15);
            this.tabadmins.Controls.Add(this.btnListUsers);
            this.tabadmins.Controls.Add(this.btnUpdateUser);
            this.tabadmins.Controls.Add(this.btnDeleteUser);
            this.tabadmins.Controls.Add(this.btnAddUser);
            this.tabadmins.Location = new System.Drawing.Point(4, 28);
            this.tabadmins.Name = "tabadmins";
            this.tabadmins.Padding = new System.Windows.Forms.Padding(3);
            this.tabadmins.Size = new System.Drawing.Size(1110, 618);
            this.tabadmins.TabIndex = 7;
            this.tabadmins.Tag = "32";
            this.tabadmins.Text = "Admins";
            this.tabadmins.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(413, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(210, 31);
            this.label15.TabIndex = 9;
            this.label15.Text = " Admin Manager";
            // 
            // btnListUsers
            // 
            this.btnListUsers.Location = new System.Drawing.Point(134, 452);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(149, 70);
            this.btnListUsers.TabIndex = 3;
            this.btnListUsers.Text = "List Users";
            this.btnListUsers.UseVisualStyleBackColor = true;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(134, 251);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(149, 70);
            this.btnUpdateUser.TabIndex = 2;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(134, 352);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(149, 70);
            this.btnDeleteUser.TabIndex = 1;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(134, 147);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(149, 70);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tablogout
            // 
            this.tablogout.Location = new System.Drawing.Point(4, 28);
            this.tablogout.Name = "tablogout";
            this.tablogout.Padding = new System.Windows.Forms.Padding(3);
            this.tablogout.Size = new System.Drawing.Size(1110, 618);
            this.tablogout.TabIndex = 8;
            this.tablogout.Text = "Log Out";
            this.tablogout.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 384);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 16);
            this.label17.TabIndex = 8;
            this.label17.Text = "Date From";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(50, 412);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 16);
            this.label18.TabIndex = 9;
            this.label18.Text = "Date To";
            // 
            // lbshowTotal
            // 
            this.lbshowTotal.AutoSize = true;
            this.lbshowTotal.Location = new System.Drawing.Point(540, 390);
            this.lbshowTotal.Name = "lbshowTotal";
            this.lbshowTotal.Size = new System.Drawing.Size(108, 16);
            this.lbshowTotal.TabIndex = 10;
            this.lbshowTotal.Text = "Total will be here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 639);
            this.Controls.Add(this.tabcontrolmaintab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabcontrolmaintab.ResumeLayout(false);
            this.tabadditems.ResumeLayout(false);
            this.tabadditems.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabupdateitems.ResumeLayout(false);
            this.tabupdateitems.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbupdateitem.ResumeLayout(false);
            this.gbupdateitem.PerformLayout();
            this.tablistitems.ResumeLayout(false);
            this.tablistitems.PerformLayout();
            this.tabdeleteitems.ResumeLayout(false);
            this.tabdeleteitems.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.taborderhistory.ResumeLayout(false);
            this.taborderhistory.PerformLayout();
            this.tabcontrolneworders.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabloginhistory.ResumeLayout(false);
            this.tabloginhistory.PerformLayout();
            this.tabadmins.ResumeLayout(false);
            this.tabadmins.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrolmaintab;
        private System.Windows.Forms.TabPage tabadditems;
        private System.Windows.Forms.TabPage tabupdateitems;
        private System.Windows.Forms.TabPage tablistitems;
        private System.Windows.Forms.TabPage tabdeleteitems;
        private System.Windows.Forms.TabPage taborderhistory;
        private System.Windows.Forms.TabPage tabcontrolneworders;
        private System.Windows.Forms.TabPage tabloginhistory;
        private System.Windows.Forms.TabPage tabadmins;
        private System.Windows.Forms.TabPage tablogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnsortlowprice;
        private System.Windows.Forms.Button btnsorthighprice;
        private System.Windows.Forms.Button btnsortbyname;
        private System.Windows.Forms.Button btnsortbyfileorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnadditem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewupdateitem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbupdateitem;
        private System.Windows.Forms.Button btnupdateitem;
        private System.Windows.Forms.TextBox txtupdateprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnfinditem;
        private System.Windows.Forms.TextBox txtfinditemname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnfinditemfordelete;
        private System.Windows.Forms.TextBox txtnamefordelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewDeleteitem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.ListView listViewNewOrders;
        private System.Windows.Forms.Button btnNewOrdersortfile;
        private System.Windows.Forms.Button btnNewOrdersortname;
        private System.Windows.Forms.Button btnNewOrdersorthigh;
        private System.Windows.Forms.Button btnNewOrdersortlow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtOrderItems;
        private System.Windows.Forms.TextBox txtOrderTime;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOrderSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView listViewOrderHistory;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListView listViewLogs;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label lbshowTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}

