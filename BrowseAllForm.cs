using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BrowseAllForm : Form
    {
        public BrowseAllForm()
        {
            InitializeComponent();
            cmbCategoryFilter.SelectedIndex = 0;
        }

        private void BrowseAllForm_Load(object sender, EventArgs e)
        {
            LoadAllProperties();
        }

        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllProperties();
        }

        private void LoadAllProperties()
        {
            propertiesPanel.Controls.Clear();
            propertiesPanel.AutoScroll = true;

            var allProperties = DatabaseHelper.GetAllPropertiesAdmin()
                .OrderByDescending(p => p.DatePosted)
                .ToList();

            int houseCount = allProperties.Count(p => p.Category.Trim() == "House");
            int condoCount = allProperties.Count(p => p.Category.Trim() == "Condo");
            int apartmentCount = allProperties.Count(p => p.Category.Trim() == "Apartment");
            int villaCount = allProperties.Count(p => p.Category.Trim() == "Villa");
            int landCount = allProperties.Count(p => p.Category.Trim() == "Land");

            labelHouseListings.Text = houseCount + " listings";
            labelCondoListings.Text = condoCount + " listings";
            labelApartmentListings.Text = apartmentCount + " listings";
            labelVillaListings.Text = villaCount + " listings";
            labelLandListings.Text = landCount + " listings";

            string selectedCategory = cmbCategoryFilter.SelectedItem?.ToString() ?? "All";

            var properties = selectedCategory == "All"
                ? allProperties
                : allProperties.Where(p => p.Category.Trim() == selectedCategory).ToList();

            labelFeaturedSub.Text = properties.Count + " properties available";

            if (properties.Count == 0)
            {
                propertiesPanel.Controls.Add(new Label
                {
                    Text = "No properties available.",
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(20, 20)
                });
                return;
            }

            int x = 10, y = 10, col = 0;

            foreach (var property in properties)
            {
                Panel card = CreatePropertyCard(property);
                card.Location = new Point(x + col * 330, y);
                propertiesPanel.Controls.Add(card);
                col++;
                if (col >= 3) { col = 0; y += 340; }
            }

            int rows = (int)Math.Ceiling(properties.Count / 3.0);
            propertiesPanel.AutoScrollMinSize = new Size(0, rows * 340 + 20);
        }

        private Panel CreatePropertyCard(DatabaseHelper.PropertyRecord property)
        {
            Panel card = new Panel
            {
                Size = new Size(310, 320),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            PictureBox img = new PictureBox
            {
                Size = new Size(310, 150),
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.LightGray
            };

            if (property.ImageData != null && property.ImageData.Length > 0)
            {
                using (var ms = new MemoryStream(property.ImageData))
                    img.Image = Image.FromStream(ms);
            }

            card.Controls.Add(img);

            card.Controls.Add(new Label
            {
                Text = string.IsNullOrWhiteSpace(property.Title) ? "Untitled Property" : property.Title,
                Location = new Point(10, 160),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            });

            card.Controls.Add(new Label
            {
                Text = "📍 " + (string.IsNullOrWhiteSpace(property.Location) ? "No location" : property.Location),
                Location = new Point(10, 185),
                AutoSize = true,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 8.5F)
            });

            card.Controls.Add(new Label
            {
                Text = "₱" + property.Price.ToString("N0"),
                Location = new Point(10, 210),
                AutoSize = true,
                ForeColor = Color.Blue,
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            });

            card.Controls.Add(new Label
            {
                Text = property.Category,
                Location = new Point(10, 238),
                AutoSize = true,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 8.5F)
            });

            card.Controls.Add(new Label
            {
                Text = property.PropertyType == "Rent" ? "FOR RENT" : "FOR SALE",
                BackColor = property.PropertyType == "Rent"
                    ? Color.FromArgb(37, 99, 235)
                    : Color.FromArgb(22, 163, 74),
                ForeColor = Color.White,
                AutoSize = true,
                Padding = new Padding(6),
                Location = new Point(10, 260)
            });

            return card;
        }

        private void labelApartment_Click(object sender, EventArgs e) { }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}