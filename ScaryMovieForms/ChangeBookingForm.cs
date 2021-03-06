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
        private List<Label> labels = new List<Label>();
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

            rdoShow1.Text = HelperClass.functions.GetShowTime(1);
            rdoShow2.Text = HelperClass.functions.GetShowTime(2);
            rdoShow3.Text = HelperClass.functions.GetShowTime(3);
            rdoShow4.Text = HelperClass.functions.GetShowTime(4);

            labels.Add(lblSeat1);
            labels.Add(lblSeat2);
            labels.Add(lblSeat3);
            labels.Add(lblSeat4);
            labels.Add(lblSeat5);
            labels.Add(lblSeat6);
            labels.Add(lblSeat7);
            labels.Add(lblSeat8);
            labels.Add(lblSeat9);
            labels.Add(lblSeat10);
            labels.Add(lblSeat11);
            labels.Add(lblSeat12);
            labels.Add(lblSeat13);
            labels.Add(lblSeat14);
            labels.Add(lblSeat15);
            labels.Add(lblSeat16);
            labels.Add(lblSeat17);
            labels.Add(lblSeat18);
            labels.Add(lblSeat19);
            labels.Add(lblSeat20);
            btnSaveChangesSeats.Enabled = false;
            btnSaveOnlyTickets.Enabled = false;
        }

        private void btnChangeTickets_Click(object sender, EventArgs e)
        {
            
            ResetColorOnSeat();
            rdoShow1.Visible = false;
            rdoShow2.Visible = false;
            rdoShow3.Visible = false;
            rdoShow4.Visible = false;
            cklListTickets.Visible = true;
            tlpVisualizeSeats.Visible = true;

            btnSaveOnlyTickets.Visible = true;
            btnSaveChangesSeats.Visible = false;
            btnSaveChangesSeats.Enabled = false;
            btnSaveOnlyTickets.Enabled = false;

            lblFree.Visible = true;
            lblBooked.Visible = true;
            lblGreen.Visible = true;
            lblRed.Visible = true;
            lblChoice.Visible = true;
            lblSalmon.Visible = true;
            lblScreen.Visible = true;


            int choice = BookingOverviewForm.MovieId;
            cklListTickets.Items.Clear();

            showTimeId = BookingOverviewForm.ShowTimeId;

            tlpVisualizeSeats.Visible = true;
            cklListTickets.Visible = true;

            try
            {
                foreach (var ticket in HelperClass.functions.ListTickets(choice, showTimeId))
                {

                    if (ticket.BookingId == null)
                    {
                        cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                    }
                }
                SetColorOnSeat(cklListTickets.Items);

            }
            catch (Exception)
            {

                MessageBox.Show("Could not retrieve data from database");
            }

           
        }

        private void rdoShow1_CheckedChanged(object sender, EventArgs e)
        {
            showTimeId = 1;
            ShowCorrectTicketList(showTimeId);

        }

        private void rdoShow2_CheckedChanged(object sender, EventArgs e)
        {
            showTimeId = 2;
            ShowCorrectTicketList(showTimeId);

        }

        private void rdoShow3_CheckedChanged(object sender, EventArgs e)
        {
            showTimeId = 3;
            ShowCorrectTicketList(showTimeId);
        }

        private void rdoShow4_CheckedChanged(object sender, EventArgs e)
        {
            showTimeId = 4;
            ShowCorrectTicketList(showTimeId);
        }

        private void btnChangeTime_Click(object sender, EventArgs e)
        {
            rdoShow1.Visible = true;
            rdoShow2.Visible = true;
            rdoShow3.Visible = true;
            rdoShow4.Visible = true;
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

        private void btnSaveOnlyTickets_Click(object sender, EventArgs e)
        {
            btnSaveChangesSeats.Enabled = false;
            btnSaveOnlyTickets.Enabled = false;
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

        public void SetColorOnSeat(CheckedListBox.ObjectCollection items)
        {
            foreach (var ticket in items)
            {
                foreach (var label in labels)
                {
                    if ((string)ticket == label.Text)
                    {
                        label.BackColor = Color.LightGreen;
                    }
                }
            }
        }
        public void ResetColorOnSeat()
        {
            foreach (var label in labels)
            {
                label.BackColor = Color.LightCoral;
            }
        }
        public void SetColorOnChoice(CheckedListBox.CheckedItemCollection items)
        {
            foreach (var ticket in items)
            {
                foreach (var label in labels)
                {
                    if ((string)ticket == label.Text)
                    {
                        label.BackColor = Color.LightSalmon;
                    }
                }
            }
        }

        private void cklListTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in cklListTickets.Items)
            {
                foreach (var checkedItem in cklListTickets.CheckedItems)
                {
                    if (item.ToString() == checkedItem.ToString())
                    {
                        SetColorOnSeat(cklListTickets.Items);
                    }
                }
            }

            btnSaveChangesSeats.Enabled = true;
            btnSaveOnlyTickets.Enabled = true;

            if (cklListTickets.CheckedItems.Count == 0)
            {
                SetColorOnSeat(cklListTickets.Items);
               btnSaveChangesSeats.Enabled = false;
                btnSaveOnlyTickets.Enabled = false;
            }
            SetColorOnChoice(cklListTickets.CheckedItems);

        }

        private void ShowCorrectTicketList(int showNumber)
        {
            ResetColorOnSeat();
            int choice = BookingOverviewForm.MovieId;
            cklListTickets.Items.Clear();

            tlpVisualizeSeats.Visible = true;
            cklListTickets.Visible = true;
            lblFree.Visible = true;
            lblBooked.Visible = true;
            lblSalmon.Visible = true;
            lblChoice.Visible = true;
            lblGreen.Visible = true;
            lblRed.Visible = true;
            lblScreen.Visible = true;

            foreach (var ticket in HelperClass.functions.ListTickets(choice, showNumber))
            {

                if (ticket.BookingId == null)
                {

                    cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                }
            }
            SetColorOnSeat(cklListTickets.Items);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            var overviewForm = new BookingOverviewForm();
            overviewForm.Show();
        }
    }
}
