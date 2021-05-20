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
    public partial class BookingOverviewForm : Form
    {

        internal static string MovieTitle;
        internal static int MovieId;
        internal static string ShowTime;
        internal static int ShowTimeId;
        internal static List<int> TicketList = new List<int>();
              
        public BookingOverviewForm()
        {
            InitializeComponent();

          
            foreach (var booking in HelperClass.functions.ListOfCustomerBookings(ShowBookingsEnterNumberForm.phoneNumberBookings))
            {
                
                string line = $"Movie title: {HelperClass.functions.GetMovieTitle(booking.MovieId)}    Amount of seats: " +
                    $"{HelperClass.functions.AmountOfTicketOneBooking(booking.Id)}" +
                    $"    Time : {HelperClass.functions.DisplayShowTimeInOverview(booking.Id)}   Bokking ID : {booking.Id}";

                lblCustomerName.Text = HelperClass.functions.GetCustomerName(booking.Id);

                cklBookingList.Items.Add(booking.Id.ToString(), CheckState.Unchecked);

                lstShowBookingInfo.Items.Add(line);

            }
        }
        private void btnChangeBooking_Click(object sender, EventArgs e)
        {
            try
            {
                var stringList = cklBookingList.CheckedItems.Cast<string>().ToList();

                TicketList.Clear();

                var bookingNumberList = new List<int>();

                foreach (var number in stringList)
                {
                    bookingNumberList.Add(Int32.Parse(number));
                }

                foreach (var bookingId in bookingNumberList)
                {
                    MovieTitle = HelperClass.functions.MovieTitleFromBookingId(bookingId);
                    MovieId = HelperClass.functions.GetMovieId(MovieTitle);
                    ShowTime = HelperClass.functions.DisplayShowTimeInOverview(bookingId);
                    ShowTimeId = HelperClass.functions.DisplayShowTimeId(bookingId);

                    foreach (var ticket in HelperClass.functions.ListOfTicketsOneBooking(bookingId))
                    {
                        TicketList.Add((int)ticket);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Could not retrieve data from database");
            }
            

            var changeBookingForm = new ChangeBookingForm();
            this.Hide();
            changeBookingForm.Show();
        }

        private void cklBookingList_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < cklBookingList.Items.Count; ++ix)
                    if (e.Index != ix) cklBookingList.SetItemChecked(ix, false);
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            try
            {               
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this booking?", "Delete booking", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var stringList = cklBookingList.CheckedItems.Cast<string>().ToList();

                    TicketList.Clear();

                    var bookingNumberList = new List<int>();

                    foreach (var number in stringList)
                    {
                        bookingNumberList.Add(Int32.Parse(number));
                    }
                    foreach (var bookingId in bookingNumberList)
                    {
                        HelperClass.functions.DeleteBooking(bookingId);
                    }

                    MessageBox.Show("The booking is now deleted, you will automatically go back to main menu");
                    var mainMenuForm = new MainMenuForm();
                    this.Hide();
                    mainMenuForm.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    var changeBookingForm = new BookingOverviewForm();
                    this.Hide();
                    changeBookingForm.Show();
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("");
            }
            
        }

        private void btnGoBackMenu_Click(object sender, EventArgs e)
        {
            var mainMenuForm = new MainMenuForm();
            this.Hide();
            mainMenuForm.Show();
        }

        private void cklBookingList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cklBookingList.CheckedItems.Count == 0)
            {
                btnChangeBooking.Enabled = false;
                btnDeleteBooking.Enabled = false;
            }
            if (cklBookingList.CheckedItems.Count != 0)
            {
                btnChangeBooking.Enabled = true;
                btnDeleteBooking.Enabled = true;
            }
        }
    }
}
