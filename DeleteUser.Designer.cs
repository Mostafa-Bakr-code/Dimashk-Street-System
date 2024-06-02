namespace Dimashk_Street
{
    partial class DeleteUser
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
            this.txtusernamefordelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewDeleteUser = new System.Windows.Forms.ListView();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Delete User Screen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnfinduserfordelete);
            this.groupBox2.Controls.Add(this.txtusernamefordelete);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(24, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 161);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find user here";
            // 
            // btnfinduserfordelete
            // 
            this.btnfinduserfordelete.Location = new System.Drawing.Point(112, 85);
            this.btnfinduserfordelete.Name = "btnfinduserfordelete";
            this.btnfinduserfordelete.Size = new System.Drawing.Size(151, 58);
            this.btnfinduserfordelete.TabIndex = 5;
            this.btnfinduserfordelete.Text = "Find user to delete";
            this.btnfinduserfordelete.UseVisualStyleBackColor = true;
            this.btnfinduserfordelete.Click += new System.EventHandler(this.btnfinditemfordelete_Click);
            // 
            // txtusernamefordelete
            // 
            this.txtusernamefordelete.Location = new System.Drawing.Point(112, 36);
            this.txtusernamefordelete.Name = "txtusernamefordelete";
            this.txtusernamefordelete.Size = new System.Drawing.Size(151, 20);
            this.txtusernamefordelete.TabIndex = 2;
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
            // listViewDeleteUser
            // 
            this.listViewDeleteUser.HideSelection = false;
            this.listViewDeleteUser.Location = new System.Drawing.Point(451, 206);
            this.listViewDeleteUser.Name = "listViewDeleteUser";
            this.listViewDeleteUser.Size = new System.Drawing.Size(392, 136);
            this.listViewDeleteUser.TabIndex = 12;
            this.listViewDeleteUser.UseCompatibleStateImageBehavior = false;
            this.listViewDeleteUser.View = System.Windows.Forms.View.Details;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.Location = new System.Drawing.Point(581, 392);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(140, 58);
            this.btnDeleteUser.TabIndex = 13;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 621);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.listViewDeleteUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnfinduserfordelete;
        private System.Windows.Forms.TextBox txtusernamefordelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewDeleteUser;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}