namespace FinalProject
{
    partial class LoginPage
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelPropHub = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.labelPropHub);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(550, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // labelPropHub
            // 
            this.labelPropHub.AutoSize = true;
            this.labelPropHub.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelPropHub.ForeColor = System.Drawing.Color.White;
            this.labelPropHub.Location = new System.Drawing.Point(16, 12);
            this.labelPropHub.Name = "labelPropHub";
            this.labelPropHub.Size = new System.Drawing.Size(227, 45);
            this.labelPropHub.TabIndex = 0;
            this.labelPropHub.Text = "🏠 QuickNest";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(450, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.linkSignUp);
            this.panelLogin.Controls.Add(this.panelPassword);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.textBoxEmail);
            this.panelLogin.Controls.Add(this.labelEmail);
            this.panelLogin.Controls.Add(this.btnSignIn);
            this.panelLogin.Controls.Add(this.labelSubtitle);
            this.panelLogin.Controls.Add(this.labelWelcome);
            this.panelLogin.Location = new System.Drawing.Point(75, 90);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(400, 420);
            this.panelLogin.TabIndex = 1;
            // 
            // linkSignUp
            // 
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.linkSignUp.Location = new System.Drawing.Point(114, 355);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(175, 15);
            this.linkSignUp.TabIndex = 6;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Don\'t have an account? Sign Up";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked);
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.textBoxPass);
            this.panelPassword.Controls.Add(this.btnShowPassword);
            this.panelPassword.Location = new System.Drawing.Point(35, 192);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(330, 28);
            this.panelPassword.TabIndex = 5;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxPass.Location = new System.Drawing.Point(0, 0);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(285, 27);
            this.textBoxPass.TabIndex = 9;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.White;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnShowPassword.ForeColor = System.Drawing.Color.Gray;
            this.btnShowPassword.Location = new System.Drawing.Point(285, 0);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(45, 27);
            this.btnShowPassword.TabIndex = 1;
            this.btnShowPassword.Text = "👁";
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelPassword.Location = new System.Drawing.Point(35, 170);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 19);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxEmail.Location = new System.Drawing.Point(35, 122);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(330, 27);
            this.textBoxEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelEmail.Location = new System.Drawing.Point(35, 100);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(103, 19);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email Address";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(35, 280);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(330, 45);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.SigninButton_Click);
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.labelSubtitle.Location = new System.Drawing.Point(35, 60);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(225, 19);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Sign in to continue to your account";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelWelcome.Location = new System.Drawing.Point(32, 23);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(136, 37);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelHeader);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelPropHub;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.LinkLabel linkSignUp;
    }
}