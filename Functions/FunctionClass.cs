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
        /// <summary>
        /// Gets the description of the movie
        /// </summary>
        /// <param name="movieID"></param>
        /// <returns></returns>
        public string GetMovieDescr(int movieID)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
            
        }
        /// <summary>
        /// Returns a customer
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public Customer GetCustomer(string phoneNumber)
        {
            try
            {
                using (var movieContext = new MovieAppContext())
                {
                    var customer = movieContext.Customers.Single(customer => customer.PhoneNumber == phoneNumber);
                    return customer;
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        /// <summary>
        /// Returns customer name
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns></returns>
        public string GetCustomerName(int bookingId)
        {
            try
            {
                using (var movieContext = new MovieAppContext())
                {
                    var customerId = movieContext.Bookings.First(booking => booking.Id == bookingId).CustomerId;

                    var firstName = movieContext.Customers.First(customer => customer.Id == customerId).FirstName;
                    var lastName = movieContext.Customers.First(customer => customer.Id == customerId).LastName;

                    var name = firstName + " " + lastName;

                    return name;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        /// <summary>
        /// Gets movieId from movietitle.
        /// </summary>
        /// <param name="movieTitle"></param>
        /// <returns></returns>
        public int GetMovieId(string movieTitle)
        {
            try
            {
                using (var movieContext = new MovieAppContext())
                {
                    var movieId = movieContext.Movies.First(movie => movie.Title == movieTitle).Id;
                    return movieId;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        /// <summary>
        /// Gets movietitle from movieId
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public string GetMovieTitle(int movieId)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
            

        }
        /// <summary>
        /// Gets the movietitle as string
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns></returns>
        public string MovieTitleFromBookingId(int bookingId)
        {
            using (var movieContext = new MovieAppContext())
            {
                var movieId = movieContext.Tickets.First(ticket => ticket.BookingId == bookingId).RoomId;

                var title = movieContext.Movies.First(movie => movie.Id == movieId).Title;

                return title;

            }
        }
        /// <summary>
        /// Depending on which show time id, the correct show time is returned as string
        /// </summary>
        /// <param name="showNumber"></param>
        /// <returns></returns>
        public string GetShowTime(int showNumber)
        {
            try
            {
                string showTime = "";

                using (var movieContext = new MovieAppContext())
                {

                    showTime = movieContext.ShowTimes.Single(showTime => showTime.Id == showNumber)
                        .Time;
                }

                return showTime;
            }
            catch (Exception)
            {

                throw;
            }
            
        }        
        /// <summary>
        /// Function that returns a list of all tickets for one movie in one show time
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="showId"></param>
        /// <returns></returns>
        public List<Ticket> ListTickets(int roomId, int showId)
        {
            using (var movieContext = new MovieAppContext())
            {
                try
                {
                    var listOfTickets = movieContext.Tickets.Where(ticket => ticket.RoomId == roomId)
                    .Where(ticket => ticket.ShowTimeId == showId).ToList();

                    return listOfTickets;
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }
        /// <summary>
        /// Function that count the amount of seats for one booking. 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns></returns>
        public int AmountOfTicketOneBooking(int bookingId)
        {
            using (var movieContext = new MovieAppContext())
            {
                try
                {
                    var listOfTickets = movieContext.Tickets.Where(ticket => ticket.BookingId == bookingId).ToList();

                    int counting = listOfTickets.Count();

                    return counting;
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }
        /// <summary>
        /// Function that returns the show time string for one booking. 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns></returns>
        public string DisplayShowTimeInOverview(int bookingId)
        {
            using (var movieContext = new MovieAppContext())
            {
                try
                {
                    var showTimeId = movieContext.Tickets.First(ticket => ticket.BookingId == bookingId).ShowTimeId;

                    var showTime = movieContext.ShowTimes.Single(time => time.Id == showTimeId).Time;

                    return showTime;
                }
                catch (Exception)
                {

                    throw;
                }
               
            }
        }
        /// <summary>
       /// Function that returns the id for showtime
       /// </summary>
       /// <param name="bookingId"></param>
       /// <returns></returns>
        public int DisplayShowTimeId(int bookingId)
        {
            using (var movieContext = new MovieAppContext())
            {
                try
                {
                    var showTimeId = movieContext.Tickets.First(ticket => ticket.BookingId == bookingId).ShowTimeId;

                    var showTime = movieContext.ShowTimes.Single(time => time.Id == showTimeId).Id;

                    return showTime;

                }
                catch (Exception)
                {

                    throw;
                }
               
            }
        }
        /// <summary>
        /// Function that sets the bookingId on tickets to correct id. 
        /// </summary>
        /// <param name="bookedSeats"></param>
        /// <param name="room"></param>
        /// <param name="showTime"></param>
        /// <param name="phoneNumber"></param>
        public void BookTickets(List<int> bookedSeats, int room, int showTime, string phoneNumber)
        {
            using (var movieContext = new MovieAppContext())
            {
                try
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
                catch (Exception)
                {

                    throw;
                }
                
            }
        }
        /// <summary>
        /// Function for changing the show time and seats for one booking.
        /// Sets the bookingd to null for the old tickets
        /// Sets the bookingId to correct id for the new tickets. 
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="oldSeats"></param>
        /// <param name="oldShowTime"></param>
        /// <param name="newSeats"></param>
        /// <param name="newShowTime"></param>
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
        /// <summary>
        /// The customer has chosen to change only the seats, not the showtime on its booking
        /// Sets the old seats BookingId to null
        /// Sets the new seats to correct bookingId
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="oldSeats"></param>
        /// <param name="oldShowTimeId"></param>
        /// <param name="newSeats"></param>
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
        /// <summary>
        /// Checks if the customer exists in the database
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
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
        /// <summary>
       /// Adds a new customer in the database.
       /// </summary>
       /// <param name="phoneNumber"></param>
       /// <param name="firstName"></param>
       /// <param name="lastName"></param>
        public void AddCustomer(string phoneNumber, string firstName, string lastName)
        {
            using (var movieContext = new MovieAppContext())
            {
                movieContext.Customers.Add(new Customer { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber });
                movieContext.SaveChanges();

            }
        }
        /// <summary>
        /// Returns a list of all bookings for one customer
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Function that returns a list of ticket seat numbers for one booking. 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns></returns>
        public List<int> ListOfTicketsOneBooking(int bookingId)
        {
            var listToReturn = new List<int>();
            using (var movieContext = new MovieAppContext())
            {
                try
                {
                    var listOfTickets = movieContext.Tickets.Where(ticket => ticket.BookingId == bookingId).ToList();

                    foreach (var ticketNumber in listOfTickets)
                    {
                        listToReturn.Add(ticketNumber.SeatNumber);
                    }

                    return listToReturn;

                }
                catch (Exception)
                {

                    throw;
                }
                
            }

        }
        /// <summary>
        /// Deletes customer if the customer doesn't have any bookings.
        /// </summary>
        /// <param name="phoneNumber"></param>
        public void DeleteCustomer(string phoneNumber)
        {
            using (var movieContext = new MovieAppContext())
            {
                try
                {
                    var customerList = movieContext.Customers.Where(customer => customer.PhoneNumber == phoneNumber).ToList();

                    foreach (var customer in customerList)
                    {
                        movieContext.Customers.Remove(customer);

                    }
                    movieContext.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }
                

            }
        }
        /// <summary>
        /// Deletes the booking, if the customer has chosen to delete the booking. 
        /// It deletes the row in database table "Bookings" and
        /// Sets the tickets bookingId to null
        /// </summary>
        /// <param name="bookingId"></param>
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
        /// <summary>
        /// Gets the filepath for the correct image on a certain movie.
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public string GetMovieImagePath(int movieId)
        {
            using (var movieContext = new MovieAppContext())
            {
                try
                {
                    var moviePath = movieContext.Movies.First(movie => movie.Id == movieId).FilePath;

                    return moviePath;

                }
                catch (Exception)
                {

                    throw;
                }
                
            }

            
        }

    }
}
