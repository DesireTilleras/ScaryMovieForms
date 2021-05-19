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
    public partial class EnterPhoneNumber : Form
    {
        public static string phoneNumber;
        public EnterPhoneNumber()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            phoneNumber = HelperClass.StringWashPhone(txtPhoneNumber.Text);

            if (!HelperClass.functions.CustomerExists(phoneNumber))
            {

                var newCustomerForm = new NewCustomerForm();
                this.Hide();
                newCustomerForm.Show();

            }
            else
            {
                var confirmationBookingForm = new ConfirmBookingForm();
                this.Hide();
                confirmationBookingForm.Show();                
            };
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();

            var mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                btnNext.Visible = true;
                txtPhoneNumber.BackColor = HelperClass.ChangeBackColorPhone(txtPhoneNumber.Text);
            }
            catch (Exception)
            {
                btnNext.Visible = false;
                txtPhoneNumber.BackColor = Color.LightCoral;
            }

        }
    }
}
