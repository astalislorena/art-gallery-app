namespace ArtGallery_MVP.View.Staff
{
    partial class AdminForm
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
            this.listView = new System.Windows.Forms.ListView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnSaveUsers = new System.Windows.Forms.Button();
            this.btnSrachByName = new System.Windows.Forms.Button();
            this.btnSearchByEmail = new System.Windows.Forms.Button();
            this.btnGetALlStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(303, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(485, 399);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(25, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(175, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(25, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(175, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(25, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(25, 205);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(175, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(25, 249);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(25, 278);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUser.TabIndex = 12;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(25, 307);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 13;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnSaveUsers
            // 
            this.btnSaveUsers.Location = new System.Drawing.Point(713, 417);
            this.btnSaveUsers.Name = "btnSaveUsers";
            this.btnSaveUsers.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUsers.TabIndex = 14;
            this.btnSaveUsers.Text = "Save";
            this.btnSaveUsers.UseVisualStyleBackColor = true;
            // 
            // btnSrachByName
            // 
            this.btnSrachByName.Location = new System.Drawing.Point(206, 40);
            this.btnSrachByName.Name = "btnSrachByName";
            this.btnSrachByName.Size = new System.Drawing.Size(26, 23);
            this.btnSrachByName.TabIndex = 15;
            this.btnSrachByName.Text = "🔍";
            this.btnSrachByName.UseVisualStyleBackColor = true;
            this.btnSrachByName.Click += new System.EventHandler(this.btnSrachByName_Click);
            // 
            // btnSearchByEmail
            // 
            this.btnSearchByEmail.Location = new System.Drawing.Point(206, 151);
            this.btnSearchByEmail.Name = "btnSearchByEmail";
            this.btnSearchByEmail.Size = new System.Drawing.Size(26, 23);
            this.btnSearchByEmail.TabIndex = 16;
            this.btnSearchByEmail.Text = "🔍";
            this.btnSearchByEmail.UseVisualStyleBackColor = true;
            this.btnSearchByEmail.Click += new System.EventHandler(this.btnSearchByEmail_Click);
            // 
            // btnGetALlStaff
            // 
            this.btnGetALlStaff.Location = new System.Drawing.Point(632, 417);
            this.btnGetALlStaff.Name = "btnGetALlStaff";
            this.btnGetALlStaff.Size = new System.Drawing.Size(75, 23);
            this.btnGetALlStaff.TabIndex = 17;
            this.btnGetALlStaff.Text = "See all";
            this.btnGetALlStaff.UseVisualStyleBackColor = true;
            this.btnGetALlStaff.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetALlStaff);
            this.Controls.Add(this.btnSearchByEmail);
            this.Controls.Add(this.btnSrachByName);
            this.Controls.Add(this.btnSaveUsers);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.listView);
            this.Name = "AdminForm";
            this.Text = "Staff management";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnSaveUsers;
        private System.Windows.Forms.Button btnSrachByName;
        private System.Windows.Forms.Button btnSearchByEmail;
        private System.Windows.Forms.Button btnGetALlStaff;
    }
}