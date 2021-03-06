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
        private List<Label> labels = new List<Label>();

        public static int showTime;
        public MovieForm()
        {
            InitializeComponent();

            btnCheckSeatList.Visible = false;

            rdoShow1.Text = HelperClass.functions.GetShowTime(1);
            rdoShow2.Text = HelperClass.functions.GetShowTime(2);
            rdoShow3.Text = HelperClass.functions.GetShowTime(3);
            rdoShow4.Text = HelperClass.functions.GetShowTime(4);
            try
            {
                picMovieImage.Image = Image.FromFile(HelperClass.functions.GetMovieImagePath(MainMenuForm.MovieChoice));
            }
            catch (Exception)
            {

                MessageBox.Show("Could not find image in file");
            }
            

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
        }

        private void rdoShow1_CheckedChanged(object sender, EventArgs e)
        {
            showTime = 1;

            ShowCorrectTicketList(showTime);

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

            showTime = 2;

            ShowCorrectTicketList(showTime);
        }

        private void rdoShow3_CheckedChanged(object sender, EventArgs e)
        {
            showTime = 3;

            ShowCorrectTicketList(showTime);
        }

        private void rdoShow4_CheckedChanged(object sender, EventArgs e)
        {
            showTime = 4;

            ShowCorrectTicketList(showTime);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            
            BookedTickets.Clear();
            this.Close();
            var mainMenu = new MainMenuForm();
            mainMenu.Show();
        }

        private void SetColorOnSeat(CheckedListBox.ObjectCollection items)
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
        private void ResetColorOnSeat()
        {
            foreach (var label in labels)
            {
                label.BackColor = Color.LightCoral;
            }
        }
        private void SetColorOnChoice(CheckedListBox.CheckedItemCollection items)
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
        
            if (cklListTickets.CheckedItems.Count == 0)
            {
                SetColorOnSeat(cklListTickets.Items);

                btnCheckSeatList.Visible = false;

            }
            if (cklListTickets.CheckedItems.Count != 0)
            {
                btnCheckSeatList.Visible = true;
            }
            SetColorOnChoice(cklListTickets.CheckedItems);



        }

        private void ShowCorrectTicketList(int showNumber)
        {
            ResetColorOnSeat();

            int choice = MainMenuForm.MovieChoice;
            cklListTickets.Items.Clear();
            tlpVisualizeSeats.Visible = true;
            lblFree.Visible = true;
            lblChoice.Visible = true;
            lblSalmon.Visible = true;
            lblBooked.Visible = true;
            lblGreen.Visible = true;
            lblRed.Visible = true;

            foreach (var ticket in HelperClass.functions.ListTickets(choice, showNumber))
            {

                if (ticket.BookingId == null)
                {

                    cklListTickets.Items.Add(ticket.SeatNumber.ToString(), CheckState.Unchecked);
                }
            }

            SetColorOnSeat(cklListTickets.Items);
        }
    }
}
