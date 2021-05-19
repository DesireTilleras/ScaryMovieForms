using Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaryMovieForms
{
    public partial class ShowBookingsEnterNumberForm : Form
    {

        public static string phoneNumberBookings;
        public ShowBookingsEnterNumberForm()
        {
            InitializeComponent();

            
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            var mainMenuForm = new MainMenuForm();
            this.Hide();
            mainMenuForm.Show();
        }

        private void btnShowBookings_Click(object sender, EventArgs e)
        {
            try
            {
                phoneNumberBookings = HelperClass.StringWashPhone(txtPhoneNumberBookings.Text);

                var showBookingsForm = new BookingOverviewForm();
                this.Hide();
                showBookingsForm.Show();

            }
            catch (Exception)
            {

                MessageBox.Show("It appears that you do not have any bookings registered on this phone number" +
                    " You will now enter the main menu");

                var mainMenu = new MainMenuForm();
                this.Hide();
                mainMenu.Show();
            }
           
        }

        private void txtPhoneNumberBookings_TextChanged(object sender, EventArgs e)
        {
            try
            {
                btnShowBookings.Visible = true;
                txtPhoneNumberBookings.BackColor = HelperClass.ChangeBackColorPhone(txtPhoneNumberBookings.Text);
            }
            catch (Exception)
            {
                btnShowBookings.Visible = false;
                txtPhoneNumberBookings.BackColor = Color.LightCoral;
            }
        }
    }
}
