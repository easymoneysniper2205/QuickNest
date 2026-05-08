using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CustomerDashboardForm : Form
    {
        private readonly string _searchPlaceholder = "Search by location, title...";
        private readonly string _buyerEmail;
        private bool _showingTransactions = false;

        // ── Transactions button (added to nav) ──
        private Button btnMyTransactions;

        public CustomerDashboardForm(string buyerEmail)
        {
            
            InitializeComponent();
            _buyerEmail = buyerEmail;

            AddTransactionsButton();

            txtSearch.Text = _searchPlaceholder;
            txtSearch.ForeColor = Color.FromArgb(160, 160, 160);
            txtSearch.GotFocus += TxtSearch_GotFocus;
            txtSearch.LostFocus += TxtSearch_LostFocus;
            txtSearch.TextChanged += (s, e) => { if (!_showingTransactions) RefreshCards(); };

            cmbListingType.SelectedIndexChanged += (s, e) => { if (!_showingTransactions) RefreshCards(); };
            cmbPropertyType.SelectedIndexChanged += (s, e) => { if (!_showingTransactions) RefreshCards(); };

            cmbListingType.SelectedIndex = 0;
            cmbPropertyType.SelectedIndex = 0;
            RefreshCards();
        }

        private void AddTransactionsButton()
        {
            btnMyTransactions = new Button
            {
                Text = "📋 My Transactions",
                Size = new Size(150, 32),
                Location = new Point(820, 12),
                BackColor = Color.FromArgb(22, 163, 74),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnMyTransactions.FlatAppearance.BorderSize = 0;
            btnMyTransactions.Click += BtnMyTransactions_Click;
            pnlNav.Controls.Add(btnMyTransactions);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            RefreshCards();
        }

        // ── Toggle between Browse and Transactions ──
        private void BtnMyTransactions_Click(object sender, EventArgs e)
        {
            if (_showingTransactions)
            {
                // Switch back to Browse
                _showingTransactions = false;
                btnMyTransactions.Text = "📋 My Transactions";
                btnMyTransactions.BackColor = Color.FromArgb(22, 163, 74);
                lblPageTitle.Text = "Browse Properties";
                pnlFilters.Visible = true;
                RefreshCards();
            }
            else
            {
                // Switch to Transactions
                _showingTransactions = true;
                btnMyTransactions.Text = "🏠 Browse Properties";
                btnMyTransactions.BackColor = Color.FromArgb(37, 99, 235);
                lblPageTitle.Text = "My Transactions";
                pnlFilters.Visible = false;
                ShowTransactions();
            }
        }

        // ── Show Transactions View ──
        private void ShowTransactions()
        {
            pnlCards.Controls.Clear();
            pnlCards.AutoScrollPosition = new Point(0, 0);

            var transactions = DatabaseHelper.GetTransactionsByBuyer(_buyerEmail);

            lblPageSub.Text = $"{transactions.Count} transaction{(transactions.Count == 1 ? "" : "s")}";

            if (transactions.Count == 0)
            {
                pnlCards.Controls.Add(new Label
                {
                    Text = "No transactions yet. Browse and buy a property!",
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = Color.FromArgb(150, 150, 150),
                    AutoSize = true,
                    Location = new Point(12, 12)
                });
                return;
            }

            int y = 10;
            foreach (var t in transactions)
            {
                Panel card = BuildTransactionCard(t, y);
                pnlCards.Controls.Add(card);
                y += 170;
            }

            pnlCards.AutoScrollMinSize = new Size(0, y + 20);
        }

        private Panel BuildTransactionCard(DatabaseHelper.TransactionRecord t, int y)
        {
            Panel card = new Panel
            {
                Size = new Size(980, 150),
                Location = new Point(10, y),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Receipt header strip
            Panel header = new Panel
            {
                Size = new Size(980, 8),
                Location = new Point(0, 0),
                BackColor = t.PropertyType == "Rent"
                    ? Color.FromArgb(37, 99, 235)
                    : Color.FromArgb(22, 163, 74)
            };
            card.Controls.Add(header);

            // Transaction ID
            card.Controls.Add(new Label
            {
                Text = $"Transaction #{t.Id:D4}",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(100, 100, 100),
                AutoSize = true,
                Location = new Point(20, 18)
            });

            // Date
            card.Controls.Add(new Label
            {
                Text = t.DatePurchased.ToString("MMMM dd, yyyy  hh:mm tt"),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(150, 150, 150),
                AutoSize = true,
                Location = new Point(20, 38)
            });

            // Property Title
            card.Controls.Add(new Label
            {
                Text = t.PropertyTitle,
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(20, 20, 20),
                AutoSize = true,
                Location = new Point(20, 60)
            });

            // Location
            card.Controls.Add(new Label
            {
                Text = "📍 " + t.PropertyLocation,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(110, 110, 110),
                AutoSize = true,
                Location = new Point(20, 90)
            });

            // Type badge
            card.Controls.Add(new Label
            {
                Text = t.PropertyType == "Rent" ? "FOR RENT" : "FOR SALE",
                BackColor = t.PropertyType == "Rent"
                    ? Color.FromArgb(37, 99, 235)
                    : Color.FromArgb(22, 163, 74),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                AutoSize = true,
                Padding = new Padding(6, 3, 6, 3),
                Location = new Point(20, 115)
            });

            // Price (right side)
            card.Controls.Add(new Label
            {
                Text = "₱" + t.Price.ToString("N0") +
                       (t.PropertyType == "Rent" ? "/mo" : ""),
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(37, 99, 235),
                AutoSize = true,
                Location = new Point(750, 55)
            });

            // View Receipt button
            Button btnReceipt = new Button
            {
                Text = "🧾 View Receipt",
                Size = new Size(130, 32),
                Location = new Point(830, 105),
                BackColor = Color.FromArgb(37, 99, 235),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnReceipt.FlatAppearance.BorderSize = 0;
            btnReceipt.Click += (s, e) => ShowReceipt(t);
            card.Controls.Add(btnReceipt);

            return card;
        }

        private void ShowReceipt(DatabaseHelper.TransactionRecord t)
        {
            using (Form receipt = new Form())
            {
                receipt.Text = "Receipt";
                receipt.Size = new Size(480, 520);
                receipt.StartPosition = FormStartPosition.CenterParent;
                receipt.FormBorderStyle = FormBorderStyle.FixedDialog;
                receipt.BackColor = Color.White;
                receipt.MaximizeBox = false;

                // Header strip
                Panel strip = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 10,
                    BackColor = t.PropertyType == "Rent"
                        ? Color.FromArgb(37, 99, 235)
                        : Color.FromArgb(22, 163, 74)
                };
                receipt.Controls.Add(strip);

                int top = 30;

                // Logo / title
                receipt.Controls.Add(new Label
                {
                    Text = "🏠 QuickNest",
                    Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(31, 41, 55),
                    AutoSize = true,
                    Location = new Point(30, top)
                });

                top += 45;
                receipt.Controls.Add(new Label
                {
                    Text = "OFFICIAL RECEIPT",
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(100, 100, 100),
                    AutoSize = true,
                    Location = new Point(30, top)
                });

                // Divider
                top += 28;
                Panel div1 = new Panel
                {
                    Size = new Size(410, 1),
                    Location = new Point(30, top),
                    BackColor = Color.FromArgb(220, 220, 220)
                };
                receipt.Controls.Add(div1);

                top += 14;
                void AddRow(string label, string value, bool bold = false)
                {
                    receipt.Controls.Add(new Label
                    {
                        Text = label,
                        Font = new Font("Segoe UI", 9F),
                        ForeColor = Color.FromArgb(120, 120, 120),
                        AutoSize = true,
                        Location = new Point(30, top)
                    });
                    receipt.Controls.Add(new Label
                    {
                        Text = value,
                        Font = new Font("Segoe UI", 9.5F,
                            bold ? FontStyle.Bold : FontStyle.Regular),
                        ForeColor = Color.FromArgb(20, 20, 20),
                        AutoSize = true,
                        Location = new Point(220, top)
                    });
                    top += 28;
                }

                AddRow("Transaction ID:", $"#TXN-{t.Id:D4}");
                AddRow("Date:", t.DatePurchased.ToString("MMMM dd, yyyy"));
                AddRow("Time:", t.DatePurchased.ToString("hh:mm tt"));
                AddRow("Buyer Email:", t.BuyerEmail);

                top += 4;
                Panel div2 = new Panel
                {
                    Size = new Size(410, 1),
                    Location = new Point(30, top),
                    BackColor = Color.FromArgb(220, 220, 220)
                };
                receipt.Controls.Add(div2);
                top += 14;

                AddRow("Property:", t.PropertyTitle, true);
                AddRow("Location:", t.PropertyLocation);
                AddRow("Type:", t.PropertyType == "Rent" ? "For Rent" : "For Sale");

                top += 4;
                Panel div3 = new Panel
                {
                    Size = new Size(410, 1),
                    Location = new Point(30, top),
                    BackColor = Color.FromArgb(220, 220, 220)
                };
                receipt.Controls.Add(div3);
                top += 14;

                AddRow("TOTAL AMOUNT:",
                    "₱" + t.Price.ToString("N0") +
                    (t.PropertyType == "Rent" ? "/mo" : ""), true);

                top += 10;
                receipt.Controls.Add(new Label
                {
                    Text = "Thank you for using QuickNest! 🏠",
                    Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                    ForeColor = Color.FromArgb(150, 150, 150),
                    AutoSize = true,
                    Location = new Point(30, top)
                });

                top += 35;
                Button btnClose = new Button
                {
                    Text = "Close",
                    Size = new Size(120, 36),
                    Location = new Point(320, top),
                    BackColor = Color.FromArgb(37, 99, 235),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
                btnClose.FlatAppearance.BorderSize = 0;
                btnClose.Click += (s, e) => receipt.Close();
                receipt.Controls.Add(btnClose);

                receipt.ShowDialog(this);
            }
        }

        // ── Browse Properties ──
        private void RefreshCards()
        {
            
            pnlCards.Controls.Clear();
            pnlCards.AutoScrollPosition = new Point(0, 0);

            string searchText = txtSearch.Text == _searchPlaceholder
                ? ""
                : txtSearch.Text.Trim().ToLower();

            string listingFilter = cmbListingType.SelectedItem?.ToString() ?? "All";
            string propertyFilter = cmbPropertyType.SelectedItem?.ToString() ?? "All Types";

            var publicProps = DatabaseHelper.GetAllPropertiesAdmin()
                .Where(p => p.IsPublic)
                .Where(p => string.IsNullOrEmpty(searchText) ||
                            p.Title.ToLower().Contains(searchText) ||
                            p.Location.ToLower().Contains(searchText))
                .Where(p => listingFilter == "All" ||
                            (listingFilter == "For Rent" && p.PropertyType == "Rent") ||
                            (listingFilter == "For Sale" && p.PropertyType == "Sale"))
                .Where(p => propertyFilter == "All Types" ||
            p.Category.Trim().ToLower() == propertyFilter.Trim().ToLower())
                .Where(p => p.Price <= trkPrice.Value)
                .ToList();
            

            lblPageSub.Text = $"{publicProps.Count} propert{(publicProps.Count == 1 ? "y" : "ies")} available";

            if (publicProps.Count == 0)
            {
                pnlCards.Controls.Add(new Label
                {
                    Text = "No properties found.",
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = Color.FromArgb(150, 150, 150),
                    AutoSize = true,
                    Location = new Point(12, 12)
                });
                pnlCards.AutoScrollMinSize = new Size(0, 0);
                return;
            }

            int cardW = 318, cardH = 320, gap = 28, col = 0, row = 0, columns = 3;

            Color[] colors =
            {
                Color.FromArgb(226, 232, 240),
                Color.FromArgb(30, 41, 59),
                Color.FromArgb(199, 210, 224),
                Color.FromArgb(209, 231, 221),
                Color.FromArgb(255, 243, 205),
                Color.FromArgb(237, 211, 255)
            };

            for (int i = 0; i < publicProps.Count; i++)
            {
                pnlCards.Controls.Add(BuildCustomerCard(
                    publicProps[i],
                    col * (cardW + gap),
                    row * (cardH + gap),
                    cardW, cardH,
                    colors[i % colors.Length]));

                col++;
                if (col >= columns) { col = 0; row++; }
            }

            int rows = (int)Math.Ceiling(publicProps.Count / (double)columns);
            pnlCards.AutoScrollMinSize = new Size(0, rows * (cardH + gap));
        }

        private Panel BuildCustomerCard(
            DatabaseHelper.PropertyRecord prop,
            int x, int y, int cardW, int cardH, Color imgBg)
        {
            Panel card = new Panel
            {
                Size = new Size(cardW, cardH),
                Location = new Point(x, y),
                BackColor = Color.White
            };

            // Image panel
            Panel imgPanel = new Panel
            {
                Size = new Size(cardW, 150),
                Location = new Point(0, 0),
                BackColor = imgBg
            };

            if (prop.ImageData != null && prop.ImageData.Length > 0)
            {
                PictureBox pb = new PictureBox
                {
                    Size = new Size(cardW, 150),
                    Location = new Point(0, 0),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                using (var ms = new MemoryStream(prop.ImageData))
                    pb.Image = Image.FromStream(ms);
                imgPanel.Controls.Add(pb);
            }

            imgPanel.Controls.Add(new Label
            {
                Text = prop.PropertyType == "Rent" ? "For Rent" : "For Sale",
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = prop.PropertyType == "Rent"
                    ? Color.FromArgb(37, 99, 235)
                    : Color.FromArgb(22, 163, 74),
                AutoSize = true,
                Location = new Point(10, 10),
                Padding = new Padding(6, 3, 6, 3)
            });

            card.Controls.Add(imgPanel);

            card.Controls.Add(new Label
            {
                Text = prop.Title,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(20, 20, 20),
                Size = new Size(cardW - 24, 40),
                Location = new Point(12, 158)
            });

            card.Controls.Add(new Label
            {
                Text = "📍 " + prop.Location,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(110, 110, 110),
                AutoSize = true,
                Location = new Point(12, 200)
            });

            card.Controls.Add(new Label
            {
                Text = prop.Details,
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(130, 130, 130),
                Size = new Size(cardW - 24, 30),
                Location = new Point(12, 220)
            });

            card.Controls.Add(new Label
            {
                Text = "₱" + prop.Price.ToString("N0") +
                       (prop.PropertyType == "Rent" ? "/mo" : ""),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(37, 99, 235),
                AutoSize = true,
                Location = new Point(12, 252)
            });

            // Buy/Rent button
            Button btnBuy = new Button
            {
                Text = prop.PropertyType == "Rent" ? "🏠 Rent Now" : "🏠 Buy Now",
                Size = new Size(cardW - 24, 34),
                Location = new Point(12, 278),
                BackColor = prop.PropertyType == "Rent"
                    ? Color.FromArgb(37, 99, 235)
                    : Color.FromArgb(22, 163, 74),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.Click += (s, e) => ConfirmPurchase(prop);
            card.Controls.Add(btnBuy);

            return card;
        }

        private void ConfirmPurchase(DatabaseHelper.PropertyRecord prop)
        {
            string action = prop.PropertyType == "Rent" ? "Rent" : "Buy";
            string price = "₱" + prop.Price.ToString("N0") +
                           (prop.PropertyType == "Rent" ? "/mo" : "");

            var result = MessageBox.Show(
                $"Confirm {action}?\n\n" +
                $"Property: {prop.Title}\n" +
                $"Location: {prop.Location}\n" +
                $"Price: {price}\n\n" +
                $"Do you want to proceed?",
                $"Confirm {action}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DatabaseHelper.AddTransaction(
                    _buyerEmail,
                    prop.OwnerEmail,
                    prop.Id,
                    prop.Title,
                    prop.Location,
                    prop.Price,
                    prop.PropertyType);

                MessageBox.Show(
                    $"✅ Success! Your transaction has been recorded.\n" +
                    $"Go to 'My Transactions' to view your receipt.",
                    "Transaction Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void TxtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == _searchPlaceholder)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void TxtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = _searchPlaceholder;
                txtSearch.ForeColor = Color.FromArgb(160, 160, 160);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to log out?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                OwnerDashBoard.CurrentOwnerEmail = null;
                SessionManager.IsLoggedIn = false;
                new LoginPage().Show();
                this.Close();
            }
        }

        private void trkPrice_Scroll(object sender, EventArgs e)
        {
            int val = trkPrice.Value;
            lblMaxPrice.Text = val >= 1_000_000
                ? $"Max Price: ₱{val / 1_000_000.0:0.#}M"
                : $"Max Price: ₱{val:N0}";
            RefreshCards();
        }

        private void pnlNav_Paint(object sender, PaintEventArgs e) { }
        private void pnlCards_Paint(object sender, PaintEventArgs e) { }
        private void pnlBody_Paint(object sender, PaintEventArgs e) { }
    }
}