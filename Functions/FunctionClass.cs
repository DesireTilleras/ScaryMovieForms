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
        public string MovieTitleFromBookingId(int bookingId)
        {
            using (var movieContext = new MovieAppContext())
            {
                var movieId = movieContext.Tickets.First(ticket => ticket.BookingId == bookingId).RoomId;

                var title = movieContext.Movies.First(movie => movie.Id == movieId).Title;

                return title;

            }
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

        public void ChangeTicketsOnBooking( int roomId, List<int> oldSeats, int oldShowTime, List<int> newSeats, int newShowTime)
        {

            List<int> oldticketsId = new List<int>();
            List<int> newticketsId = new List<int>();
            List<int> bookingId = new List<int>();

            using (var movieContext = new MovieAppContext())
            {
                foreach (var oldSeatNumber in oldSeats)
                {
                    var oldTicketsList = movieContext.Tickets.Where(ticket => ticket.RoomId == roomId)
                        .Where(ticket => ticket.ShowTimeId == oldShowTime)
                        .Where(ticket => ticket.SeatNumber == oldSeatNumber).ToList();
                    
                    foreach (var ticket in oldTicketsList)
                    {
                        oldticketsId.Add(ticket.Id);
                    }
                }

                foreach (var ticketId in oldticketsId)
                {
                    var listOfTickets = movieContext.Tickets.Where(ticket => ticket.Id == ticketId);

                    var listbookingId = listOfTickets.Select(ticket => ticket.BookingId).ToList();
                    foreach (var ticket in listOfTickets)
                    {
                        ticket.BookingId = null;
                     }
                    foreach (var booking in listbookingId)
                    {
                        bookingId.Add((int)booking);
                    }
                }
                var takebookingId = bookingId.First();

                movieContext.SaveChanges();

                foreach (var newSeatNumber in newSeats)
                {
                    var newTicketsList = movieContext.Tickets.Where(ticket => ticket.RoomId == roomId)
                        .Where(ticket => ticket.ShowTimeId == newShowTime)
                        .Where(ticket => ticket.SeatNumber == newSeatNumber).ToList();

                    foreach (var ticket in newTicketsList)
                    {
                        newticketsId.Add(ticket.Id);
                    }
                }

                foreach (var ticketId in newticketsId)
                {
                    var listOfTickets = movieContext.Tickets.Where(ticket => ticket.Id == ticketId).ToList();

                    foreach (var ticket in listOfTickets)
                    {
                        ticket.BookingId = takebookingId;
                    }
                }

                movieContext.SaveChanges();

            }
            
        }
        public void ChangeOnlySeatsOnBooking(int roomId, List<int> oldSeats, int oldShowTimeId, List<int> newSeats)
        {

            List<int> oldticketsId = new List<int>();
            List<int> newticketsId = new List<int>();
            List<int> bookingId = new List<int>();

            using (var movieContext = new MovieAppContext())
            {
                foreach (var oldSeatNumber in oldSeats)
                {
                    var oldTicketsList = movieContext.Tickets.Where(ticket => ticket.RoomId == roomId)
                        .Where(ticket => ticket.ShowTimeId == oldShowTimeId)
                        .Where(ticket => ticket.SeatNumber == oldSeatNumber).ToList();

                    foreach (var ticket in oldTicketsList)
                    {
                        oldticketsId.Add(ticket.Id);
                    }
                }

                foreach (var ticketId in oldticketsId)
                {
                    var listOfTickets = movieContext.Tickets.Where(ticket => ticket.Id == ticketId);

                    var listbookingId = listOfTickets.Select(ticket => ticket.BookingId).ToList();
                    foreach (var ticket in listOfTickets)
                    {
                        ticket.BookingId = null;
                    }
                    foreach (var booking in listbookingId)
                    {
                        bookingId.Add((int)booking);
                    }
                }
                var takebookingId = bookingId.First();

                movieContext.SaveChanges();

                foreach (var newSeatNumber in newSeats)
                {
                    var newTicketsList = movieContext.Tickets.Where(ticket => ticket.RoomId == roomId)
                        .Where(ticket => ticket.ShowTimeId == oldShowTimeId)
                        .Where(ticket => ticket.SeatNumber == newSeatNumber).ToList();

                    foreach (var ticket in newTicketsList)
                    {
                        newticketsId.Add(ticket.Id);
                    }
                }

                foreach (var ticketId in newticketsId)
                {
                    var listOfTickets = movieContext.Tickets.Where(ticket => ticket.Id == ticketId).ToList();

                    foreach (var ticket in listOfTickets)
                    {
                        ticket.BookingId = takebookingId;
                    }
                }

                movieContext.SaveChanges();

            }
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
                try
                {
                    var getCustomerID = movieContext.Customers.Single(customer => customer.PhoneNumber == phoneNumber).Id;

                    var listOfBookings = movieContext.Bookings.Where(booking => booking.CustomerId == getCustomerID).ToList();

                    return listOfBookings;
                }
                catch (Exception)
                {

                    throw;
                }

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
                   
                }
                movieContext.SaveChanges();

            }
        }

        public void DeleteBooking(int bookingId)
        {
            using (var movieContext = new MovieAppContext())
            {
                try
                {
                    var customerId = movieContext.Bookings.First(booking => booking.Id == bookingId).CustomerId;

                    var phoneNumber = movieContext.Customers.First(customer => customer.Id == customerId).PhoneNumber;

                    var tickets = movieContext.Tickets.Where(ticket => ticket.BookingId == bookingId).ToList();

                    foreach (var ticket in tickets)
                    {
                        ticket.BookingId = null;
                    }
                    var bookings = movieContext.Bookings.Where(booking => booking.Id == bookingId).ToList();

                    foreach (var booking in bookings)
                    {
                        movieContext.Bookings.Remove(booking);
                    }
                    movieContext.SaveChanges();

                    if (ListOfCustomerBookings(phoneNumber).Count == 0)
                    {
                        DeleteCustomer(phoneNumber);
                    }
                    movieContext.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
               
            }
        }


    }
}
