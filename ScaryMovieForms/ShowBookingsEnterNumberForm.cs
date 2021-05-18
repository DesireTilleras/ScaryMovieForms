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
            phoneNumberBookings = txtPhoneNumberBookings.Text;

            var showBookingsForm = new BookingOverviewForm();
            this.Hide();
            showBookingsForm.Show();
        }
    }
}
