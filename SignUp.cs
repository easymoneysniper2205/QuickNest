using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                MessageBox.Show("Please enter your full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter your email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxPassword.Text != textBoxConfirmPasswordField.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!radioBuyerRenter.Checked && !radioAgentOwner.Checked)
            {
                MessageBox.Show("Please select whether you are a Buyer/Renter or Agent/Owner.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userType = radioBuyerRenter.Checked ? "Buyer/Renter" : "Agent/Owner";

            bool success = DatabaseHelper.RegisterUser(
                textBoxFullName.Text.Trim(),
                textBoxEmail.Text.Trim(),
                textBoxPassword.Text,
                userType);

            if (!success)
            {
                MessageBox.Show("Email already registered. Please use a different email or login.",
                    "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                $"Account created successfully!\n\nName: {textBoxFullName.Text}\nEmail: {textBoxEmail.Text}\nUser Type: {userType}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            LoginPage loginForm = new LoginPage();
            loginForm.ShowDialog();
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                btnShowPassword.Text = "🙈";
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                btnShowPassword.Text = "👁";
            }
        }

        private void BtnShowConfirmPassword_Click(object sender, EventArgs e)
        {
            if (textBoxConfirmPasswordField.UseSystemPasswordChar)
            {
                textBoxConfirmPasswordField.UseSystemPasswordChar = false;
                btnShowConfirmPassword.Text = "🙈";
            }
            else
            {
                textBoxConfirmPasswordField.UseSystemPasswordChar = true;
                btnShowConfirmPassword.Text = "👁";
            }
        }

        private void SignUp_Load(object sender, EventArgs e) { }
    }
}