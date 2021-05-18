using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BackEnd
{
     public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }     
        public string PhoneNumber { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
