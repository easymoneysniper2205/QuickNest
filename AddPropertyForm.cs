using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AddPropertyForm : Form
    {
        private OpenFileDialog openFileDialog;
        private byte[] selectedImageData;

        public AddPropertyForm()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
        }

        private void InitializeOpenFileDialog()
        {
            openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select Property Image"
            };
        }

        private void BtnBrowseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image originalImage = Image.FromFile(openFileDialog.FileName);
                    picPropertyImage.Image = originalImage;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        originalImage.Save(ms, originalImage.RawFormat);
                        selectedImageData = ms.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a property title.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the property location.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than 0.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDetails.Text))
            {
                MessageBox.Show("Please enter property details.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDetails.Focus();
                return;
            }
            if (selectedImageData == null)
            {
                DialogResult result = MessageBox.Show(
                    "No image selected. Do you want to continue without an image?",
                    "Image Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
            }

            // Save to database
            DatabaseHelper.AddProperty(
            _ownerEmail, 
            txtTitle.Text.Trim(),
            txtDetails.Text.Trim(),
            (double)price,
            txtLocation.Text.Trim(),
            cmbPropertyType.Text,
            cmbCategory.Text,
            selectedImageData
            );

            MessageBox.Show("Property added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e) => this.Close();

        private void AddPropertyForm_Load(object sender, EventArgs e) { }

        private readonly string _ownerEmail;

        public AddPropertyForm(string ownerEmail)
        {
            InitializeComponent();
            InitializeOpenFileDialog();
            _ownerEmail = ownerEmail; 
        }
    }
}