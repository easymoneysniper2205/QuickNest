namespace FinalProject
{
    partial class SignUp
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
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.panelConfirmPassword = new System.Windows.Forms.Panel();
            this.textBoxConfirmPasswordField = new System.Windows.Forms.TextBox();
            this.btnShowConfirmPassword = new System.Windows.Forms.Button();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.radioAgentOwner = new System.Windows.Forms.RadioButton();
            this.radioBuyerRenter = new System.Windows.Forms.RadioButton();
            this.labelUserType = new System.Windows.Forms.Label();
            this.labelConfirmHint = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelPasswordHint = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmailHint = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNameHint = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.panelSignUp.SuspendLayout();
            this.panelConfirmPassword.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(600, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // labelPropHub
            // 
            this.labelPropHub.AutoSize = true;
            this.labelPropHub.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelPropHub.ForeColor = System.Drawing.Color.White;
            this.labelPropHub.Location = new System.Drawing.Point(14, 12);
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
            this.btnBack.Location = new System.Drawing.Point(500, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panelSignUp
            // 
            this.panelSignUp.BackColor = System.Drawing.Color.White;
            this.panelSignUp.Controls.Add(this.panelConfirmPassword);
            this.panelSignUp.Controls.Add(this.panelPassword);
            this.panelSignUp.Controls.Add(this.btnCreateAccount);
            this.panelSignUp.Controls.Add(this.radioAgentOwner);
            this.panelSignUp.Controls.Add(this.radioBuyerRenter);
            this.panelSignUp.Controls.Add(this.labelUserType);
            this.panelSignUp.Controls.Add(this.labelConfirmHint);
            this.panelSignUp.Controls.Add(this.labelConfirmPassword);
            this.panelSignUp.Controls.Add(this.labelPasswordHint);
            this.panelSignUp.Controls.Add(this.labelPassword);
            this.panelSignUp.Controls.Add(this.labelEmailHint);
            this.panelSignUp.Controls.Add(this.textBoxEmail);
            this.panelSignUp.Controls.Add(this.labelEmail);
            this.panelSignUp.Controls.Add(this.labelNameHint);
            this.panelSignUp.Controls.Add(this.textBoxFullName);
            this.panelSignUp.Controls.Add(this.labelFullName);
            this.panelSignUp.Controls.Add(this.labelSubtitle);
            this.panelSignUp.Controls.Add(this.labelCreateAccount);
            this.panelSignUp.Location = new System.Drawing.Point(100, 90);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(400, 580);
            this.panelSignUp.TabIndex = 1;
            // 
            // panelConfirmPassword
            // 
            this.panelConfirmPassword.Controls.Add(this.textBoxConfirmPasswordField);
            this.panelConfirmPassword.Controls.Add(this.btnShowConfirmPassword);
            this.panelConfirmPassword.Location = new System.Drawing.Point(35, 375);
            this.panelConfirmPassword.Name = "panelConfirmPassword";
            this.panelConfirmPassword.Size = new System.Drawing.Size(330, 30);
            this.panelConfirmPassword.TabIndex = 19;
            // 
            // textBoxConfirmPasswordField
            // 
            this.textBoxConfirmPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmPasswordField.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxConfirmPasswordField.Location = new System.Drawing.Point(0, 0);
            this.textBoxConfirmPasswordField.Name = "textBoxConfirmPasswordField";
            this.textBoxConfirmPasswordField.Size = new System.Drawing.Size(285, 27);
            this.textBoxConfirmPasswordField.TabIndex = 9;
            this.textBoxConfirmPasswordField.UseSystemPasswordChar = true;
            // 
            // btnShowConfirmPassword
            // 
            this.btnShowConfirmPassword.BackColor = System.Drawing.Color.White;
            this.btnShowConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnShowConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.btnShowConfirmPassword.Location = new System.Drawing.Point(285, 0);
            this.btnShowConfirmPassword.Name = "btnShowConfirmPassword";
            this.btnShowConfirmPassword.Size = new System.Drawing.Size(45, 27);
            this.btnShowConfirmPassword.TabIndex = 1;
            this.btnShowConfirmPassword.Text = "👁";
            this.btnShowConfirmPassword.UseVisualStyleBackColor = false;
            this.btnShowConfirmPassword.Click += new System.EventHandler(this.BtnShowConfirmPassword_Click);
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Controls.Add(this.btnShowPassword);
            this.panelPassword.Location = new System.Drawing.Point(35, 272);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(330, 30);
            this.panelPassword.TabIndex = 18;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxPassword.Location = new System.Drawing.Point(0, 0);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(285, 27);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.UseSystemPasswordChar = true;
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
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(35, 510);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(330, 45);
            this.btnCreateAccount.TabIndex = 17;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // radioAgentOwner
            // 
            this.radioAgentOwner.AutoSize = true;
            this.radioAgentOwner.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioAgentOwner.Location = new System.Drawing.Point(199, 466);
            this.radioAgentOwner.Name = "radioAgentOwner";
            this.radioAgentOwner.Size = new System.Drawing.Size(110, 23);
            this.radioAgentOwner.TabIndex = 16;
            this.radioAgentOwner.TabStop = true;
            this.radioAgentOwner.Text = "Agent/Owner";
            this.radioAgentOwner.UseVisualStyleBackColor = true;
            // 
            // radioBuyerRenter
            // 
            this.radioBuyerRenter.AutoSize = true;
            this.radioBuyerRenter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioBuyerRenter.Location = new System.Drawing.Point(74, 466);
            this.radioBuyerRenter.Name = "radioBuyerRenter";
            this.radioBuyerRenter.Size = new System.Drawing.Size(107, 23);
            this.radioBuyerRenter.TabIndex = 15;
            this.radioBuyerRenter.TabStop = true;
            this.radioBuyerRenter.Text = "Buyer/Renter";
            this.radioBuyerRenter.UseVisualStyleBackColor = true;
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelUserType.Location = new System.Drawing.Point(35, 435);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(62, 19);
            this.labelUserType.TabIndex = 14;
            this.labelUserType.Text = "I am a...";
            // 
            // labelConfirmHint
            // 
            this.labelConfirmHint.AutoSize = true;
            this.labelConfirmHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelConfirmHint.ForeColor = System.Drawing.Color.Gray;
            this.labelConfirmHint.Location = new System.Drawing.Point(40, 405);
            this.labelConfirmHint.Name = "labelConfirmHint";
            this.labelConfirmHint.Size = new System.Drawing.Size(130, 13);
            this.labelConfirmHint.TabIndex = 13;
            this.labelConfirmHint.Text = "Re-enter your password";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelConfirmPassword.Location = new System.Drawing.Point(35, 355);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(131, 19);
            this.labelConfirmPassword.TabIndex = 11;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // labelPasswordHint
            // 
            this.labelPasswordHint.AutoSize = true;
            this.labelPasswordHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelPasswordHint.ForeColor = System.Drawing.Color.Gray;
            this.labelPasswordHint.Location = new System.Drawing.Point(40, 325);
            this.labelPasswordHint.Name = "labelPasswordHint";
            this.labelPasswordHint.Size = new System.Drawing.Size(109, 13);
            this.labelPasswordHint.TabIndex = 10;
            this.labelPasswordHint.Text = "At least 6 characters";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelPassword.Location = new System.Drawing.Point(35, 250);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 19);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // labelEmailHint
            // 
            this.labelEmailHint.AutoSize = true;
            this.labelEmailHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEmailHint.ForeColor = System.Drawing.Color.Gray;
            this.labelEmailHint.Location = new System.Drawing.Point(40, 227);
            this.labelEmailHint.Name = "labelEmailHint";
            this.labelEmailHint.Size = new System.Drawing.Size(92, 13);
            this.labelEmailHint.TabIndex = 7;
            this.labelEmailHint.Text = "your@email.com";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxEmail.Location = new System.Drawing.Point(35, 197);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(330, 27);
            this.textBoxEmail.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelEmail.Location = new System.Drawing.Point(35, 175);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(103, 19);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email Address";
            // 
            // labelNameHint
            // 
            this.labelNameHint.AutoSize = true;
            this.labelNameHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelNameHint.ForeColor = System.Drawing.Color.Gray;
            this.labelNameHint.Location = new System.Drawing.Point(40, 152);
            this.labelNameHint.Name = "labelNameHint";
            this.labelNameHint.Size = new System.Drawing.Size(56, 13);
            this.labelNameHint.TabIndex = 4;
            this.labelNameHint.Text = "John Doe";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxFullName.Location = new System.Drawing.Point(35, 122);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(330, 27);
            this.textBoxFullName.TabIndex = 3;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelFullName.Location = new System.Drawing.Point(35, 100);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(76, 19);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Full Name";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.labelSubtitle.Location = new System.Drawing.Point(35, 60);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(227, 19);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Join us to find your dream property";
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelCreateAccount.Location = new System.Drawing.Point(30, 20);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(213, 37);
            this.labelCreateAccount.TabIndex = 0;
            this.labelCreateAccount.Text = "Create Account";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(35, 347);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(330, 27);
            this.textBoxConfirmPassword.TabIndex = 12;
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.panelSignUp);
            this.Controls.Add(this.panelHeader);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            this.panelConfirmPassword.ResumeLayout(false);
            this.panelConfirmPassword.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelPropHub;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelSignUp;
        private System.Windows.Forms.Label labelCreateAccount;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelNameHint;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelEmailHint;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPasswordHint;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmHint;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.RadioButton radioAgentOwner;
        private System.Windows.Forms.RadioButton radioBuyerRenter;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Panel panelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPasswordField;
        private System.Windows.Forms.Button btnShowConfirmPassword;
    }
}