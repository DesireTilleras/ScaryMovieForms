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
    public partial class ChangeBookingForm : Form
    {
        public int showTimeId;
        public List<int> OldSeats = new List<int>();
        public List<int> NewSeats = new List<int>();
        public ChangeBookingForm()
        {
            InitializeComponent();


            txtMovieTitle.Text = BookingOverviewForm.MovieTitle;
            txtTime.Text = BookingOverviewForm.ShowTime;

            lstCurrentTickets.DataSource = BookingOverviewForm.TicketList;

        }

        private void btnChangeTickets_Click(object sender, EventArgs e)
        {
            cklListTickets.Visible = true;
            tlpVisualizeSeats.Visible = true;
        }

        private void ChangeBookingForm_Load(object sender, EventArgs e)
        {

            int choice = BookingOverviewForm.MovieId;

           showTimeId = BookingOverviewForm.ShowTimeId;

            tlpVisualizeSeats.Visible = true;

            foreach (var ticket in HelperClass.functions.ListTickets(choice, showTimeId))
            {

                if (ticket.BookingId == null)
                {

                    cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                }
            }
        }

        private void rdoShow1_CheckedChanged(object sender, EventArgs e)
        {
            int choice = BookingOverviewForm.MovieId;

            showTimeId = 1;

            tlpVisualizeSeats.Visible = true;

            foreach (var ticket in HelperClass.functions.ListTickets(choice, showTimeId))
            {

                if (ticket.BookingId == null)
                {

                    cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                }
            }
        }

        private void rdoShow2_CheckedChanged(object sender, EventArgs e)
        {
            int choice = BookingOverviewForm.MovieId;

            showTimeId = 2;

            tlpVisualizeSeats.Visible = true;

            foreach (var ticket in HelperClass.functions.ListTickets(choice, showTimeId))
            {

                if (ticket.BookingId == null)
                {

                    cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                }
            }

        }

        private void rdoShow3_CheckedChanged(object sender, EventArgs e)
        {
            int choice = BookingOverviewForm.MovieId;

            showTimeId = 3;

            tlpVisualizeSeats.Visible = true;

            foreach (var ticket in HelperClass.functions.ListTickets(choice, showTimeId))
            {

                if (ticket.BookingId == null)
                {

                    cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                }
            }
        }

        private void rdoShow4_CheckedChanged(object sender, EventArgs e)
        {
            int choice = BookingOverviewForm.MovieId;

            showTimeId = 4;

            tlpVisualizeSeats.Visible = true;

            foreach (var ticket in HelperClass.functions.ListTickets(choice, showTimeId))
            {

                if (ticket.BookingId == null)
                {

                    cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                }
            }
        }

        private void btnChangeTime_Click(object sender, EventArgs e)
        {
            rdoShow1.Visible = true;
            rdoShow2.Visible = true;
            rdoShow3.Visible = true;
            rdoShow4.Visible = true;
        }

        private void btnSaveChangesSeats_Click(object sender, EventArgs e)
        {

            NewSeats.Clear();

            var stringList = cklListTickets.CheckedItems.Cast<string>().ToList();

            var intList = new List<int>();

            foreach (var number in stringList)
            {
                intList.Add(Int32.Parse(number));
            }

            foreach (var indexChecked in intList)
            {
                NewSeats.Add((int)indexChecked);
            }

            btnBooked.Visible = true;
        }
    }
}
