using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AdminDashboardForm : Form
    {
        private readonly Color PrimaryBlue = Color.FromArgb(37, 99, 235);
        private readonly Color SuccessGreen = Color.FromArgb(22, 163, 74);
        private readonly Color DangerRed = Color.FromArgb(220, 38, 38);
        private readonly Color MutedGray = Color.FromArgb(107, 114, 128);

        // Local cache so we don't hit the DB on every filter/search
        private List<DatabaseHelper.PropertyRecord> _allProperties = new List<DatabaseHelper.PropertyRecord>();

        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            cmbStatusFilter.SelectedIndex = 0;
            cmbTypeFilter.SelectedIndex = 0;
            LoadDashboard();
        }

        // ── Reload everything from DB ─────────────────────────────────
        private void LoadDashboard()
        {
            // Admin sees ALL properties from ALL owners
            _allProperties = DatabaseHelper.GetAllPropertiesAdmin();
            UpdateStatistics();
            LoadPropertyCards();
        }

        private void UpdateStatistics()
        {
            lblTotalValue.Text = _allProperties.Count.ToString();
            lblPublicValue.Text = _allProperties.Count(p => p.IsPublic).ToString();
            lblHiddenValue.Text = _allProperties.Count(p => !p.IsPublic).ToString();
            lblRentValue.Text = _allProperties.Count(p => p.PropertyType == "Rent").ToString();
            lblSaleValue.Text = _allProperties.Count(p => p.PropertyType == "Sale").ToString();
        }

        private void LoadPropertyCards()
        {
            propertiesPanel.Controls.Clear();
            propertiesPanel.AutoScrollPosition = new Point(0, 0);

            string search = txtSearch.Text.Trim().ToLower();
            string statusFilter = cmbStatusFilter.SelectedItem?.ToString() ?? "All Status";
            string typeFilter = cmbTypeFilter.SelectedItem?.ToString() ?? "All Types";

            var properties = _allProperties
                .Where(p =>
                    string.IsNullOrWhiteSpace(search) ||
                    (p.Title ?? "").ToLower().Contains(search) ||
                    (p.Location ?? "").ToLower().Contains(search) ||
                    (p.Details ?? "").ToLower().Contains(search))
                .Where(p =>
                    statusFilter == "All Status" ||
                    (statusFilter == "Public" && p.IsPublic) ||
                    (statusFilter == "Hidden" && !p.IsPublic))
                .Where(p =>
                    typeFilter == "All Types" ||
                    p.PropertyType == typeFilter)
                .OrderByDescending(p => p.DatePosted)
                .ToList();

            lblListSub.Text = $"{properties.Count} propert{(properties.Count == 1 ? "y" : "ies")} found";

            if (properties.Count == 0)
            {
                Panel emptyPanel = new Panel
                {
                    Size = new Size(1000, 140),
                    Location = new Point(10, 10),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };
                emptyPanel.Controls.Add(new Label
                {
                    Text = "No properties found.",
                    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(55, 65, 81),
                    AutoSize = true,
                    Location = new Point(24, 34)
                });
                emptyPanel.Controls.Add(new Label
                {
                    Text = "Try changing the search text or filters.",
                    Font = new Font("Segoe UI", 10F),
                    ForeColor = MutedGray,
                    AutoSize = true,
                    Location = new Point(25, 75)
                });
                propertiesPanel.Controls.Add(emptyPanel);
                propertiesPanel.AutoScrollMinSize = new Size(0, 170);
                return;
            }

            int y = 10;
            int cardHeight = 180;
            int gap = 16;

            foreach (var property in properties)
            {
                Panel card = CreateAdminPropertyCard(property);
                card.Location = new Point(10, y);
                propertiesPanel.Controls.Add(card);
                y += cardHeight + gap;
            }

            propertiesPanel.AutoScrollMinSize = new Size(0, y + 10);
        }

        private Panel CreateAdminPropertyCard(DatabaseHelper.PropertyRecord property)
        {
            Panel card = new Panel
            {
                Size = new Size(1000, 180),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Image
            PictureBox imageBox = new PictureBox
            {
                Size = new Size(150, 130),
                Location = new Point(18, 24),
                BackColor = Color.FromArgb(226, 232, 240),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            if (property.ImageData != null && property.ImageData.Length > 0)
            {
                using (var ms = new MemoryStream(property.ImageData))
                    imageBox.Image = Image.FromStream(ms);
            }
            card.Controls.Add(imageBox);

            // Title
            card.Controls.Add(new Label
            {
                Text = string.IsNullOrWhiteSpace(property.Title) ? "Untitled Property" : property.Title,
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(17, 24, 39),
                Location = new Point(185, 22),
                Size = new Size(410, 30),
                AutoEllipsis = true
            });

            // Owner email (useful for admin)
            card.Controls.Add(new Label
            {
                Text = "👤 " + property.OwnerEmail,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = MutedGray,
                Location = new Point(185, 54),
                Size = new Size(410, 20)
            });

            // Location
            card.Controls.Add(new Label
            {
                Text = "📍 " + (string.IsNullOrWhiteSpace(property.Location) ? "No location" : property.Location),
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = MutedGray,
                Location = new Point(185, 76),
                Size = new Size(410, 24),
                AutoEllipsis = true
            });

            // Price
            string priceText = "₱" + property.Price.ToString("N0") +
                               (property.PropertyType == "Rent" ? "/mo" : "");
            card.Controls.Add(new Label
            {
                Text = priceText,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = PrimaryBlue,
                Location = new Point(185, 102),
                Size = new Size(220, 30)
            });

            // Details
            card.Controls.Add(new Label
            {
                Text = string.IsNullOrWhiteSpace(property.Details) ? "No details provided." : property.Details,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(75, 85, 99),
                Location = new Point(185, 136),
                Size = new Size(430, 34),
                AutoEllipsis = true
            });

            // Type badge
            card.Controls.Add(new Label
            {
                Text = property.PropertyType == "Rent" ? "For Rent" : "For Sale",
                BackColor = property.PropertyType == "Rent" ? PrimaryBlue : SuccessGreen,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(635, 26),
                Size = new Size(90, 26)
            });

            // Status badge
            card.Controls.Add(new Label
            {
                Text = property.IsPublic ? "Public" : "Hidden",
                BackColor = property.IsPublic ? SuccessGreen : MutedGray,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(735, 26),
                Size = new Size(80, 26)
            });

            // Date posted
            card.Controls.Add(new Label
            {
                Text = "Posted: " + property.DatePosted.ToString("MMM dd, yyyy"),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = MutedGray,
                Location = new Point(635, 65),
                Size = new Size(230, 22)
            });

            // Toggle public/hidden button
            Button toggleBtn = CreateActionButton(
                property.IsPublic ? "Hide Listing" : "Make Public",
                property.IsPublic ? MutedGray : SuccessGreen,
                new Point(635, 105));

            toggleBtn.Click += (s, e) =>
            {
                property.IsPublic = !property.IsPublic;
                DatabaseHelper.SetPropertyPublic(property.Id, property.IsPublic);

                MessageBox.Show(
                    property.IsPublic
                        ? $"\"{property.Title}\" is now public."
                        : $"\"{property.Title}\" is now hidden.",
                    property.IsPublic ? "Published" : "Hidden",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDashboard();
            };
            card.Controls.Add(toggleBtn);

            // Delete button
            Button deleteBtn = CreateActionButton("Delete", DangerRed, new Point(775, 105));
            deleteBtn.Click += (s, e) =>
            {
                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete \"{property.Title}\"?",
                    "Delete Property", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    DatabaseHelper.DeleteProperty(property.Id);
                    LoadDashboard();
                }
            };
            card.Controls.Add(deleteBtn);

            return card;
        }

        private Button CreateActionButton(string text, Color backColor, Point location)
        {
            var button = new Button
            {
                Text = text,
                BackColor = backColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Size = new Size(125, 36),
                Location = location,
                Cursor = Cursors.Hand
            };
            button.FlatAppearance.BorderSize = 0;
            return button;
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadDashboard();
        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadPropertyCards();
        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e) => LoadPropertyCards();
        private void cmbTypeFilter_SelectedIndexChanged(object sender, EventArgs e) => LoadPropertyCards();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                new LoginPage().Show();
                this.Close();
            }
        }
    }
}