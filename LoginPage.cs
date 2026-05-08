using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LoginPage : Form
    {
        public class UserInfo
        {
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string UserRole { get; set; }
        }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPass.Text;
            

            if (!ValidateLoginInput(email, password)) return;

            if (IsAdminLogin(email, password))
            {
                MessageBox.Show("Welcome, Admin!", "Login Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenForm(new AdminDashboardForm());
                return;
            }

            UserInfo user = DatabaseHelper.GetUserByEmail(email);

            if (user == null)
            {
                MessageBox.Show("Email not found. Please sign up first.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user.Password != password)
            {
                MessageBox.Show("Incorrect password. Please try again.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPass.Clear();
                textBoxPass.Focus();
                return;
            }

            MessageBox.Show($"Hello, {user.FullName}!", "Login Successful",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenDashboardByRole(user);
        }

        private bool ValidateLoginInput(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.",
                    "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return false;
            }
            return true;
        }

        private bool IsAdminLogin(string email, string password)
        {
            return email.Equals("admin@gmail.com", StringComparison.OrdinalIgnoreCase)
                   && password == "Admin123";
        }

        private void OpenDashboardByRole(UserInfo user)
        {
            
            if (user.UserRole == "Buyer/Renter")
            {
                SessionManager.IsLoggedIn = true;
                OpenForm(new CustomerDashboardForm(user.Email));
                return;
            }

            if (user.UserRole == "Agent/Owner")
            {
                // Set email BEFORE creating the form
                OwnerDashBoard.CurrentOwnerEmail = user.Email;
                OpenForm(new OwnerDashBoard(user.Email));
                return;
            }

            MessageBox.Show("Invalid user role.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OpenForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e) => OpenForm(new Form1());

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = !textBoxPass.UseSystemPasswordChar;
            btnShowPassword.Text = textBoxPass.UseSystemPasswordChar ? "👁" : "🙈";
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (SignUp signUp = new SignUp())
                signUp.ShowDialog();
            this.Show();
            textBoxEmail.Focus();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
            btnShowPassword.Text = "👁";
        }
    }
}