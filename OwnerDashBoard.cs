using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class OwnerDashBoard : Form
    {
        public static string CurrentOwnerEmail { get; set; }

        private readonly Color PrimaryBlue = Color.FromArgb(37, 99, 235);
        private readonly Color SuccessGreen = Color.FromArgb(22, 163, 74);
        private readonly Color MutedGray = Color.FromArgb(107, 114, 128);

        private readonly string _ownerEmail; // ← local copy, always reliable

        public OwnerDashBoard(string ownerEmail)  // ← accept email in constructor
        {
            InitializeComponent();
            listingsContainer.AutoScroll = true;

            // Store in both places
            _ownerEmail = ownerEmail;
            CurrentOwnerEmail = ownerEmail;
            LoadProperties(); 
            UpdateStats();

        }

        private void OwnerDashBoard_Load_1(object sender, EventArgs e)
        {
           //
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to log out?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CurrentOwnerEmail = null;
                SessionManager.IsLoggedIn = false;
                new LoginPage().Show();
                this.Close();
            }
        }

        private void LoadProperties()
        {
            listingsContainer.Controls.Clear();

            if (string.IsNullOrEmpty(_ownerEmail))
            {
                listingsContainer.Controls.Add(new Label
                {
                    Text = "Session error. Please log out and log in again.",
                    AutoSize = true,
                    Location = new Point(20, 20),
                    ForeColor = Color.Red,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold)
                });
                return;
            }

            var properties = DatabaseHelper.GetAllProperties(_ownerEmail);

            if (properties == null || properties.Count == 0)
            {
                listingsContainer.Controls.Add(CreateEmptyPanel());
                return;
            }

            int y = 10;
            foreach (var p in properties)
            {
                Panel card = CreateCard(p);
                card.Location = new Point(10, y);
                listingsContainer.Controls.Add(card);
                y += 280;
            }

            listingsContainer.AutoScrollMinSize = new Size(0, y + 20);
        }

        private Panel CreateCard(DatabaseHelper.PropertyRecord p)
        {
            Panel card = new Panel
            {
                Size = new Size(950, 260),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Image
            PictureBox img = new PictureBox
            {
                Size = new Size(220, 220),
                Location = new Point(15, 20),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.LightGray
            };
            if (p.ImageData != null && p.ImageData.Length > 0)
            {
                using (var ms = new MemoryStream(p.ImageData))
                    img.Image = Image.FromStream(ms);
            }
            card.Controls.Add(img);

            // Title
            card.Controls.Add(new Label
            {
                Text = p.Title,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(260, 20),
                AutoSize = true
            });

            // Location
            card.Controls.Add(new Label
            {
                Text = "📍 " + p.Location,
                Location = new Point(260, 55),
                AutoSize = true,
                ForeColor = Color.Gray
            });

            // Price
            card.Controls.Add(new Label
            {
                Text = $"₱{p.Price:N0}" + (p.PropertyType == "Rent" ? "/mo" : ""),
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = PrimaryBlue,
                Location = new Point(260, 90),
                AutoSize = true
            });

            // Details
            card.Controls.Add(new Label
            {
                Text = p.Details,
                Location = new Point(260, 130),
                Size = new Size(450, 50),
                ForeColor = Color.DimGray
            });

            // Type badge
            card.Controls.Add(new Label
            {
                Text = p.PropertyType == "Rent" ? "FOR RENT" : "FOR SALE",
                BackColor = p.PropertyType == "Rent" ? PrimaryBlue : SuccessGreen,
                ForeColor = Color.White,
                Location = new Point(260, 190),
                AutoSize = true,
                Padding = new Padding(6)
            });

            // Visibility status
            card.Controls.Add(new Label
            {
                Text = p.IsPublic ? "✅ Visible to buyers" : "🔒 Hidden",
                ForeColor = p.IsPublic ? SuccessGreen : MutedGray,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(780, 195),
                AutoSize = true
            });

            // Action buttons
            Panel actions = new Panel
            {
                Size = new Size(140, 155),
                Location = new Point(790, 25)
            };

            Button btnToggle = new Button
            {
                Text = p.IsPublic ? "🔒 Hide" : "✅ Publish",
                Size = new Size(120, 35),
                Location = new Point(0, 0),
                BackColor = p.IsPublic ? MutedGray : SuccessGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnToggle.FlatAppearance.BorderSize = 0;
            btnToggle.Click += (s, e) =>
            {
                DatabaseHelper.SetPropertyPublic(p.Id, !p.IsPublic);
                LoadProperties();
                UpdateStats();
            };

            Button btnEdit = new Button
            {
                Text = "✏ Edit",
                Size = new Size(120, 35),
                Location = new Point(0, 45),
                BackColor = PrimaryBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Click += (s, e) => EditProperty(p);

            Button btnDelete = new Button
            {
                Text = "🗑 Delete",
                Size = new Size(120, 35),
                Location = new Point(0, 90),
                BackColor = Color.FromArgb(220, 38, 38),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Click += (s, e) =>
            {
                if (MessageBox.Show("Delete this property?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DatabaseHelper.DeleteProperty(p.Id);
                    LoadProperties();
                    UpdateStats();
                }
            };

            actions.Controls.Add(btnToggle);
            actions.Controls.Add(btnEdit);
            actions.Controls.Add(btnDelete);
            card.Controls.Add(actions);

            return card;
        }

        private void EditProperty(DatabaseHelper.PropertyRecord p)
        {
            using (Form f = new Form())
            {
                f.Text = "Edit Property Details";
                f.Size = new Size(520, 430);
                f.StartPosition = FormStartPosition.CenterParent;
                f.FormBorderStyle = FormBorderStyle.FixedDialog;
                f.BackColor = Color.White;
                f.MaximizeBox = false;

                int left = 30, top = 20, spacing = 55;

                f.Controls.Add(new Label { Text = "Property Title", Location = new Point(left, top), AutoSize = true });
                TextBox txtTitle = new TextBox { Text = p.Title, Location = new Point(left, top + 22), Width = 440 };
                f.Controls.Add(txtTitle);

                top += spacing;
                f.Controls.Add(new Label { Text = "Location", Location = new Point(left, top), AutoSize = true });
                TextBox txtLoc = new TextBox { Text = p.Location, Location = new Point(left, top + 22), Width = 440 };
                f.Controls.Add(txtLoc);

                top += spacing;
                f.Controls.Add(new Label { Text = "Description", Location = new Point(left, top), AutoSize = true });
                TextBox txtDetails = new TextBox
                {
                    Text = p.Details,
                    Location = new Point(left, top + 22),
                    Width = 440,
                    Height = 60,
                    Multiline = true
                };
                f.Controls.Add(txtDetails);

                top += spacing + 30;
                f.Controls.Add(new Label { Text = "Price (₱)", Location = new Point(left, top), AutoSize = true });
                NumericUpDown numPrice = new NumericUpDown
                {
                    Location = new Point(left, top + 22),
                    Width = 200,
                    Minimum = 0,
                    Maximum = 1000000000,
                    ThousandsSeparator = true,
                    Value = Math.Min(Math.Max((decimal)p.Price, 0), 1000000000)
                };
                f.Controls.Add(numPrice);

                top += spacing;
                CheckBox chkPublic = new CheckBox
                {
                    Text = "Visible to customers (Published)",
                    Checked = p.IsPublic,
                    Location = new Point(left, top),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10)
                };
                f.Controls.Add(chkPublic);

                top += 35;
                Button btnSave = new Button
                {
                    Text = "💾 Save Changes",
                    Location = new Point(left, top),
                    Size = new Size(180, 40),
                    BackColor = PrimaryBlue,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };
                btnSave.FlatAppearance.BorderSize = 0;
                btnSave.Click += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        MessageBox.Show("Title is required.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DatabaseHelper.UpdateProperty(
                        p.Id,
                        txtTitle.Text.Trim(),
                        txtDetails.Text.Trim(),
                        (double)numPrice.Value,
                        txtLoc.Text.Trim(),
                        p.PropertyType,
                        chkPublic.Checked);

                    f.Close();
                    LoadProperties();
                    UpdateStats();

                    MessageBox.Show("Property updated successfully!", "Updated",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                f.Controls.Add(btnSave);
                f.ShowDialog(this);
            }
        }

        private Panel CreateEmptyPanel()
        {
            return new Panel
            {
                Size = new Size(900, 150),
                BackColor = Color.White,
                Controls =
                {
                    new Label
                    {
                        Text      = "No properties listed yet. Click Add Property to start.",
                        Font      = new Font("Segoe UI", 13, FontStyle.Bold),
                        Location  = new Point(20, 40),
                        AutoSize  = true,
                        ForeColor = Color.FromArgb(55, 65, 81)
                    }
                }
            };
        }

        private void UpdateStats()
        {
            if (string.IsNullOrEmpty(_ownerEmail)) return;
            var properties = DatabaseHelper.GetAllProperties(_ownerEmail);
            lblTotalListingsValue.Text = properties.Count.ToString();
            lblForRentValue.Text = properties.Count(p => p.PropertyType == "Rent").ToString();
            lblForSaleValue.Text = properties.Count(p => p.PropertyType == "Sale").ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddPropertyForm form = new AddPropertyForm(_ownerEmail))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadProperties();
                    UpdateStats();
                }
            }
        }

        private void lblYourProperties_Click(object sender, EventArgs e)
        {

        }
    }
}