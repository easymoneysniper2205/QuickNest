using System;

namespace FinalProject
{
    partial class OwnerDashBoard
    {
        private System.ComponentModel.IContainer components = null;

        // Header Controls
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblBrandName, lblBrandSubtitle;

        // Title Section
        private System.Windows.Forms.Label lblYourProperties, lblYourPropertiesDesc;

        // Statistics Cards
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel card1, card3, card4;
        private System.Windows.Forms.Label lblTotalListings, lblTotalListingsValue;
        private System.Windows.Forms.Label lblForSale, lblForSaleValue, lblForRent, lblForRentValue;

        // Active Listings Section
        private System.Windows.Forms.Label lblActiveListings;
        private System.Windows.Forms.Button btnAddNewProperty;
        private System.Windows.Forms.Panel listingsContainer;
        private System.Windows.Forms.Button backbtn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblBrandSubtitle = new System.Windows.Forms.Label();
            this.lblYourProperties = new System.Windows.Forms.Label();
            this.lblYourPropertiesDesc = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.card1 = new System.Windows.Forms.Panel();
            this.lblTotalListingsValue = new System.Windows.Forms.Label();
            this.lblTotalListings = new System.Windows.Forms.Label();
            this.card2 = new System.Windows.Forms.Panel();
            this.lblTotalViewsValue = new System.Windows.Forms.Label();
            this.lblTotalViews = new System.Windows.Forms.Label();
            this.card3 = new System.Windows.Forms.Panel();
            this.lblForSaleValue = new System.Windows.Forms.Label();
            this.lblForSale = new System.Windows.Forms.Label();
            this.card4 = new System.Windows.Forms.Panel();
            this.lblForRentValue = new System.Windows.Forms.Label();
            this.lblForRent = new System.Windows.Forms.Label();
            this.lblActiveListings = new System.Windows.Forms.Label();
            this.btnAddNewProperty = new System.Windows.Forms.Button();
            this.listingsContainer = new System.Windows.Forms.Panel();
            this.backbtn = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.card1.SuspendLayout();
            this.card2.SuspendLayout();
            this.card3.SuspendLayout();
            this.card4.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.BtnBack);
            this.headerPanel.Controls.Add(this.lblBrandName);
            this.headerPanel.Controls.Add(this.lblBrandSubtitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1100, 70);
            this.headerPanel.TabIndex = 0;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBack.Location = new System.Drawing.Point(994, 16);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(93, 40);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Logout";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblBrandName
            // 
            this.lblBrandName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBrandName.Location = new System.Drawing.Point(19, 16);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(203, 32);
            this.lblBrandName.TabIndex = 0;
            this.lblBrandName.Text = "🏠 QuickNest";
            // 
            // lblBrandSubtitle
            // 
            this.lblBrandSubtitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandSubtitle.Location = new System.Drawing.Point(448, 18);
            this.lblBrandSubtitle.Name = "lblBrandSubtitle";
            this.lblBrandSubtitle.Size = new System.Drawing.Size(227, 26);
            this.lblBrandSubtitle.TabIndex = 1;
            this.lblBrandSubtitle.Text = "Property Owner Portal";
            // 
            // lblYourProperties
            // 
            this.lblYourProperties.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblYourProperties.Location = new System.Drawing.Point(40, 90);
            this.lblYourProperties.Name = "lblYourProperties";
            this.lblYourProperties.Size = new System.Drawing.Size(500, 50);
            this.lblYourProperties.TabIndex = 1;
            this.lblYourProperties.Text = "Your Properties";
            this.lblYourProperties.Click += new System.EventHandler(this.lblYourProperties_Click);
            // 
            // lblYourPropertiesDesc
            // 
            this.lblYourPropertiesDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblYourPropertiesDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.lblYourPropertiesDesc.Location = new System.Drawing.Point(40, 145);
            this.lblYourPropertiesDesc.Name = "lblYourPropertiesDesc";
            this.lblYourPropertiesDesc.Size = new System.Drawing.Size(400, 20);
            this.lblYourPropertiesDesc.TabIndex = 2;
            this.lblYourPropertiesDesc.Text = "Manage and showcase your real estate listings";
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.Transparent;
            this.statsPanel.Controls.Add(this.card1);
            this.statsPanel.Controls.Add(this.card2);
            this.statsPanel.Controls.Add(this.card3);
            this.statsPanel.Controls.Add(this.card4);
            this.statsPanel.Location = new System.Drawing.Point(40, 180);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(1020, 150);
            this.statsPanel.TabIndex = 3;
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.White;
            this.card1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card1.Controls.Add(this.lblTotalListingsValue);
            this.card1.Controls.Add(this.lblTotalListings);
            this.card1.Location = new System.Drawing.Point(0, 0);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(230, 140);
            this.card1.TabIndex = 0;
            // 
            // lblTotalListingsValue
            // 
            this.lblTotalListingsValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblTotalListingsValue.Location = new System.Drawing.Point(15, 21);
            this.lblTotalListingsValue.Name = "lblTotalListingsValue";
            this.lblTotalListingsValue.Size = new System.Drawing.Size(200, 54);
            this.lblTotalListingsValue.TabIndex = 0;
            this.lblTotalListingsValue.Text = "0";
            // 
            // lblTotalListings
            // 
            this.lblTotalListings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalListings.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalListings.Location = new System.Drawing.Point(15, 80);
            this.lblTotalListings.Name = "lblTotalListings";
            this.lblTotalListings.Size = new System.Drawing.Size(100, 20);
            this.lblTotalListings.TabIndex = 1;
            this.lblTotalListings.Text = "Total Listings";
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.White;
            this.card2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card2.Controls.Add(this.lblTotalViewsValue);
            this.card2.Controls.Add(this.lblTotalViews);
            this.card2.Location = new System.Drawing.Point(260, 0);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(230, 140);
            this.card2.TabIndex = 1;
            // 
            // lblTotalViewsValue
            // 
            this.lblTotalViewsValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblTotalViewsValue.Location = new System.Drawing.Point(15, 21);
            this.lblTotalViewsValue.Name = "lblTotalViewsValue";
            this.lblTotalViewsValue.Size = new System.Drawing.Size(200, 54);
            this.lblTotalViewsValue.TabIndex = 0;
            this.lblTotalViewsValue.Text = "0";
            // 
            // lblTotalViews
            // 
            this.lblTotalViews.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalViews.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalViews.Location = new System.Drawing.Point(15, 80);
            this.lblTotalViews.Name = "lblTotalViews";
            this.lblTotalViews.Size = new System.Drawing.Size(100, 20);
            this.lblTotalViews.TabIndex = 1;
            this.lblTotalViews.Text = "Total Views";
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.White;
            this.card3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card3.Controls.Add(this.lblForSaleValue);
            this.card3.Controls.Add(this.lblForSale);
            this.card3.Location = new System.Drawing.Point(520, 0);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(230, 140);
            this.card3.TabIndex = 2;
            // 
            // lblForSaleValue
            // 
            this.lblForSaleValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblForSaleValue.Location = new System.Drawing.Point(15, 21);
            this.lblForSaleValue.Name = "lblForSaleValue";
            this.lblForSaleValue.Size = new System.Drawing.Size(200, 54);
            this.lblForSaleValue.TabIndex = 0;
            this.lblForSaleValue.Text = "0";
            // 
            // lblForSale
            // 
            this.lblForSale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblForSale.ForeColor = System.Drawing.Color.Gray;
            this.lblForSale.Location = new System.Drawing.Point(15, 80);
            this.lblForSale.Name = "lblForSale";
            this.lblForSale.Size = new System.Drawing.Size(100, 20);
            this.lblForSale.TabIndex = 1;
            this.lblForSale.Text = "For Sale";
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.Color.White;
            this.card4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card4.Controls.Add(this.lblForRentValue);
            this.card4.Controls.Add(this.lblForRent);
            this.card4.Location = new System.Drawing.Point(780, 0);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(230, 140);
            this.card4.TabIndex = 3;
            // 
            // lblForRentValue
            // 
            this.lblForRentValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblForRentValue.Location = new System.Drawing.Point(15, 21);
            this.lblForRentValue.Name = "lblForRentValue";
            this.lblForRentValue.Size = new System.Drawing.Size(200, 54);
            this.lblForRentValue.TabIndex = 0;
            this.lblForRentValue.Text = "0";
            // 
            // lblForRent
            // 
            this.lblForRent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblForRent.ForeColor = System.Drawing.Color.Gray;
            this.lblForRent.Location = new System.Drawing.Point(15, 80);
            this.lblForRent.Name = "lblForRent";
            this.lblForRent.Size = new System.Drawing.Size(100, 20);
            this.lblForRent.TabIndex = 1;
            this.lblForRent.Text = "For Rent";
            // 
            // lblActiveListings
            // 
            this.lblActiveListings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblActiveListings.Location = new System.Drawing.Point(40, 348);
            this.lblActiveListings.Name = "lblActiveListings";
            this.lblActiveListings.Size = new System.Drawing.Size(200, 36);
            this.lblActiveListings.TabIndex = 4;
            this.lblActiveListings.Text = "Active Listings";
            // 
            // btnAddNewProperty
            // 
            this.btnAddNewProperty.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddNewProperty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewProperty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddNewProperty.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProperty.Location = new System.Drawing.Point(850, 355);
            this.btnAddNewProperty.Name = "btnAddNewProperty";
            this.btnAddNewProperty.Size = new System.Drawing.Size(210, 40);
            this.btnAddNewProperty.TabIndex = 5;
            this.btnAddNewProperty.Text = "+ Add New Property";
            this.btnAddNewProperty.UseVisualStyleBackColor = false;
            this.btnAddNewProperty.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listingsContainer
            // 
            this.listingsContainer.AutoScroll = true;
            this.listingsContainer.BackColor = System.Drawing.Color.Transparent;
            this.listingsContainer.Location = new System.Drawing.Point(40, 410);
            this.listingsContainer.Name = "listingsContainer";
            this.listingsContainer.Size = new System.Drawing.Size(1020, 330);
            this.listingsContainer.TabIndex = 6;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(0, 0);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 7;
            // 
            // OwnerDashBoard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1100, 749);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.lblYourProperties);
            this.Controls.Add(this.lblYourPropertiesDesc);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.lblActiveListings);
            this.Controls.Add(this.btnAddNewProperty);
            this.Controls.Add(this.listingsContainer);
            this.Controls.Add(this.backbtn);
            this.Name = "OwnerDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner Dashboard";
            this.Load += new System.EventHandler(this.OwnerDashBoard_Load_1);
            this.headerPanel.ResumeLayout(false);
            this.statsPanel.ResumeLayout(false);
            this.card1.ResumeLayout(false);
            this.card2.ResumeLayout(false);
            this.card3.ResumeLayout(false);
            this.card4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
            

        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Label lblTotalViewsValue;
        private System.Windows.Forms.Label lblTotalViews;
        private System.Windows.Forms.Button BtnBack;
    }
}