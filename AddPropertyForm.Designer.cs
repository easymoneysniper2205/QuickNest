namespace FinalProject
{
    partial class AddPropertyForm
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.cmbPropertyType = new System.Windows.Forms.ComboBox();
            this.picPropertyImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblPropertyType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPropertyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitle.Location = new System.Drawing.Point(180, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(350, 25);
            this.txtTitle.TabIndex = 0;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocation.Location = new System.Drawing.Point(180, 80);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(350, 25);
            this.txtLocation.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(180, 208);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 25);
            this.txtPrice.TabIndex = 3;
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDetails.Location = new System.Drawing.Point(180, 253);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(350, 100);
            this.txtDetails.TabIndex = 4;
            // 
            // cmbPropertyType
            // 
            this.cmbPropertyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropertyType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPropertyType.Items.AddRange(new object[] {
            "Sale",
            "Rent"});
            this.cmbPropertyType.Location = new System.Drawing.Point(180, 130);
            this.cmbPropertyType.Name = "cmbPropertyType";
            this.cmbPropertyType.Size = new System.Drawing.Size(150, 25);
            this.cmbPropertyType.TabIndex = 2;
            // 
            // picPropertyImage
            // 
            this.picPropertyImage.BackColor = System.Drawing.Color.LightGray;
            this.picPropertyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPropertyImage.Location = new System.Drawing.Point(180, 392);
            this.picPropertyImage.Name = "picPropertyImage";
            this.picPropertyImage.Size = new System.Drawing.Size(200, 150);
            this.picPropertyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPropertyImage.TabIndex = 5;
            this.picPropertyImage.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.Color.LightGray;
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Location = new System.Drawing.Point(399, 454);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(120, 35);
            this.btnBrowseImage.TabIndex = 6;
            this.btnBrowseImage.Text = "Browse Image";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.BtnBrowseImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(180, 569);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Property";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(369, 569);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 25);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Property Title:";
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocation.Location = new System.Drawing.Point(30, 80);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(150, 25);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Location:";
            // 
            // lblPropertyType
            // 
            this.lblPropertyType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPropertyType.Location = new System.Drawing.Point(30, 130);
            this.lblPropertyType.Name = "lblPropertyType";
            this.lblPropertyType.Size = new System.Drawing.Size(150, 25);
            this.lblPropertyType.TabIndex = 11;
            this.lblPropertyType.Text = "Listing Type";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(30, 208);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(150, 25);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price (₱):";
            // 
            // lblDetails
            // 
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetails.Location = new System.Drawing.Point(30, 256);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(150, 25);
            this.lblDetails.TabIndex = 13;
            this.lblDetails.Text = "Property Details:";
            // 
            // lblImage
            // 
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblImage.Location = new System.Drawing.Point(30, 392);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(150, 25);
            this.lblImage.TabIndex = 14;
            this.lblImage.Text = "Property Image:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "House",
            "Condo",
            "Apartment",
            "Villa",
            "Land"});
            this.cmbCategory.Location = new System.Drawing.Point(180, 172);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 25);
            this.cmbCategory.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Property Type:";
            // 
            // AddPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPropertyType);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.picPropertyImage);
            this.Controls.Add(this.cmbPropertyType);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtTitle);
            this.Name = "AddPropertyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Property";
            this.Load += new System.EventHandler(this.AddPropertyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPropertyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.ComboBox cmbPropertyType;
        private System.Windows.Forms.PictureBox picPropertyImage;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPropertyType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
    }
}