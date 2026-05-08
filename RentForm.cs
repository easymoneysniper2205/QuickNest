using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
namespace FinalProject
{
    public partial class RentForm : Form
    {
        public RentForm()
        {
            InitializeComponent();
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            LoadRentProperties();
        }

        private void LoadRentProperties()
        {
            listingsPanel.Controls.Clear();
            listingsPanel.AutoScrollPosition = new Point(0, 0);

            var rentProperties = DatabaseHelper.GetPublicProperties("Rent");

            lblCount.Text = $"{rentProperties.Count} rent propert{(rentProperties.Count == 1 ? "y" : "ies")} available";

            if (rentProperties.Count == 0)
            {
                Panel emptyPanel = new Panel
                {
                    Size = new Size(960, 150),
                    Location = new Point(10, 10),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };
                emptyPanel.Controls.Add(new Label
                {
                    Text = "No rent properties available yet.",
                    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(55, 65, 81),
                    AutoSize = true,
                    Location = new Point(25, 35)
                });
                emptyPanel.Controls.Add(new Label
                {
                    Text = "Rent listings added by property owners will appear here.",
                    Font = new Font("Segoe UI", 10F),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Location = new Point(25, 75)
                });
                listingsPanel.Controls.Add(emptyPanel);
                listingsPanel.AutoScrollMinSize = new Size(0, 180);
                return;
            }

            int x = 10, y = 10;
            int cardWidth = 300, cardHeight = 360;
            int gap = 25, columns = 3, col = 0;

            foreach (var property in rentProperties)
            {
                Panel card = CreateRentCard(property);
                card.Location = new Point(x + (col * (cardWidth + gap)), y);
                listingsPanel.Controls.Add(card);
                col++;
                if (col >= columns) { col = 0; y += cardHeight + gap; }
            }

            int rows = (int)Math.Ceiling(rentProperties.Count / (double)columns);
            listingsPanel.AutoScrollMinSize = new Size(0, rows * (cardHeight + gap) + 20);
        }

        private Panel CreateRentCard(DatabaseHelper.PropertyRecord property)
        {
            Panel card = new Panel
            {
                Size = new Size(300, 360),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Image
            PictureBox imageBox = new PictureBox
            {
                Size = new Size(300, 150),
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(226, 232, 240),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            if (property.ImageData != null && property.ImageData.Length > 0)
            {
                using (var ms = new MemoryStream(property.ImageData))
                    imageBox.Image = Image.FromStream(ms);
            }
            imageBox.Controls.Add(new Label
            {
                Text = "For Rent",
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(37, 99, 235),
                AutoSize = true,
                Padding = new Padding(8, 4, 8, 4),
                Location = new Point(10, 10)
            });
            card.Controls.Add(imageBox);

            // Title
            card.Controls.Add(new Label
            {
                Text = string.IsNullOrWhiteSpace(property.Title) ? "Untitled Property" : property.Title,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(17, 24, 39),
                Location = new Point(12, 162),
                Size = new Size(275, 40),
                AutoEllipsis = true
            });

            // Location
            card.Controls.Add(new Label
            {
                Text = "📍 " + (string.IsNullOrWhiteSpace(property.Location) ? "No location" : property.Location),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(12, 205),
                Size = new Size(275, 22),
                AutoEllipsis = true
            });

            // Details
            card.Controls.Add(new Label
            {
                Text = string.IsNullOrWhiteSpace(property.Details) ? "No details provided." : property.Details,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(75, 85, 99),
                Location = new Point(12, 229),
                Size = new Size(275, 40),
                AutoEllipsis = true
            });

            // Price
            card.Controls.Add(new Label
            {
                Text = "₱" + property.Price.ToString("N0") + "/mo",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(37, 99, 235),
                Location = new Point(12, 278),
                Size = new Size(160, 28)
            });

            // Rent button
            Button rentBtn = new Button
            {
                Text = "🔑 Rent",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                BackColor = Color.FromArgb(37, 99, 235),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(100, 32),
                Location = new Point(12, 316),
                Cursor = Cursors.Hand,
                Tag = property
            };
            rentBtn.FlatAppearance.BorderSize = 0;
            rentBtn.Click += RentBtn_Click;
            card.Controls.Add(rentBtn);

            // Date
            card.Controls.Add(new Label
            {
                Text = property.DatePosted.ToString("MMM dd, yyyy"),
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.Gray,
                TextAlign = System.Drawing.ContentAlignment.MiddleRight,
                Location = new Point(160, 322),
                Size = new Size(128, 22)
            });

            return card;
        }

        private void RentBtn_Click(object sender, EventArgs e)
        {
            if (!RequireLogin()) return;

            var property = (DatabaseHelper.PropertyRecord)((Button)sender).Tag;

            var result = MessageBox.Show(
                $"Are you sure you want to rent:\n\n🏠 {property.Title}\n📍 {property.Location}\n💰 ₱{property.Price:N0}/mo",
                "Confirm Rental",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Rental request sent!");
            }
        }

        private bool RequireLogin()
        {
            if (SessionManager.IsLoggedIn)
                return true;

            MessageBox.Show(
                "You need to log in first before using this feature.",
                "Login Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            new LoginPage().Show(); // go back to login
            this.Close();
            return false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}