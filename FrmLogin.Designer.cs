namespace OrderTracker
{
    partial class FrmLogin
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
            this.LblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.RedPanel = new System.Windows.Forms.Panel();
            this.LblProgramTitle = new System.Windows.Forms.Label();
            this.ForgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.RedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(34, 117);
            this.LblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(75, 13);
            this.LblUsername.TabIndex = 0;
            this.LblUsername.Text = "Korisničko ime";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(37, 132);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(241, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(37, 174);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(241, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(34, 159);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(44, 13);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Lozinka";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(12, 232);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(296, 46);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // RedPanel
            // 
            this.RedPanel.BackColor = System.Drawing.Color.Red;
            this.RedPanel.Controls.Add(this.LblProgramTitle);
            this.RedPanel.Location = new System.Drawing.Point(12, 22);
            this.RedPanel.Name = "RedPanel";
            this.RedPanel.Size = new System.Drawing.Size(296, 78);
            this.RedPanel.TabIndex = 5;
            // 
            // LblProgramTitle
            // 
            this.LblProgramTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblProgramTitle.AutoSize = true;
            this.LblProgramTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblProgramTitle.ForeColor = System.Drawing.Color.White;
            this.LblProgramTitle.Location = new System.Drawing.Point(94, 27);
            this.LblProgramTitle.Name = "LblProgramTitle";
            this.LblProgramTitle.Size = new System.Drawing.Size(110, 24);
            this.LblProgramTitle.TabIndex = 6;
            this.LblProgramTitle.Text = "FOI Nabava";
            // 
            // ForgotPasswordLink
            // 
            this.ForgotPasswordLink.AutoSize = true;
            this.ForgotPasswordLink.Location = new System.Drawing.Point(107, 198);
            this.ForgotPasswordLink.Name = "ForgotPasswordLink";
            this.ForgotPasswordLink.Size = new System.Drawing.Size(183, 13);
            this.ForgotPasswordLink.TabIndex = 7;
            this.ForgotPasswordLink.TabStop = true;
            this.ForgotPasswordLink.Tag = "https://foi.hr";
            this.ForgotPasswordLink.Text = "Zaboravili ste lozinku? (kliknite ovdje)";
            this.ForgotPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPasswordLink_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 289);
            this.Controls.Add(this.ForgotPasswordLink);
            this.Controls.Add(this.RedPanel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.LblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.RedPanel.ResumeLayout(false);
            this.RedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel RedPanel;
        private System.Windows.Forms.Label LblProgramTitle;
        private System.Windows.Forms.LinkLabel ForgotPasswordLink;
    }
}