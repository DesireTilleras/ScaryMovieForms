using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions;

namespace ScaryMovieForms
{
    public partial class NewCustomerForm : Form
    {
        public static string phoneNumber = EnterPhoneNumber.phoneNumber;
        public string firstName;
        public string lastName;

        public NewCustomerForm()
        {
            InitializeComponent();

            txtPhoneNumber.Text = phoneNumber;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            firstName = HelperClass.StringWashName(txtFirstName.Text);
            lastName = HelperClass.StringWashName(txtLastName.Text);

            HelperClass.functions.AddCustomer(phoneNumber, firstName, lastName);
             var confirmationBookingForm = new ConfirmBookingForm();
            this.Hide();
            confirmationBookingForm.Show();
        }

        private void btnGoToMenu_Click(object sender, EventArgs e)
        {
            this.Close();

            var mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                btnNext.Visible = true;
                txtFirstName.BackColor = HelperClass.ChangeBackColorName(txtFirstName.Text);
            }
            catch (Exception)
            {
                txtFirstName.BackColor = Color.LightCoral;
                btnNext.Visible = false;
            }

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                btnNext.Visible = true;
                txtLastName.BackColor = HelperClass.ChangeBackColorName(txtLastName.Text);
            }
            catch (Exception)
            {
                txtLastName.BackColor = Color.LightCoral;
                btnNext.Visible = false;
            }

        }

    }
}
