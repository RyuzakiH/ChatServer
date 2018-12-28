namespace Chat.WinForms
{
    partial class FormChat
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxLogin = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstConnectedUsers = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtConnectUsername = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtChatMessagesView = new System.Windows.Forms.RichTextBox();
            this.txtChatMessage = new System.Windows.Forms.RichTextBox();
            this.btnChatMessageSend = new System.Windows.Forms.Button();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.gboxLogin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(61, 68);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(85, 16);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(100, 20);
            this.txtLoginUsername.TabIndex = 0;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(85, 42);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(100, 20);
            this.txtLoginPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // gboxLogin
            // 
            this.gboxLogin.Controls.Add(this.label1);
            this.gboxLogin.Controls.Add(this.label2);
            this.gboxLogin.Controls.Add(this.btnLogin);
            this.gboxLogin.Controls.Add(this.txtLoginUsername);
            this.gboxLogin.Controls.Add(this.txtLoginPassword);
            this.gboxLogin.Location = new System.Drawing.Point(343, 12);
            this.gboxLogin.Name = "gboxLogin";
            this.gboxLogin.Size = new System.Drawing.Size(200, 98);
            this.gboxLogin.TabIndex = 5;
            this.gboxLogin.TabStop = false;
            this.gboxLogin.Text = "Login";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstConnectedUsers);
            this.groupBox2.Location = new System.Drawing.Point(343, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 116);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connected Users";
            // 
            // lstConnectedUsers
            // 
            this.lstConnectedUsers.FormattingEnabled = true;
            this.lstConnectedUsers.Location = new System.Drawing.Point(6, 22);
            this.lstConnectedUsers.Name = "lstConnectedUsers";
            this.lstConnectedUsers.Size = new System.Drawing.Size(188, 82);
            this.lstConnectedUsers.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Controls.Add(this.txtConnectUsername);
            this.groupBox3.Location = new System.Drawing.Point(343, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 76);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connect";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(61, 43);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // txtConnectUsername
            // 
            this.txtConnectUsername.Location = new System.Drawing.Point(85, 17);
            this.txtConnectUsername.Name = "txtConnectUsername";
            this.txtConnectUsername.Size = new System.Drawing.Size(100, 20);
            this.txtConnectUsername.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtChatMessagesView);
            this.groupBox4.Controls.Add(this.txtChatMessage);
            this.groupBox4.Controls.Add(this.btnChatMessageSend);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 302);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chat";
            // 
            // txtChatMessagesView
            // 
            this.txtChatMessagesView.Enabled = false;
            this.txtChatMessagesView.Location = new System.Drawing.Point(6, 22);
            this.txtChatMessagesView.Name = "txtChatMessagesView";
            this.txtChatMessagesView.ReadOnly = true;
            this.txtChatMessagesView.Size = new System.Drawing.Size(313, 226);
            this.txtChatMessagesView.TabIndex = 7;
            this.txtChatMessagesView.Text = "";
            // 
            // txtChatMessage
            // 
            this.txtChatMessage.Location = new System.Drawing.Point(6, 256);
            this.txtChatMessage.Name = "txtChatMessage";
            this.txtChatMessage.Size = new System.Drawing.Size(232, 40);
            this.txtChatMessage.TabIndex = 5;
            this.txtChatMessage.Text = "";
            // 
            // btnChatMessageSend
            // 
            this.btnChatMessageSend.Enabled = false;
            this.btnChatMessageSend.Location = new System.Drawing.Point(243, 254);
            this.btnChatMessageSend.Name = "btnChatMessageSend";
            this.btnChatMessageSend.Size = new System.Drawing.Size(75, 23);
            this.btnChatMessageSend.TabIndex = 6;
            this.btnChatMessageSend.Text = "Send";
            this.btnChatMessageSend.UseVisualStyleBackColor = true;
            this.btnChatMessageSend.Click += new System.EventHandler(this.BtnChatMessageSend_Click);
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblLoggedIn.Location = new System.Drawing.Point(360, 20);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(106, 19);
            this.lblLoggedIn.TabIndex = 5;
            this.lblLoggedIn.Text = "Logged In as ";
            this.lblLoggedIn.Visible = false;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 326);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gboxLogin);
            this.Controls.Add(this.lblLoggedIn);
            this.Name = "FormChat";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChat_FormClosing);
            this.gboxLogin.ResumeLayout(false);
            this.gboxLogin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstConnectedUsers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtConnectUsername;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox txtChatMessagesView;
        private System.Windows.Forms.RichTextBox txtChatMessage;
        private System.Windows.Forms.Button btnChatMessageSend;
        private System.Windows.Forms.Label lblLoggedIn;
    }
}

