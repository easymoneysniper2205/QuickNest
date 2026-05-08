using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            BuyForm buyForm = new BuyForm();

            // Option 1: Show the form (can interact with both forms)
             buyForm.Show();

             this.Hide();

            // Option 3: Show as modal dialog (must close BuyForm first)
            //buyForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginPage lpf = new LoginPage();

            lpf.Show();

            this.Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            RentForm rf = new RentForm();

            rf.Show();

            this.Hide();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();

            su.Show();

            this.Hide();
        }

        private void BrowseAllBtn_Click(object sender, EventArgs e)
        {
            BrowseAllForm baf = new BrowseAllForm();

            baf.Show();

            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
