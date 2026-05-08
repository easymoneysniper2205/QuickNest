namespace FinalProject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SignupButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.RentButton = new System.Windows.Forms.Button();
            this.BrowseAllBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SignupButton);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Location = new System.Drawing.Point(-6, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 58);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "🏠 QuickNest";
            // 
            // SignupButton
            // 
            this.SignupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.SignupButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignupButton.Location = new System.Drawing.Point(708, 15);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(75, 23);
            this.SignupButton.TabIndex = 4;
            this.SignupButton.Text = "SIGN UP";
            this.SignupButton.UseVisualStyleBackColor = false;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginButton.Location = new System.Drawing.Point(618, 15);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Find Your Dream Property";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(441, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Discover the best properties for sale or rent in the Philippines";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.LightBlue;
            this.BuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyButton.Location = new System.Drawing.Point(180, 212);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(204, 122);
            this.BuyButton.TabIndex = 0;
            this.BuyButton.Text = "BUY";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // RentButton
            // 
            this.RentButton.BackColor = System.Drawing.Color.CadetBlue;
            this.RentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentButton.Location = new System.Drawing.Point(417, 212);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(201, 122);
            this.RentButton.TabIndex = 1;
            this.RentButton.Text = "RENT";
            this.RentButton.UseVisualStyleBackColor = false;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // BrowseAllBtn
            // 
            this.BrowseAllBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.BrowseAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseAllBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BrowseAllBtn.Location = new System.Drawing.Point(180, 361);
            this.BrowseAllBtn.Name = "BrowseAllBtn";
            this.BrowseAllBtn.Size = new System.Drawing.Size(438, 39);
            this.BrowseAllBtn.TabIndex = 2;
            this.BrowseAllBtn.Text = "Browse All Properties";
            this.BrowseAllBtn.UseVisualStyleBackColor = false;
            this.BrowseAllBtn.Click += new System.EventHandler(this.BrowseAllBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "What are you looking for?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BrowseAllBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button RentButton;
        private System.Windows.Forms.Button BrowseAllBtn;
        private System.Windows.Forms.Label label3;
    }
}

