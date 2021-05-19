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
    
    public partial class MovieForm : Form
    {
        public static List<int> BookedTickets = new List<int>();

        public static int showTime;
        public MovieForm()
        {
            InitializeComponent();

            rdoShow1.Text = HelperClass.functions.GetShowTime(1);
            rdoShow2.Text = HelperClass.functions.GetShowTime(2);
            rdoShow3.Text = HelperClass.functions.GetShowTime(3);
            rdoShow4.Text = HelperClass.functions.GetShowTime(4);

        }

        private void rdoShow1_CheckedChanged(object sender, EventArgs e)
        {
           int choice = MainMenuForm.MovieChoice;
            cklListTickets.Items.Clear();

            showTime = 1;

            tlpVisualizeSeats.Visible = true;
 
            foreach (var ticket in HelperClass.functions.ListTickets(choice, showTime))
            {
                
                if (ticket.BookingId == null)
                {
                  
                    cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                }
            }
        }

        private void btnBooked_Click(object sender, EventArgs e)
        {
            var enterPhoneNumberForm = new EnterPhoneNumber();
            this.Hide();
            enterPhoneNumberForm.Show();         
        }

        private void btnCheckSeatList_Click(object sender, EventArgs e)
        {
            BookedTickets.Clear();

            var stringList = cklListTickets.CheckedItems.Cast<string>().ToList();

            var intList = new List<int>();

            foreach (var number in stringList)
            {
                intList.Add(Int32.Parse(number));
            }

            foreach (var indexChecked in intList)
            {
                BookedTickets.Add((int)indexChecked);
            }

            btnBooked.Visible = true;
        }

        private void rdoShow2_CheckedChanged(object sender, EventArgs e)
        {

            int choice = MainMenuForm.MovieChoice;

            cklListTickets.Items.Clear();

            showTime = 2;

            tlpVisualizeSeats.Visible = true;

            foreach (var ticket in HelperClass.functions.ListTickets(choice, showTime))
            {

                if (ticket.BookingId == null)
                {

                    cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                }
            }
        }

        private void rdoShow3_CheckedChanged(object sender, EventArgs e)
        {
            int choice = MainMenuForm.MovieChoice;
            cklListTickets.Items.Clear();

            showTime = 3;

            tlpVisualizeSeats.Visible = true;

            foreach (var ticket in HelperClass.functions.ListTickets(choice, showTime))
            {

                if (ticket.BookingId == null)
                {

                    cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                }
            }
        }

        private void rdoShow4_CheckedChanged(object sender, EventArgs e)
        {
            int choice = MainMenuForm.MovieChoice;
            cklListTickets.Items.Clear();

            showTime = 4;

            tlpVisualizeSeats.Visible = true;

            foreach (var ticket in HelperClass.functions.ListTickets(choice, showTime))
            {

                if (ticket.BookingId == null)
                {

                    cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BookedTickets.Clear();
            this.Close();
            var mainMenu = new MainMenuForm();
            mainMenu.Show();
        }
    }
}
