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
        private int showTimeId;
        private int oldShowTimeId;
        private int movieId;
        private List<int> OldSeats = new List<int>();
        private List<int> NewSeats = new List<int>();
        public ChangeBookingForm()
        {
            InitializeComponent();


            txtMovieTitle.Text = BookingOverviewForm.MovieTitle;
            txtTime.Text = BookingOverviewForm.ShowTime;

            lstCurrentTickets.Visible = true;

            lstCurrentTickets.DataSource = BookingOverviewForm.TicketList;
            OldSeats = BookingOverviewForm.TicketList;

            showTimeId = BookingOverviewForm.ShowTimeId;
            oldShowTimeId = BookingOverviewForm.ShowTimeId;
            movieId = BookingOverviewForm.MovieId;

        }

        private void btnChangeTickets_Click(object sender, EventArgs e)
        {
            rdoShow1.Visible = false;
            rdoShow2.Visible = false;
            rdoShow3.Visible = false;
            rdoShow4.Visible = false;
            cklListTickets.Visible = true;
            tlpVisualizeSeats.Visible = true;

            btnSaveOnlyTickets.Visible = true;
            btnSaveChangesSeats.Visible = false;

            int choice = BookingOverviewForm.MovieId;
            cklListTickets.Items.Clear();

            showTimeId = BookingOverviewForm.ShowTimeId;

            tlpVisualizeSeats.Visible = true;
            cklListTickets.Visible = true;

            foreach (var ticket in HelperClass.functions.ListTickets(choice, showTimeId))
            {

                if (ticket.BookingId == null)
                {
                    cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                }
            }

           
        }

        private void ChangeBookingForm_Load(object sender, EventArgs e)
        {

           
        }

        private void rdoShow1_CheckedChanged(object sender, EventArgs e)
        {
            int choice = BookingOverviewForm.MovieId;
            cklListTickets.Items.Clear();

            showTimeId = 1;

            tlpVisualizeSeats.Visible = true;
            cklListTickets.Visible = true;

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
            cklListTickets.Items.Clear();

            showTimeId = 2;

            tlpVisualizeSeats.Visible = true;
            cklListTickets.Visible = true;

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

            cklListTickets.Items.Clear();

            showTimeId = 3;

            tlpVisualizeSeats.Visible = true;
            cklListTickets.Visible = true;

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
            cklListTickets.Items.Clear();

            showTimeId = 4;

            tlpVisualizeSeats.Visible = true;
            cklListTickets.Visible = true;

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
            cklListTickets.Visible = true;
            btnSaveOnlyTickets.Visible = false;
            btnSaveChangesSeats.Visible = true;
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

            List<int> oldSeats = new List<int>();

            foreach (var oldSeat in OldSeats)
            {
                oldSeats.Add(oldSeat);
            }

            HelperClass.functions.ChangeTicketsOnBooking(movieId, oldSeats, oldShowTimeId, NewSeats, showTimeId);

            MessageBox.Show("The tickets are now changed! You will now automatically go back to main menu");

            var mainMenu = new MainMenuForm();
            this.Hide();
            mainMenu.Show();
           

        }

        private void cklListTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnSaveOnlyTickets_Click(object sender, EventArgs e)
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

            List<int> oldSeats = new List<int>();

            foreach (var oldSeat in OldSeats)
            {
                oldSeats.Add(oldSeat);
            }

            HelperClass.functions.ChangeOnlySeatsOnBooking(movieId, oldSeats, oldShowTimeId, NewSeats);

            MessageBox.Show("The tickets are now changed! You will now automatically go back to main menu");

            var mainMenu = new MainMenuForm();
            this.Hide();
            mainMenu.Show();
        }

        private void btnGoBackMenu_Click(object sender, EventArgs e)
        {
            var mainMenuForm = new MainMenuForm();
            this.Hide();
            mainMenuForm.Show();
        }
    }
}
