namespace FinalProject
{
    partial class BrowseAllForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelPropHub;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Panel panelHouse;
        private System.Windows.Forms.Label labelHouseListings;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.Panel panelCondo;
        private System.Windows.Forms.Label labelCondoListings;
        private System.Windows.Forms.Label labelCondo;
        private System.Windows.Forms.Panel panelApartment;
        private System.Windows.Forms.Label labelApartmentListings;
        private System.Windows.Forms.Label labelApartment;
        private System.Windows.Forms.Label labelFeatured;
        private System.Windows.Forms.Label labelFeaturedSub;
        private System.Windows.Forms.Panel propertiesPanel;
        private System.Windows.Forms.Panel panelVilla;
        private System.Windows.Forms.Label labelVillaListings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLand;
        private System.Windows.Forms.Label labelLandListings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.Label labelFilter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelPropHub = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.panelHouse = new System.Windows.Forms.Panel();
            this.labelHouseListings = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.panelCondo = new System.Windows.Forms.Panel();
            this.labelCondoListings = new System.Windows.Forms.Label();
            this.labelCondo = new System.Windows.Forms.Label();
            this.panelApartment = new System.Windows.Forms.Panel();
            this.labelApartmentListings = new System.Windows.Forms.Label();
            this.labelApartment = new System.Windows.Forms.Label();
            this.labelFeatured = new System.Windows.Forms.Label();
            this.labelFeaturedSub = new System.Windows.Forms.Label();
            this.propertiesPanel = new System.Windows.Forms.Panel();
            this.panelVilla = new System.Windows.Forms.Panel();
            this.labelVillaListings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLand = new System.Windows.Forms.Panel();
            this.labelLandListings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelHouse.SuspendLayout();
            this.panelCondo.SuspendLayout();
            this.panelApartment.SuspendLayout();
            this.panelVilla.SuspendLayout();
            this.panelLand.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.panelHeader.Controls.Add(this.labelPropHub);
            this.panelHeader.Controls.Add(this.BackBtn);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 70);
            this.panelHeader.TabIndex = 0;

            // labelPropHub
            this.labelPropHub.AutoSize = true;
            this.labelPropHub.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelPropHub.ForeColor = System.Drawing.Color.White;
            this.labelPropHub.Location = new System.Drawing.Point(32, 15);
            this.labelPropHub.Name = "labelPropHub";
            this.labelPropHub.TabIndex = 0;
            this.labelPropHub.Text = "🏠 QuickNest";

            // BackBtn
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(980, 18);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(90, 34);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "← Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.labelTitle.Location = new System.Drawing.Point(40, 95);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Browse All Properties";

            // labelSubtitle
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.labelSubtitle.Location = new System.Drawing.Point(45, 145);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.TabIndex = 2;
            this.labelSubtitle.Text = "View every property added by owners in one clean place.";

            // panelHouse
            this.panelHouse.BackColor = System.Drawing.Color.White;
            this.panelHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHouse.Controls.Add(this.labelHouseListings);
            this.panelHouse.Controls.Add(this.labelHouse);
            this.panelHouse.Location = new System.Drawing.Point(65, 178);
            this.panelHouse.Name = "panelHouse";
            this.panelHouse.Size = new System.Drawing.Size(136, 78);
            this.panelHouse.TabIndex = 3;

            // labelHouseListings
            this.labelHouseListings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelHouseListings.ForeColor = System.Drawing.Color.Gray;
            this.labelHouseListings.Location = new System.Drawing.Point(22, 52);
            this.labelHouseListings.Name = "labelHouseListings";
            this.labelHouseListings.Size = new System.Drawing.Size(100, 25);
            this.labelHouseListings.TabIndex = 1;
            this.labelHouseListings.Text = "0 listings";

            // labelHouse
            this.labelHouse.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelHouse.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.labelHouse.Location = new System.Drawing.Point(31, 10);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(72, 30);
            this.labelHouse.TabIndex = 0;
            this.labelHouse.Text = "House";

            // panelCondo
            this.panelCondo.BackColor = System.Drawing.Color.White;
            this.panelCondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCondo.Controls.Add(this.labelCondoListings);
            this.panelCondo.Controls.Add(this.labelCondo);
            this.panelCondo.Location = new System.Drawing.Point(261, 178);
            this.panelCondo.Name = "panelCondo";
            this.panelCondo.Size = new System.Drawing.Size(140, 78);
            this.panelCondo.TabIndex = 4;

            // labelCondoListings
            this.labelCondoListings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCondoListings.ForeColor = System.Drawing.Color.Gray;
            this.labelCondoListings.Location = new System.Drawing.Point(35, 51);
            this.labelCondoListings.Name = "labelCondoListings";
            this.labelCondoListings.Size = new System.Drawing.Size(100, 25);
            this.labelCondoListings.TabIndex = 1;
            this.labelCondoListings.Text = "0 listings";

            // labelCondo
            this.labelCondo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelCondo.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.labelCondo.Location = new System.Drawing.Point(34, 9);
            this.labelCondo.Name = "labelCondo";
            this.labelCondo.Size = new System.Drawing.Size(72, 30);
            this.labelCondo.TabIndex = 0;
            this.labelCondo.Text = "Condo";

            // panelApartment
            this.panelApartment.BackColor = System.Drawing.Color.White;
            this.panelApartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelApartment.Controls.Add(this.labelApartmentListings);
            this.panelApartment.Controls.Add(this.labelApartment);
            this.panelApartment.Location = new System.Drawing.Point(476, 178);
            this.panelApartment.Name = "panelApartment";
            this.panelApartment.Size = new System.Drawing.Size(140, 78);
            this.panelApartment.TabIndex = 5;

            // labelApartmentListings
            this.labelApartmentListings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelApartmentListings.ForeColor = System.Drawing.Color.Gray;
            this.labelApartmentListings.Location = new System.Drawing.Point(35, 51);
            this.labelApartmentListings.Name = "labelApartmentListings";
            this.labelApartmentListings.Size = new System.Drawing.Size(100, 25);
            this.labelApartmentListings.TabIndex = 1;
            this.labelApartmentListings.Text = "0 listings";

            // labelApartment
            this.labelApartment.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelApartment.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.labelApartment.Location = new System.Drawing.Point(13, 12);
            this.labelApartment.Name = "labelApartment";
            this.labelApartment.Size = new System.Drawing.Size(122, 30);
            this.labelApartment.TabIndex = 0;
            this.labelApartment.Text = "Apartment";
            this.labelApartment.Click += new System.EventHandler(this.labelApartment_Click);

            // panelVilla
            this.panelVilla.BackColor = System.Drawing.Color.White;
            this.panelVilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVilla.Controls.Add(this.labelVillaListings);
            this.panelVilla.Controls.Add(this.label2);
            this.panelVilla.Location = new System.Drawing.Point(685, 178);
            this.panelVilla.Name = "panelVilla";
            this.panelVilla.Size = new System.Drawing.Size(140, 78);
            this.panelVilla.TabIndex = 6;

            // labelVillaListings
            this.labelVillaListings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelVillaListings.ForeColor = System.Drawing.Color.Gray;
            this.labelVillaListings.Location = new System.Drawing.Point(35, 51);
            this.labelVillaListings.Name = "labelVillaListings";
            this.labelVillaListings.Size = new System.Drawing.Size(100, 25);
            this.labelVillaListings.TabIndex = 1;
            this.labelVillaListings.Text = "0 listings";

            // label2 (Villa)
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.label2.Location = new System.Drawing.Point(44, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Villa";

            // panelLand
            this.panelLand.BackColor = System.Drawing.Color.White;
            this.panelLand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLand.Controls.Add(this.labelLandListings);
            this.panelLand.Controls.Add(this.label3);
            this.panelLand.Location = new System.Drawing.Point(899, 178);
            this.panelLand.Name = "panelLand";
            this.panelLand.Size = new System.Drawing.Size(140, 78);
            this.panelLand.TabIndex = 9;

            // labelLandListings
            this.labelLandListings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelLandListings.ForeColor = System.Drawing.Color.Gray;
            this.labelLandListings.Location = new System.Drawing.Point(35, 51);
            this.labelLandListings.Name = "labelLandListings";
            this.labelLandListings.Size = new System.Drawing.Size(100, 25);
            this.labelLandListings.TabIndex = 1;
            this.labelLandListings.Text = "0 listings";

            // label3 (Land)
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.label3.Location = new System.Drawing.Point(44, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Land";

            // labelFeatured
            this.labelFeatured.AutoSize = true;
            this.labelFeatured.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelFeatured.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.labelFeatured.Location = new System.Drawing.Point(40, 278);
            this.labelFeatured.Name = "labelFeatured";
            this.labelFeatured.TabIndex = 6;
            this.labelFeatured.Text = "Available Listings";

            // labelFeaturedSub
            this.labelFeaturedSub.AutoSize = true;
            this.labelFeaturedSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFeaturedSub.ForeColor = System.Drawing.Color.Gray;
            this.labelFeaturedSub.Location = new System.Drawing.Point(45, 315);
            this.labelFeaturedSub.Name = "labelFeaturedSub";
            this.labelFeaturedSub.TabIndex = 7;
            this.labelFeaturedSub.Text = "0 properties available";

            // labelFilter
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelFilter.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.labelFilter.Location = new System.Drawing.Point(600, 315);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.TabIndex = 10;
            this.labelFilter.Text = "Filter by Category:";

            // cmbCategoryFilter
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoryFilter.Location = new System.Drawing.Point(740, 312);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(200, 25);
            this.cmbCategoryFilter.TabIndex = 11;
            this.cmbCategoryFilter.Items.AddRange(new object[] {
                "All", "House", "Condo", "Apartment", "Villa", "Land"
            });
            this.cmbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryFilter_SelectedIndexChanged);

            // propertiesPanel
            this.propertiesPanel.AutoScroll = true;
            this.propertiesPanel.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.propertiesPanel.Location = new System.Drawing.Point(40, 340);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.Size = new System.Drawing.Size(1020, 408);
            this.propertiesPanel.TabIndex = 8;

            // BrowseAllForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(1100, 780);
            this.Controls.Add(this.panelLand);
            this.Controls.Add(this.panelVilla);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.panelHouse);
            this.Controls.Add(this.panelCondo);
            this.Controls.Add(this.panelApartment);
            this.Controls.Add(this.labelFeatured);
            this.Controls.Add(this.labelFeaturedSub);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.cmbCategoryFilter);
            this.Controls.Add(this.propertiesPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "BrowseAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse All Properties";
            this.Load += new System.EventHandler(this.BrowseAllForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelHouse.ResumeLayout(false);
            this.panelCondo.ResumeLayout(false);
            this.panelApartment.ResumeLayout(false);
            this.panelVilla.ResumeLayout(false);
            this.panelLand.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}