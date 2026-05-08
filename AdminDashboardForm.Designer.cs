namespace FinalProject
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblPortal;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Panel cardPublic;
        private System.Windows.Forms.Panel cardHidden;
        private System.Windows.Forms.Panel cardRent;
        private System.Windows.Forms.Panel cardSale;

        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblPublicValue;
        private System.Windows.Forms.Label lblPublicText;
        private System.Windows.Forms.Label lblHiddenValue;
        private System.Windows.Forms.Label lblHiddenText;
        private System.Windows.Forms.Label lblRentValue;
        private System.Windows.Forms.Label lblRentText;
        private System.Windows.Forms.Label lblSaleValue;
        private System.Windows.Forms.Label lblSaleText;

        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Label lblListSub;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.ComboBox cmbTypeFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel propertiesPanel;

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
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblPortal = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.cardTotal = new System.Windows.Forms.Panel();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.cardPublic = new System.Windows.Forms.Panel();
            this.lblPublicValue = new System.Windows.Forms.Label();
            this.lblPublicText = new System.Windows.Forms.Label();
            this.cardHidden = new System.Windows.Forms.Panel();
            this.lblHiddenValue = new System.Windows.Forms.Label();
            this.lblHiddenText = new System.Windows.Forms.Label();
            this.cardRent = new System.Windows.Forms.Panel();
            this.lblRentValue = new System.Windows.Forms.Label();
            this.lblRentText = new System.Windows.Forms.Label();
            this.cardSale = new System.Windows.Forms.Panel();
            this.lblSaleValue = new System.Windows.Forms.Label();
            this.lblSaleText = new System.Windows.Forms.Label();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lblListSub = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.cmbTypeFilter = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.propertiesPanel = new System.Windows.Forms.Panel();

            this.headerPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.cardPublic.SuspendLayout();
            this.cardHidden.SuspendLayout();
            this.cardRent.SuspendLayout();
            this.cardSale.SuspendLayout();
            this.SuspendLayout();

            // headerPanel
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.headerPanel.Controls.Add(this.lblBrand);
            this.headerPanel.Controls.Add(this.lblPortal);
            this.headerPanel.Controls.Add(this.btnLogout);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Size = new System.Drawing.Size(1180, 70);
            this.headerPanel.TabIndex = 0;

            // lblBrand
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(30, 16);
            this.lblBrand.Text = "🏠 QuickNest";

            // lblPortal
            this.lblPortal.AutoSize = true;
            this.lblPortal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPortal.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.lblPortal.Location = new System.Drawing.Point(235, 26);
            this.lblPortal.Text = "Admin Portal";

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1050, 18);
            this.btnLogout.Size = new System.Drawing.Size(100, 34);
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTitle.Location = new System.Drawing.Point(40, 95);
            this.lblTitle.Text = "Admin Dashboard";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSubtitle.Location = new System.Drawing.Point(45, 145);
            this.lblSubtitle.Text = "Monitor listings, visibility, and property activity across QuickNest.";

            // statsPanel
            this.statsPanel.Controls.Add(this.cardTotal);
            this.statsPanel.Controls.Add(this.cardPublic);
            this.statsPanel.Controls.Add(this.cardHidden);
            this.statsPanel.Controls.Add(this.cardRent);
            this.statsPanel.Controls.Add(this.cardSale);
            this.statsPanel.Location = new System.Drawing.Point(40, 185);
            this.statsPanel.Size = new System.Drawing.Size(1100, 110);

            // cardTotal
            this.cardTotal.BackColor = System.Drawing.Color.White;
            this.cardTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotal.Controls.Add(this.lblTotalValue);
            this.cardTotal.Controls.Add(this.lblTotalText);
            this.cardTotal.Location = new System.Drawing.Point(0, 0);
            this.cardTotal.Size = new System.Drawing.Size(200, 100);

            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTotalValue.Location = new System.Drawing.Point(18, 12);
            this.lblTotalValue.Size = new System.Drawing.Size(160, 50);
            this.lblTotalValue.Text = "0";

            this.lblTotalText.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTotalText.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalText.Location = new System.Drawing.Point(20, 64);
            this.lblTotalText.Size = new System.Drawing.Size(160, 22);
            this.lblTotalText.Text = "Total Listings";

            // cardPublic
            this.cardPublic.BackColor = System.Drawing.Color.White;
            this.cardPublic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardPublic.Controls.Add(this.lblPublicValue);
            this.cardPublic.Controls.Add(this.lblPublicText);
            this.cardPublic.Location = new System.Drawing.Point(225, 0);
            this.cardPublic.Size = new System.Drawing.Size(200, 100);

            this.lblPublicValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblPublicValue.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblPublicValue.Location = new System.Drawing.Point(18, 12);
            this.lblPublicValue.Size = new System.Drawing.Size(160, 50);
            this.lblPublicValue.Text = "0";

            this.lblPublicText.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPublicText.ForeColor = System.Drawing.Color.Gray;
            this.lblPublicText.Location = new System.Drawing.Point(20, 64);
            this.lblPublicText.Size = new System.Drawing.Size(160, 22);
            this.lblPublicText.Text = "Public Listings";

            // cardHidden
            this.cardHidden.BackColor = System.Drawing.Color.White;
            this.cardHidden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardHidden.Controls.Add(this.lblHiddenValue);
            this.cardHidden.Controls.Add(this.lblHiddenText);
            this.cardHidden.Location = new System.Drawing.Point(450, 0);
            this.cardHidden.Size = new System.Drawing.Size(200, 100);

            this.lblHiddenValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblHiddenValue.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblHiddenValue.Location = new System.Drawing.Point(18, 12);
            this.lblHiddenValue.Size = new System.Drawing.Size(160, 50);
            this.lblHiddenValue.Text = "0";

            this.lblHiddenText.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHiddenText.ForeColor = System.Drawing.Color.Gray;
            this.lblHiddenText.Location = new System.Drawing.Point(20, 64);
            this.lblHiddenText.Size = new System.Drawing.Size(160, 22);
            this.lblHiddenText.Text = "Hidden Listings";

            // cardRent
            this.cardRent.BackColor = System.Drawing.Color.White;
            this.cardRent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardRent.Controls.Add(this.lblRentValue);
            this.cardRent.Controls.Add(this.lblRentText);
            this.cardRent.Location = new System.Drawing.Point(675, 0);
            this.cardRent.Size = new System.Drawing.Size(200, 100);

            this.lblRentValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblRentValue.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblRentValue.Location = new System.Drawing.Point(18, 12);
            this.lblRentValue.Size = new System.Drawing.Size(160, 50);
            this.lblRentValue.Text = "0";

            this.lblRentText.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRentText.ForeColor = System.Drawing.Color.Gray;
            this.lblRentText.Location = new System.Drawing.Point(20, 64);
            this.lblRentText.Size = new System.Drawing.Size(160, 22);
            this.lblRentText.Text = "For Rent";

            // cardSale
            this.cardSale.BackColor = System.Drawing.Color.White;
            this.cardSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardSale.Controls.Add(this.lblSaleValue);
            this.cardSale.Controls.Add(this.lblSaleText);
            this.cardSale.Location = new System.Drawing.Point(900, 0);
            this.cardSale.Size = new System.Drawing.Size(200, 100);

            this.lblSaleValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblSaleValue.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblSaleValue.Location = new System.Drawing.Point(18, 12);
            this.lblSaleValue.Size = new System.Drawing.Size(160, 50);
            this.lblSaleValue.Text = "0";

            this.lblSaleText.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSaleText.ForeColor = System.Drawing.Color.Gray;
            this.lblSaleText.Location = new System.Drawing.Point(20, 64);
            this.lblSaleText.Size = new System.Drawing.Size(160, 22);
            this.lblSaleText.Text = "For Sale";

            // list title
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblListTitle.Location = new System.Drawing.Point(40, 315);
            this.lblListTitle.Text = "Property Management";

            this.lblListSub.AutoSize = true;
            this.lblListSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblListSub.ForeColor = System.Drawing.Color.Gray;
            this.lblListSub.Location = new System.Drawing.Point(45, 350);
            this.lblListSub.Text = "0 properties found";

            // txtSearch
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(40, 380);
            this.txtSearch.Size = new System.Drawing.Size(360, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // cmbStatusFilter
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatusFilter.Items.AddRange(new object[] { "All Status", "Public", "Hidden" });
            this.cmbStatusFilter.Location = new System.Drawing.Point(420, 380);
            this.cmbStatusFilter.Size = new System.Drawing.Size(160, 23);
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);

            // cmbTypeFilter
            this.cmbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTypeFilter.Items.AddRange(new object[] { "All Types", "Rent", "Sale" });
            this.cmbTypeFilter.Location = new System.Drawing.Point(600, 380);
            this.cmbTypeFilter.Size = new System.Drawing.Size(160, 23);
            this.cmbTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cmbTypeFilter_SelectedIndexChanged);

            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(780, 378);
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // propertiesPanel
            this.propertiesPanel.AutoScroll = true;
            this.propertiesPanel.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.propertiesPanel.Location = new System.Drawing.Point(40, 425);
            this.propertiesPanel.Size = new System.Drawing.Size(1100, 330);

            // AdminDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(1180, 790);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.lblListTitle);
            this.Controls.Add(this.lblListSub);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbStatusFilter);
            this.Controls.Add(this.cmbTypeFilter);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.propertiesPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickNest - Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);

            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.cardTotal.ResumeLayout(false);
            this.cardPublic.ResumeLayout(false);
            this.cardHidden.ResumeLayout(false);
            this.cardRent.ResumeLayout(false);
            this.cardSale.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
