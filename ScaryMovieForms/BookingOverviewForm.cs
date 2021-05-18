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

                cklBookingList.Items.Add(booking.Id.ToString(), CheckState.Unchecked);

                lstShowBookingInfo.Items.Add(line);

            }
        }
        private void btnChangeBooking_Click(object sender, EventArgs e)
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
    }
}
