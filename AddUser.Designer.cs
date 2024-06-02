namespace Dimashk_Street
{
    partial class AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkfullaccess = new System.Windows.Forms.CheckBox();
            this.chkorderhistory = new System.Windows.Forms.CheckBox();
            this.chkadmins = new System.Windows.Forms.CheckBox();
            this.chkloginhistory = new System.Windows.Forms.CheckBox();
            this.chklist = new System.Windows.Forms.CheckBox();
            this.chkdelete = new System.Windows.Forms.CheckBox();
            this.chkupdate = new System.Windows.Forms.CheckBox();
            this.chkadd = new System.Windows.Forms.CheckBox();
            this.btnadduser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Add User Screen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(220, 226);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(128, 20);
            this.txtusername.TabIndex = 9;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(220, 262);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(128, 20);
            this.txtpassword.TabIndex = 10;
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
            this.groupBox1.Location = new System.Drawing.Point(113, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 201);
            this.groupBox1.TabIndex = 11;
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
            // btnadduser
            // 
            this.btnadduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.Location = new System.Drawing.Point(628, 422);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(190, 85);
            this.btnadduser.TabIndex = 12;
            this.btnadduser.Text = "Add User";
            this.btnadduser.UseVisualStyleBackColor = true;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 631);
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkadd;
        private System.Windows.Forms.CheckBox chkorderhistory;
        private System.Windows.Forms.CheckBox chkadmins;
        private System.Windows.Forms.CheckBox chkloginhistory;
        private System.Windows.Forms.CheckBox chklist;
        private System.Windows.Forms.CheckBox chkdelete;
        private System.Windows.Forms.CheckBox chkupdate;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.CheckBox chkfullaccess;
    }
}