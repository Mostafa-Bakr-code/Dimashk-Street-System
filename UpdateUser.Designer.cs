namespace Dimashk_Street
{
    partial class UpdateUser
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnfinduserfordelete = new System.Windows.Forms.Button();
            this.txtusernameforupdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewIUpdateUser = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkfullaccess = new System.Windows.Forms.CheckBox();
            this.chkorderhistory = new System.Windows.Forms.CheckBox();
            this.chkadmins = new System.Windows.Forms.CheckBox();
            this.chkloginhistory = new System.Windows.Forms.CheckBox();
            this.chklist = new System.Windows.Forms.CheckBox();
            this.chkdelete = new System.Windows.Forms.CheckBox();
            this.chkupdate = new System.Windows.Forms.CheckBox();
            this.chkadd = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Update User Screen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnfinduserfordelete);
            this.groupBox2.Controls.Add(this.txtusernameforupdate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(35, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 161);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find user here";
            // 
            // btnfinduserfordelete
            // 
            this.btnfinduserfordelete.Location = new System.Drawing.Point(112, 85);
            this.btnfinduserfordelete.Name = "btnfinduserfordelete";
            this.btnfinduserfordelete.Size = new System.Drawing.Size(151, 58);
            this.btnfinduserfordelete.TabIndex = 5;
            this.btnfinduserfordelete.Text = "Find user to update";
            this.btnfinduserfordelete.UseVisualStyleBackColor = true;
            this.btnfinduserfordelete.Click += new System.EventHandler(this.btnfinduserfordelete_Click);
            // 
            // txtusernameforupdate
            // 
            this.txtusernameforupdate.Location = new System.Drawing.Point(112, 36);
            this.txtusernameforupdate.Name = "txtusernameforupdate";
            this.txtusernameforupdate.Size = new System.Drawing.Size(151, 20);
            this.txtusernameforupdate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "User Name";
            // 
            // listViewIUpdateUser
            // 
            this.listViewIUpdateUser.HideSelection = false;
            this.listViewIUpdateUser.Location = new System.Drawing.Point(475, 82);
            this.listViewIUpdateUser.Name = "listViewIUpdateUser";
            this.listViewIUpdateUser.Size = new System.Drawing.Size(392, 136);
            this.listViewIUpdateUser.TabIndex = 13;
            this.listViewIUpdateUser.UseCompatibleStateImageBehavior = false;
            this.listViewIUpdateUser.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkfullaccess);
            this.groupBox1.Controls.Add(this.chkorderhistory);
            this.groupBox1.Controls.Add(this.chkadmins);
            this.groupBox1.Controls.Add(this.chkloginhistory);
            this.groupBox1.Controls.Add(this.chklist);
            this.groupBox1.Controls.Add(this.chkdelete);
            this.groupBox1.Controls.Add(this.chkupdate);
            this.groupBox1.Controls.Add(this.chkadd);
            this.groupBox1.Location = new System.Drawing.Point(24, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 201);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // chkfullaccess
            // 
            this.chkfullaccess.AutoSize = true;
            this.chkfullaccess.Location = new System.Drawing.Point(175, 149);
            this.chkfullaccess.Name = "chkfullaccess";
            this.chkfullaccess.Size = new System.Drawing.Size(80, 17);
            this.chkfullaccess.TabIndex = 19;
            this.chkfullaccess.Tag = "-1";
            this.chkfullaccess.Text = "Full Access";
            this.chkfullaccess.UseVisualStyleBackColor = true;
            // 
            // chkorderhistory
            // 
            this.chkorderhistory.AutoSize = true;
            this.chkorderhistory.Location = new System.Drawing.Point(175, 112);
            this.chkorderhistory.Name = "chkorderhistory";
            this.chkorderhistory.Size = new System.Drawing.Size(92, 17);
            this.chkorderhistory.TabIndex = 18;
            this.chkorderhistory.Tag = "64";
            this.chkorderhistory.Text = "Orders History";
            this.chkorderhistory.UseVisualStyleBackColor = true;
            // 
            // chkadmins
            // 
            this.chkadmins.AutoSize = true;
            this.chkadmins.Location = new System.Drawing.Point(175, 75);
            this.chkadmins.Name = "chkadmins";
            this.chkadmins.Size = new System.Drawing.Size(60, 17);
            this.chkadmins.TabIndex = 17;
            this.chkadmins.Tag = "32";
            this.chkadmins.Text = "Admins";
            this.chkadmins.UseVisualStyleBackColor = true;
            // 
            // chkloginhistory
            // 
            this.chkloginhistory.AutoSize = true;
            this.chkloginhistory.Location = new System.Drawing.Point(175, 38);
            this.chkloginhistory.Name = "chkloginhistory";
            this.chkloginhistory.Size = new System.Drawing.Size(87, 17);
            this.chkloginhistory.TabIndex = 16;
            this.chkloginhistory.Tag = "16";
            this.chkloginhistory.Text = "Login History";
            this.chkloginhistory.UseVisualStyleBackColor = true;
            // 
            // chklist
            // 
            this.chklist.AutoSize = true;
            this.chklist.Location = new System.Drawing.Point(22, 149);
            this.chklist.Name = "chklist";
            this.chklist.Size = new System.Drawing.Size(70, 17);
            this.chklist.TabIndex = 15;
            this.chklist.Tag = "8";
            this.chklist.Text = "List Items";
            this.chklist.UseVisualStyleBackColor = true;
            // 
            // chkdelete
            // 
            this.chkdelete.AutoSize = true;
            this.chkdelete.Location = new System.Drawing.Point(22, 112);
            this.chkdelete.Name = "chkdelete";
            this.chkdelete.Size = new System.Drawing.Size(85, 17);
            this.chkdelete.TabIndex = 14;
            this.chkdelete.Tag = "4";
            this.chkdelete.Text = "Delete Items";
            this.chkdelete.UseVisualStyleBackColor = true;
            // 
            // chkupdate
            // 
            this.chkupdate.AutoSize = true;
            this.chkupdate.Location = new System.Drawing.Point(22, 75);
            this.chkupdate.Name = "chkupdate";
            this.chkupdate.Size = new System.Drawing.Size(89, 17);
            this.chkupdate.TabIndex = 13;
            this.chkupdate.Tag = "2";
            this.chkupdate.Text = "Update Items";
            this.chkupdate.UseVisualStyleBackColor = true;
            // 
            // chkadd
            // 
            this.chkadd.AutoSize = true;
            this.chkadd.Location = new System.Drawing.Point(22, 38);
            this.chkadd.Name = "chkadd";
            this.chkadd.Size = new System.Drawing.Size(73, 17);
            this.chkadd.TabIndex = 12;
            this.chkadd.Tag = "1";
            this.chkadd.Text = "Add Items";
            this.chkadd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(89, 35);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(128, 20);
            this.txtpassword.TabIndex = 16;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(456, 147);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(151, 58);
            this.btnUpdateUser.TabIndex = 6;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.btnUpdateUser);
            this.gbUpdate.Controls.Add(this.txtpassword);
            this.gbUpdate.Controls.Add(this.label2);
            this.gbUpdate.Controls.Add(this.groupBox1);
            this.gbUpdate.Enabled = false;
            this.gbUpdate.Location = new System.Drawing.Point(34, 314);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(637, 285);
            this.gbUpdate.TabIndex = 17;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update here";
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 599);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.listViewIUpdateUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnfinduserfordelete;
        private System.Windows.Forms.TextBox txtusernameforupdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewIUpdateUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkfullaccess;
        private System.Windows.Forms.CheckBox chkorderhistory;
        private System.Windows.Forms.CheckBox chkadmins;
        private System.Windows.Forms.CheckBox chkloginhistory;
        private System.Windows.Forms.CheckBox chklist;
        private System.Windows.Forms.CheckBox chkdelete;
        private System.Windows.Forms.CheckBox chkupdate;
        private System.Windows.Forms.CheckBox chkadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.GroupBox gbUpdate;
    }
}