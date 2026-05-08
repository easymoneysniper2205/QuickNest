using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BuyForm : Form
    {
        public BuyForm()
        {
            InitializeComponent();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            
            LoadBuyProperties();
        }

        private void LoadBuyProperties()
        {
            listingsPanel.Controls.Clear();
            listingsPanel.AutoScrollPosition = new Point(0, 0);

            var saleProperties = DatabaseHelper.GetPublicProperties("Sale");

            var saleList = saleProperties ?? new System.Collections.Generic.List<DatabaseHelper.PropertyRecord>();

            lblCount.Text = $"{saleList.Count} propert{(saleList.Count == 1 ? "y" : "ies")} available for sale";

            if (saleList.Count == 0)
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
                    Text = "No properties for sale yet.",
                    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(55, 65, 81),
                    AutoSize = true,
                    Location = new Point(25, 35)
                });

                emptyPanel.Controls.Add(new Label
                {
                    Text = "Sale listings added by property owners will appear here.",
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

            foreach (var property in saleProperties)
            {
                Panel card = CreateBuyCard(property);

                card.Location = new Point(x + (col * (cardWidth + gap)), y);
                listingsPanel.Controls.Add(card);

                col++;
                if (col >= columns)
                {
                    col = 0;
                    y += cardHeight + gap;
                }
            }

            int rows = (int)Math.Ceiling(saleProperties.Count / (double)columns);
            listingsPanel.AutoScrollMinSize = new Size(0, rows * (cardHeight + gap) + 20);
        }

   
        private Panel CreateBuyCard(DatabaseHelper.PropertyRecord property)
        {
            Panel card = new Panel
            {
                Size = new Size(300, 360),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // IMAGE
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
                Text = "For Sale",
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(22, 163, 74),
                AutoSize = true,
                Padding = new Padding(8, 4, 8, 4),
                Location = new Point(10, 10)
            });

            card.Controls.Add(imageBox);

            // TITLE
            card.Controls.Add(new Label
            {
                Text = string.IsNullOrWhiteSpace(property.Title) ? "Untitled Property" : property.Title,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(17, 24, 39),
                Location = new Point(12, 162),
                Size = new Size(275, 40),
                AutoEllipsis = true
            });

            // LOCATION
            card.Controls.Add(new Label
            {
                Text = "📍 " + (string.IsNullOrWhiteSpace(property.Location) ? "No location" : property.Location),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(12, 205),
                Size = new Size(275, 22),
                AutoEllipsis = true
            });

            // DETAILS
            card.Controls.Add(new Label
            {
                Text = string.IsNullOrWhiteSpace(property.Details) ? "No details provided." : property.Details,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(75, 85, 99),
                Location = new Point(12, 229),
                Size = new Size(275, 40),
                AutoEllipsis = true
            });

            // PRICE (NO /MO)
            card.Controls.Add(new Label
            {
                Text = "₱" + property.Price.ToString("N0"),
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(22, 163, 74),
                Location = new Point(12, 278),
                Size = new Size(160, 28)
            });

            // BUY BUTTON
            Button buyBtn = new Button
            {
                Text = "🛒 Buy",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                BackColor = Color.FromArgb(22, 163, 74),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(100, 32),
                Location = new Point(12, 316),
                Cursor = Cursors.Hand,
                Tag = property
            };

            buyBtn.FlatAppearance.BorderSize = 0;
            buyBtn.Click += BuyBtn_Click;

            card.Controls.Add(buyBtn);

            // DATE (SAME AS RENTFORM)
            card.Controls.Add(new Label
            {
                Text = property.DatePosted.ToString("MMM dd, yyyy"),
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleRight,
                Location = new Point(160, 322),
                Size = new Size(128, 22)
            });

            return card;
        }

        
        private void BuyBtn_Click(object sender, EventArgs e)
        {
            if (!RequireLogin())
                return;
            var property = (DatabaseHelper.PropertyRecord)((Button)sender).Tag;

            var result = MessageBox.Show(
                $"Are you sure you want to buy:\n\n🏠 {property.Title}\n📍 {property.Location}\n💰 ₱{property.Price:N0}",
                "Confirm Purchase",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Purchase request sent for \"{property.Title}\"!",
                    "Request Sent ✅",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private bool RequireLogin()
        {
            if (SessionManager.IsLoggedIn)
                return true;

            MessageBox.Show(
                "You need to log in first before you are able to do this.",
                "Login Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            new LoginPage().Show(); 
            this.Close();
            return false;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}