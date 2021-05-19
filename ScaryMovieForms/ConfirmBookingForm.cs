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
    public partial class ConfirmBookingForm : Form
    {
        string firstName = HelperClass.functions.GetCustomer(EnterPhoneNumber.phoneNumber).FirstName;
        string lastName = HelperClass.functions.GetCustomer(EnterPhoneNumber.phoneNumber).LastName;
        

        public ConfirmBookingForm()
        {
            InitializeComponent();
           
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtMovieTitle.Text = HelperClass.functions.GetMovieTitle(MainMenuForm.MovieChoice);
            txtShowTime.Text = HelperClass.functions.GetShowTime(MovieForm.showTime);

            lstListOfTickets.DataSource = MovieForm.BookedTickets;



        }

        private void btnBook_Click(object sender, EventArgs e)
        {
           
            var listOfChoices = new List<int>();

            foreach (var ticket in MovieForm.BookedTickets)
            {
                listOfChoices.Add(ticket);
            }

            HelperClass.functions.BookTickets(listOfChoices, MainMenuForm.MovieChoice, MovieForm.showTime, EnterPhoneNumber.phoneNumber);

            MessageBox.Show("This is now booked!\n You will now automatically go back to main menu");

            var mainMenuForm = new MainMenuForm();
            this.Hide();
            mainMenuForm.Show();
        }

        private void btnGoBackMaenu_Click(object sender, EventArgs e)
        {
            if (HelperClass.functions.ListOfCustomerBookings(NewCustomerForm.phoneNumber).Count() == 0)
            {
                HelperClass.functions.DeleteCustomer(NewCustomerForm.phoneNumber);
            }
            this.Close();
            var mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();


        }


    }
}
