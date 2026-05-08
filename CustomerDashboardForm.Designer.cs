namespace FinalProject
{
    partial class CustomerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlNav = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSub = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblListingType = new System.Windows.Forms.Label();
            this.cmbListingType = new System.Windows.Forms.ComboBox();
            this.lblPropertyType = new System.Windows.Forms.Label();
            this.cmbPropertyType = new System.Windows.Forms.ComboBox();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.trkPrice = new System.Windows.Forms.TrackBar();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.pnlCard1Img = new System.Windows.Forms.Panel();
            this.lblBadge1 = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.lblCard1Loc = new System.Windows.Forms.Label();
            this.lblCard1Specs = new System.Windows.Forms.Label();
            this.lblCard1Price = new System.Windows.Forms.Label();
            this.lblCard1Tag = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.pnlCard2Img = new System.Windows.Forms.Panel();
            this.lblBadge2 = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.lblCard2Loc = new System.Windows.Forms.Label();
            this.lblCard2Specs = new System.Windows.Forms.Label();
            this.lblCard2Price = new System.Windows.Forms.Label();
            this.lblCard2Tag = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.pnlCard3Img = new System.Windows.Forms.Panel();
            this.lblBadge3 = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.lblCard3Loc = new System.Windows.Forms.Label();
            this.lblCard3Specs = new System.Windows.Forms.Label();
            this.lblCard3Price = new System.Windows.Forms.Label();
            this.lblCard3Tag = new System.Windows.Forms.Label();
            this.pnlNav.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPrice)).BeginInit();
            this.pnlCard1.SuspendLayout();
            this.pnlCard1Img.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard2Img.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard3Img.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlNav.Controls.Add(this.lblLogo);
            this.pnlNav.Controls.Add(this.BackBtn);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.pnlNav.Size = new System.Drawing.Size(1100, 56);
            this.pnlNav.TabIndex = 0;
            this.pnlNav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNav_Paint);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(13, 12);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(172, 32);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🏠 QuickNest";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(993, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 32);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Logout";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlBody.Controls.Add(this.lblPageTitle);
            this.pnlBody.Controls.Add(this.lblPageSub);
            this.pnlBody.Controls.Add(this.pnlFilters);
            this.pnlBody.Controls.Add(this.pnlCards);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(40, 24, 40, 24);
            this.pnlBody.Size = new System.Drawing.Size(1100, 700);
            this.pnlBody.TabIndex = 1;
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBody_Paint);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblPageTitle.Location = new System.Drawing.Point(40, 24);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(204, 30);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Browse Properties";
            // 
            // lblPageSub
            // 
            this.lblPageSub.AutoSize = true;
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblPageSub.Location = new System.Drawing.Point(40, 57);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(118, 15);
            this.lblPageSub.TabIndex = 1;
            this.lblPageSub.Text = "7 properties available";
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.lblListingType);
            this.pnlFilters.Controls.Add(this.cmbListingType);
            this.pnlFilters.Controls.Add(this.lblPropertyType);
            this.pnlFilters.Controls.Add(this.cmbPropertyType);
            this.pnlFilters.Controls.Add(this.lblMaxPrice);
            this.pnlFilters.Controls.Add(this.trkPrice);
            this.pnlFilters.Location = new System.Drawing.Point(40, 76);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(16);
            this.pnlFilters.Size = new System.Drawing.Size(1010, 120);
            this.pnlFilters.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtSearch.Location = new System.Drawing.Point(16, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(978, 25);
            this.txtSearch.TabIndex = 0;
            // 
            // lblListingType
            // 
            this.lblListingType.AutoSize = true;
            this.lblListingType.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblListingType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblListingType.Location = new System.Drawing.Point(16, 54);
            this.lblListingType.Name = "lblListingType";
            this.lblListingType.Size = new System.Drawing.Size(66, 13);
            this.lblListingType.TabIndex = 1;
            this.lblListingType.Text = "Listing Type";
            // 
            // cmbListingType
            // 
            this.cmbListingType.BackColor = System.Drawing.Color.White;
            this.cmbListingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListingType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbListingType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbListingType.Items.AddRange(new object[] {
            "All",
            "For Rent",
            "For Sale"});
            this.cmbListingType.Location = new System.Drawing.Point(16, 72);
            this.cmbListingType.Name = "cmbListingType";
            this.cmbListingType.Size = new System.Drawing.Size(200, 23);
            this.cmbListingType.TabIndex = 2;
            // 
            // lblPropertyType
            // 
            this.lblPropertyType.AutoSize = true;
            this.lblPropertyType.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPropertyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPropertyType.Location = new System.Drawing.Point(232, 54);
            this.lblPropertyType.Name = "lblPropertyType";
            this.lblPropertyType.Size = new System.Drawing.Size(75, 13);
            this.lblPropertyType.TabIndex = 3;
            this.lblPropertyType.Text = "Property Type";
            // 
            // cmbPropertyType
            // 
            this.cmbPropertyType.BackColor = System.Drawing.Color.White;
            this.cmbPropertyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropertyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPropertyType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPropertyType.Items.AddRange(new object[] {
            "All Types",
            "House",
            "Condo",
            "Apartment",
            "Villa",
            "Land"});
            this.cmbPropertyType.Location = new System.Drawing.Point(232, 72);
            this.cmbPropertyType.Name = "cmbPropertyType";
            this.cmbPropertyType.Size = new System.Drawing.Size(200, 23);
            this.cmbPropertyType.TabIndex = 4;
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMaxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblMaxPrice.Location = new System.Drawing.Point(450, 54);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(121, 13);
            this.lblMaxPrice.TabIndex = 5;
            this.lblMaxPrice.Text = "Max Price: ₱50,000,000";
            // 
            // trkPrice
            // 
            this.trkPrice.BackColor = System.Drawing.Color.White;
            this.trkPrice.LargeChange = 5000000;
            this.trkPrice.Location = new System.Drawing.Point(450, 70);
            this.trkPrice.Maximum = 50000000;
            this.trkPrice.Name = "trkPrice";
            this.trkPrice.Size = new System.Drawing.Size(540, 45);
            this.trkPrice.SmallChange = 500000;
            this.trkPrice.TabIndex = 6;
            this.trkPrice.TickFrequency = 5000000;
            this.trkPrice.Value = 50000000;
            this.trkPrice.Scroll += new System.EventHandler(this.trkPrice_Scroll);
            // 
            // pnlCards
            // 
            this.pnlCards.AutoScroll = true;
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlCards.Location = new System.Drawing.Point(40, 227);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(1010, 430);
            this.pnlCards.TabIndex = 3;
            this.pnlCards.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCards_Paint);
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.Controls.Add(this.pnlCard1Img);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Controls.Add(this.lblCard1Loc);
            this.pnlCard1.Controls.Add(this.lblCard1Specs);
            this.pnlCard1.Controls.Add(this.lblCard1Price);
            this.pnlCard1.Controls.Add(this.lblCard1Tag);
            this.pnlCard1.Location = new System.Drawing.Point(0, 0);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(318, 300);
            this.pnlCard1.TabIndex = 0;
            // 
            // pnlCard1Img
            // 
            this.pnlCard1Img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlCard1Img.Controls.Add(this.lblBadge1);
            this.pnlCard1Img.Location = new System.Drawing.Point(0, 0);
            this.pnlCard1Img.Name = "pnlCard1Img";
            this.pnlCard1Img.Size = new System.Drawing.Size(318, 150);
            this.pnlCard1Img.TabIndex = 0;
            // 
            // lblBadge1
            // 
            this.lblBadge1.AutoSize = true;
            this.lblBadge1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblBadge1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBadge1.ForeColor = System.Drawing.Color.White;
            this.lblBadge1.Location = new System.Drawing.Point(10, 10);
            this.lblBadge1.Name = "lblBadge1";
            this.lblBadge1.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.lblBadge1.Size = new System.Drawing.Size(63, 19);
            this.lblBadge1.TabIndex = 0;
            this.lblBadge1.Text = "For Rent";
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblCard1Title.Location = new System.Drawing.Point(12, 158);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(294, 42);
            this.lblCard1Title.TabIndex = 1;
            this.lblCard1Title.Text = "Modern 2BR Condo in Makati CBD";
            // 
            // lblCard1Loc
            // 
            this.lblCard1Loc.AutoSize = true;
            this.lblCard1Loc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCard1Loc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblCard1Loc.Location = new System.Drawing.Point(12, 202);
            this.lblCard1Loc.Name = "lblCard1Loc";
            this.lblCard1Loc.Size = new System.Drawing.Size(135, 15);
            this.lblCard1Loc.TabIndex = 2;
            this.lblCard1Loc.Text = "📍 Makati, Metro Manila";
            // 
            // lblCard1Specs
            // 
            this.lblCard1Specs.AutoSize = true;
            this.lblCard1Specs.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard1Specs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblCard1Specs.Location = new System.Drawing.Point(12, 222);
            this.lblCard1Specs.Name = "lblCard1Specs";
            this.lblCard1Specs.Size = new System.Drawing.Size(149, 13);
            this.lblCard1Specs.TabIndex = 3;
            this.lblCard1Specs.Text = "🛏 2 BR   🚿 2 BA   ⬚ 65 sqm";
            // 
            // lblCard1Price
            // 
            this.lblCard1Price.AutoSize = true;
            this.lblCard1Price.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard1Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblCard1Price.Location = new System.Drawing.Point(12, 252);
            this.lblCard1Price.Name = "lblCard1Price";
            this.lblCard1Price.Size = new System.Drawing.Size(98, 20);
            this.lblCard1Price.TabIndex = 4;
            this.lblCard1Price.Text = "₱35,000/mo";
            // 
            // lblCard1Tag
            // 
            this.lblCard1Tag.AutoSize = true;
            this.lblCard1Tag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblCard1Tag.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard1Tag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCard1Tag.Location = new System.Drawing.Point(248, 258);
            this.lblCard1Tag.Name = "lblCard1Tag";
            this.lblCard1Tag.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblCard1Tag.Size = new System.Drawing.Size(54, 17);
            this.lblCard1Tag.TabIndex = 5;
            this.lblCard1Tag.Text = "Condo";
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.Controls.Add(this.pnlCard2Img);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Controls.Add(this.lblCard2Loc);
            this.pnlCard2.Controls.Add(this.lblCard2Specs);
            this.pnlCard2.Controls.Add(this.lblCard2Price);
            this.pnlCard2.Controls.Add(this.lblCard2Tag);
            this.pnlCard2.Location = new System.Drawing.Point(346, 0);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(318, 300);
            this.pnlCard2.TabIndex = 1;
            // 
            // pnlCard2Img
            // 
            this.pnlCard2Img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlCard2Img.Controls.Add(this.lblBadge2);
            this.pnlCard2Img.Location = new System.Drawing.Point(0, 0);
            this.pnlCard2Img.Name = "pnlCard2Img";
            this.pnlCard2Img.Size = new System.Drawing.Size(318, 150);
            this.pnlCard2Img.TabIndex = 0;
            // 
            // lblBadge2
            // 
            this.lblBadge2.AutoSize = true;
            this.lblBadge2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblBadge2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBadge2.ForeColor = System.Drawing.Color.White;
            this.lblBadge2.Location = new System.Drawing.Point(10, 10);
            this.lblBadge2.Name = "lblBadge2";
            this.lblBadge2.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.lblBadge2.Size = new System.Drawing.Size(60, 19);
            this.lblBadge2.TabIndex = 0;
            this.lblBadge2.Text = "For Sale";
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblCard2Title.Location = new System.Drawing.Point(12, 158);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(294, 42);
            this.lblCard2Title.TabIndex = 1;
            this.lblCard2Title.Text = "Spacious 4BR House in Quezon City";
            // 
            // lblCard2Loc
            // 
            this.lblCard2Loc.AutoSize = true;
            this.lblCard2Loc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCard2Loc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblCard2Loc.Location = new System.Drawing.Point(12, 202);
            this.lblCard2Loc.Name = "lblCard2Loc";
            this.lblCard2Loc.Size = new System.Drawing.Size(164, 15);
            this.lblCard2Loc.TabIndex = 2;
            this.lblCard2Loc.Text = "📍 Quezon City, Metro Manila";
            // 
            // lblCard2Specs
            // 
            this.lblCard2Specs.AutoSize = true;
            this.lblCard2Specs.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard2Specs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblCard2Specs.Location = new System.Drawing.Point(12, 222);
            this.lblCard2Specs.Name = "lblCard2Specs";
            this.lblCard2Specs.Size = new System.Drawing.Size(155, 13);
            this.lblCard2Specs.TabIndex = 3;
            this.lblCard2Specs.Text = "🛏 4 BR   🚿 3 BA   ⬚ 180 sqm";
            // 
            // lblCard2Price
            // 
            this.lblCard2Price.AutoSize = true;
            this.lblCard2Price.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard2Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblCard2Price.Location = new System.Drawing.Point(12, 252);
            this.lblCard2Price.Name = "lblCard2Price";
            this.lblCard2Price.Size = new System.Drawing.Size(90, 20);
            this.lblCard2Price.TabIndex = 4;
            this.lblCard2Price.Text = "₱8,500,000";
            // 
            // lblCard2Tag
            // 
            this.lblCard2Tag.AutoSize = true;
            this.lblCard2Tag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblCard2Tag.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard2Tag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCard2Tag.Location = new System.Drawing.Point(248, 258);
            this.lblCard2Tag.Name = "lblCard2Tag";
            this.lblCard2Tag.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblCard2Tag.Size = new System.Drawing.Size(52, 17);
            this.lblCard2Tag.TabIndex = 5;
            this.lblCard2Tag.Text = "House";
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.Controls.Add(this.pnlCard3Img);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Controls.Add(this.lblCard3Loc);
            this.pnlCard3.Controls.Add(this.lblCard3Specs);
            this.pnlCard3.Controls.Add(this.lblCard3Price);
            this.pnlCard3.Controls.Add(this.lblCard3Tag);
            this.pnlCard3.Location = new System.Drawing.Point(692, 0);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(318, 300);
            this.pnlCard3.TabIndex = 2;
            // 
            // pnlCard3Img
            // 
            this.pnlCard3Img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.pnlCard3Img.Controls.Add(this.lblBadge3);
            this.pnlCard3Img.Location = new System.Drawing.Point(0, 0);
            this.pnlCard3Img.Name = "pnlCard3Img";
            this.pnlCard3Img.Size = new System.Drawing.Size(318, 150);
            this.pnlCard3Img.TabIndex = 0;
            // 
            // lblBadge3
            // 
            this.lblBadge3.AutoSize = true;
            this.lblBadge3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblBadge3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBadge3.ForeColor = System.Drawing.Color.White;
            this.lblBadge3.Location = new System.Drawing.Point(10, 10);
            this.lblBadge3.Name = "lblBadge3";
            this.lblBadge3.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.lblBadge3.Size = new System.Drawing.Size(63, 19);
            this.lblBadge3.TabIndex = 0;
            this.lblBadge3.Text = "For Rent";
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblCard3Title.Location = new System.Drawing.Point(12, 158);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(294, 42);
            this.lblCard3Title.TabIndex = 1;
            this.lblCard3Title.Text = "Affordable Studio Unit in Mandaluyong";
            // 
            // lblCard3Loc
            // 
            this.lblCard3Loc.AutoSize = true;
            this.lblCard3Loc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCard3Loc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblCard3Loc.Location = new System.Drawing.Point(12, 202);
            this.lblCard3Loc.Name = "lblCard3Loc";
            this.lblCard3Loc.Size = new System.Drawing.Size(173, 15);
            this.lblCard3Loc.TabIndex = 2;
            this.lblCard3Loc.Text = "📍 Mandaluyong, Metro Manila";
            // 
            // lblCard3Specs
            // 
            this.lblCard3Specs.AutoSize = true;
            this.lblCard3Specs.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard3Specs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblCard3Specs.Location = new System.Drawing.Point(12, 222);
            this.lblCard3Specs.Name = "lblCard3Specs";
            this.lblCard3Specs.Size = new System.Drawing.Size(149, 13);
            this.lblCard3Specs.TabIndex = 3;
            this.lblCard3Specs.Text = "🛏 1 BR   🚿 1 BA   ⬚ 22 sqm";
            // 
            // lblCard3Price
            // 
            this.lblCard3Price.AutoSize = true;
            this.lblCard3Price.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCard3Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblCard3Price.Location = new System.Drawing.Point(12, 252);
            this.lblCard3Price.Name = "lblCard3Price";
            this.lblCard3Price.Size = new System.Drawing.Size(98, 20);
            this.lblCard3Price.TabIndex = 4;
            this.lblCard3Price.Text = "₱15,000/mo";
            // 
            // lblCard3Tag
            // 
            this.lblCard3Tag.AutoSize = true;
            this.lblCard3Tag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblCard3Tag.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCard3Tag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCard3Tag.Location = new System.Drawing.Point(248, 258);
            this.lblCard3Tag.Name = "lblCard3Tag";
            this.lblCard3Tag.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblCard3Tag.Size = new System.Drawing.Size(53, 17);
            this.lblCard3Tag.TabIndex = 5;
            this.lblCard3Tag.Text = "Studio";
            // 
            // CustomerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlBody);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "CustomerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPrice)).EndInit();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlCard1Img.ResumeLayout(false);
            this.pnlCard1Img.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard2Img.ResumeLayout(false);
            this.pnlCard2Img.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.pnlCard3Img.ResumeLayout(false);
            this.pnlCard3Img.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Nav ──
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button BackBtn;

        // ── Body ──
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSub;

        // ── Filters ──
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblListingType;
        private System.Windows.Forms.ComboBox cmbListingType;
        private System.Windows.Forms.Label lblPropertyType;
        private System.Windows.Forms.ComboBox cmbPropertyType;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.TrackBar trkPrice;

        // ── Cards ──
        private System.Windows.Forms.Panel pnlCards;

        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Panel pnlCard1Img;
        private System.Windows.Forms.Label lblBadge1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Loc;
        private System.Windows.Forms.Label lblCard1Specs;
        private System.Windows.Forms.Label lblCard1Price;
        private System.Windows.Forms.Label lblCard1Tag;

        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Panel pnlCard2Img;
        private System.Windows.Forms.Label lblBadge2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblCard2Loc;
        private System.Windows.Forms.Label lblCard2Specs;
        private System.Windows.Forms.Label lblCard2Price;
        private System.Windows.Forms.Label lblCard2Tag;

        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Panel pnlCard3Img;
        private System.Windows.Forms.Label lblBadge3;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblCard3Loc;
        private System.Windows.Forms.Label lblCard3Specs;
        private System.Windows.Forms.Label lblCard3Price;
        private System.Windows.Forms.Label lblCard3Tag;
    }
}