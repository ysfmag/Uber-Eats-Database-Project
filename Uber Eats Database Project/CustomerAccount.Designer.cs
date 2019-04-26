﻿namespace Uber_Eats_Database_Project
{
    partial class CustomerAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAccount));
            this.saveUserNameBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editUsernameBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savePasswordBtn = new System.Windows.Forms.Button();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.creditCard = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // saveUserNameBtn
            // 
            this.saveUserNameBtn.BackColor = System.Drawing.Color.Black;
            this.saveUserNameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveUserNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveUserNameBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUserNameBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveUserNameBtn.Location = new System.Drawing.Point(111, 212);
            this.saveUserNameBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveUserNameBtn.Name = "saveUserNameBtn";
            this.saveUserNameBtn.Size = new System.Drawing.Size(213, 57);
            this.saveUserNameBtn.TabIndex = 51;
            this.saveUserNameBtn.Text = "Save Username";
            this.saveUserNameBtn.UseVisualStyleBackColor = false;
            this.saveUserNameBtn.Click += new System.EventHandler(this.saveUserNameBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(506, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 465);
            this.panel2.TabIndex = 50;
            // 
            // editUsernameBtn
            // 
            this.editUsernameBtn.BackColor = System.Drawing.Color.Black;
            this.editUsernameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editUsernameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUsernameBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUsernameBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editUsernameBtn.Location = new System.Drawing.Point(38, 153);
            this.editUsernameBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editUsernameBtn.Name = "editUsernameBtn";
            this.editUsernameBtn.Size = new System.Drawing.Size(367, 47);
            this.editUsernameBtn.TabIndex = 49;
            this.editUsernameBtn.Text = "Change Username";
            this.editUsernameBtn.UseVisualStyleBackColor = false;
            this.editUsernameBtn.Click += new System.EventHandler(this.editUsernameBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label9.Location = new System.Drawing.Point(545, 264);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 32);
            this.label9.TabIndex = 48;
            this.label9.Text = "Credit No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label8.Location = new System.Drawing.Point(545, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 32);
            this.label8.TabIndex = 47;
            this.label8.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label7.Location = new System.Drawing.Point(545, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 32);
            this.label7.TabIndex = 46;
            this.label7.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label6.Location = new System.Drawing.Point(545, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 32);
            this.label6.TabIndex = 45;
            this.label6.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label3.Location = new System.Drawing.Point(32, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 32);
            this.label3.TabIndex = 42;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // savePasswordBtn
            // 
            this.savePasswordBtn.BackColor = System.Drawing.Color.Black;
            this.savePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePasswordBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePasswordBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savePasswordBtn.Location = new System.Drawing.Point(111, 499);
            this.savePasswordBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.savePasswordBtn.Name = "savePasswordBtn";
            this.savePasswordBtn.Size = new System.Drawing.Size(213, 57);
            this.savePasswordBtn.TabIndex = 41;
            this.savePasswordBtn.Text = "Save Password";
            this.savePasswordBtn.UseVisualStyleBackColor = false;
            this.savePasswordBtn.Click += new System.EventHandler(this.savePasswordBtn_Click);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.confirmPassword.Location = new System.Drawing.Point(38, 451);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(367, 34);
            this.confirmPassword.TabIndex = 40;
            this.confirmPassword.Text = "Confirm Password";
            this.confirmPassword.Enter += new System.EventHandler(this.confirmPassword_Enter);
            this.confirmPassword.Leave += new System.EventHandler(this.confirmPassword_Leave);
            // 
            // newPassword
            // 
            this.newPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.newPassword.Location = new System.Drawing.Point(38, 407);
            this.newPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(367, 34);
            this.newPassword.TabIndex = 39;
            this.newPassword.Text = "New Password";
            this.newPassword.Enter += new System.EventHandler(this.newPassword_Enter);
            this.newPassword.Leave += new System.EventHandler(this.newPassword_Leave);
            // 
            // oldPassword
            // 
            this.oldPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.oldPassword.Location = new System.Drawing.Point(38, 363);
            this.oldPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(367, 34);
            this.oldPassword.TabIndex = 38;
            this.oldPassword.Text = "Password";
            this.oldPassword.Enter += new System.EventHandler(this.oldPassword_Enter);
            this.oldPassword.Leave += new System.EventHandler(this.oldPassword_Leave);
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.Black;
            this.changePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePasswordBtn.Location = new System.Drawing.Point(38, 294);
            this.changePasswordBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(245, 30);
            this.changePasswordBtn.TabIndex = 37;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Black;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBtn.Location = new System.Drawing.Point(898, 341);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 57);
            this.saveBtn.TabIndex = 36;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.DarkGray;
            this.userName.Location = new System.Drawing.Point(38, 100);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(367, 34);
            this.userName.TabIndex = 20;
            this.userName.Text = "Username";
            // 
            // fName
            // 
            this.fName.Enabled = false;
            this.fName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.ForeColor = System.Drawing.Color.DarkGray;
            this.fName.Location = new System.Drawing.Point(700, 112);
            this.fName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(367, 34);
            this.fName.TabIndex = 22;
            this.fName.Text = "First Name";
            // 
            // lName
            // 
            this.lName.Enabled = false;
            this.lName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.ForeColor = System.Drawing.Color.DarkGray;
            this.lName.Location = new System.Drawing.Point(700, 161);
            this.lName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(367, 34);
            this.lName.TabIndex = 23;
            this.lName.Text = "Last Name";
            // 
            // location
            // 
            this.location.Enabled = false;
            this.location.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.ForeColor = System.Drawing.Color.DarkGray;
            this.location.Location = new System.Drawing.Point(700, 210);
            this.location.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(367, 34);
            this.location.TabIndex = 25;
            this.location.Text = "Location";
            // 
            // creditCard
            // 
            this.creditCard.Enabled = false;
            this.creditCard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCard.ForeColor = System.Drawing.Color.DarkGray;
            this.creditCard.Location = new System.Drawing.Point(700, 264);
            this.creditCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(367, 34);
            this.creditCard.TabIndex = 26;
            this.creditCard.Text = "Credit Card";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Controls.Add(this.exit);
            this.header.Controls.Add(this.label2);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1113, 45);
            this.header.TabIndex = 35;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageActive = null;
            this.exit.Location = new System.Drawing.Point(1062, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(39, 42);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 17;
            this.exit.TabStop = false;
            this.exit.Zoom = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 39);
            this.label2.TabIndex = 38;
            this.label2.Text = "Account Info";
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Black;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editBtn.Location = new System.Drawing.Point(712, 341);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(112, 57);
            this.editBtn.TabIndex = 29;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label4.Location = new System.Drawing.Point(550, 453);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 32);
            this.label4.TabIndex = 52;
            this.label4.Text = "Voucher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(720, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "label5";
            // 
            // CustomerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveUserNameBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editUsernameBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.savePasswordBtn);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.header);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.creditCard);
            this.Controls.Add(this.location);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerAccount";
            this.Text = "CustomerAccount";
            this.Load += new System.EventHandler(this.CustomerAccount_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveUserNameBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button editUsernameBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button savePasswordBtn;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox creditCard;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}