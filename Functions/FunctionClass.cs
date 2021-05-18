using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd;

namespace Functions
{
   public class FunctionClass
    {
        public string GetMovieDescr(int movieID)
        {
            string movieDescr = "";
            using (var movieContext = new MovieAppContext())
            {
                var movieList = movieContext.Movies.Where(movie => movie.Id == movieID).ToList();

                foreach (var movie in movieList)
                {
                   movieDescr = movie.Description;
                }
 
            }
            return movieDescr;
        }

        public Customer GetCustomer(string phoneNumber)
        {
            using (var movieContext = new MovieAppContext())
            {
                var customer = movieContext.Customers.Single(customer => customer.PhoneNumber == phoneNumber);
                return customer;
            }
        }
        public int GetMovieId(string movieTitle)
        {
            using (var movieContext = new MovieAppContext())
            {
                var movieId = movieContext.Movies.First(movie => movie.Title == movieTitle).Id;
                return movieId;
            }
        }

        public string GetMovieTitle(int movieId)
        {
            string movieTitle = "";
            using (var movieContext = new MovieAppContext())
            {
                var movieList = movieContext.Movies.Where(movie => movie.Id == movieId).ToList();

                foreach (var movie in movieList)
                {
                    movieTitle = movie.Title;
                }

            }
            return movieTitle;

        }

        public string GetShowTime(int showNumber)
        {
            string showTime = "";

            using (var movieContext = new MovieAppContext())
            {

                showTime = movieContext.ShowTimes.Single(showTime => showTime.Id == showNumber)
                    .Time;
            }

            return showTime;
        }

        public void AddNewBooking(string customerPhone, int movieId)
        {
 
            using (var movieContext = new MovieAppContext())
            {
                int customer = movieContext.Customers.Single(customer => customer.PhoneNumber == customerPhone).Id;
                int movie = movieContext.Movies.Single(movie => movie.Id == movieId).Id;

                movieContext.Bookings.Add(new Booking { CustomerId = customer, MovieId = movie});
                movieContext.SaveChanges();


            }
        }

        public List<Ticket> ListTickets(int roomId, int showId)
        {
            using (var movieContext = new MovieAppContext())
            {

                var listOfTickets = movieContext.Tickets.Where(ticket => ticket.RoomId == roomId)
                    .Where(ticket => ticket.ShowTimeId == showId).ToList();

                return listOfTickets;
            }
        }

        public int AmountOfTicketOneBooking(int bookingId)
        {
            using (var movieContext = new MovieAppContext())
            {
                var listOfTickets = movieContext.Tickets.Where(ticket => ticket.BookingId == bookingId).ToList();

                int counting = listOfTickets.Count();

                return counting;
            }
        }

        public string DisplayShowTimeInOverview(int bookingId)
        {
            using (var movieContext = new MovieAppContext())
            {
                var showTimeId = movieContext.Tickets.First(ticket => ticket.BookingId == bookingId).ShowTimeId;

                var showTime = movieContext.ShowTimes.Single(time => time.Id == showTimeId).Time;

                return showTime;
            }
        }

        public int DisplayShowTimeId(int bookingId)
        {
            using (var movieContext = new MovieAppContext())
            {
                var showTimeId = movieContext.Tickets.First(ticket => ticket.BookingId == bookingId).ShowTimeId;

                var showTime = movieContext.ShowTimes.Single(time => time.Id == showTimeId).Id;

                return showTime;
            }
        }

        public void BookTickets(List<int> bookedSeats, int room, int showTime, string phoneNumber)
        {
            using (var movieContext = new MovieAppContext())
            {
                var listOfTickets = movieContext.Tickets.Where(ticket => ticket.RoomId == room)
                    .Where(ticket => ticket.ShowTimeId == showTime)
                    .ToList();

                var customer = movieContext.Customers.Single(customer => customer.PhoneNumber == phoneNumber);

                movieContext.Bookings.Add(new Booking { MovieId = room, CustomerId = customer.Id });
                movieContext.SaveChanges();

                var booking = movieContext.Bookings.OrderByDescending(booking => booking.Id).First();

                foreach (var seat in bookedSeats)
                {
                    foreach (var ticket in listOfTickets)
                    {
                        if (seat == ticket.SeatNumber) { ticket.BookingId = booking.Id; }
                        movieContext.SaveChanges();
                    }
                }
            }
        }

        public void ChangeTicketsOnBooking()
        {

        }

        public bool CustomerExists(string phoneNumber)
        {
            using (var movieContext = new MovieAppContext())
            {
                try
                {
                    var customer = movieContext.Customers.Single(customer => customer.PhoneNumber == phoneNumber);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    
                }
            }
        }

        public void AddCustomer(string phoneNumber, string firstName, string lastName)
        {
            using (var movieContext = new MovieAppContext())
            {
                movieContext.Customers.Add(new Customer { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber });
                movieContext.SaveChanges();

            }
        }

        public List<Booking> ListOfCustomerBookings(string phoneNumber)
        {
            using (var movieContext = new MovieAppContext())
            {
                var getCustomerID = movieContext.Customers.Single(customer => customer.PhoneNumber == phoneNumber).Id;

                var listOfBookings = movieContext.Bookings.Where(booking => booking.CustomerId == getCustomerID).ToList();

                return listOfBookings;
            }
        }

        public List<int> ListOfTicketsOneBooking(int bookingId)
        {
            var listToReturn = new List<int>();
            using (var movieContext = new MovieAppContext())
            {
                var listOfTickets = movieContext.Tickets.Where(ticket => ticket.BookingId == bookingId).ToList();

                foreach (var ticketNumber in listOfTickets)
                {
                    listToReturn.Add(ticketNumber.SeatNumber);
                }

                return listToReturn;
            }

        }

        public void DeleteCustomer(string phoneNumber)
        {
            using (var movieContext = new MovieAppContext())
            {
                var customerList = movieContext.Customers.Where(customer => customer.PhoneNumber == phoneNumber).ToList();

                foreach (var customer in customerList)
                {
                    movieContext.Customers.Remove(customer);
                    movieContext.SaveChanges();
                }

            }
        }


    }
}
