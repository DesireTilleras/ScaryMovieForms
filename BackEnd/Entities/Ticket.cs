using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{// En biljett kan ha ett rum
    // en biljett kan ha en showtime
    // En biljett kna ha en kund
    public class Ticket
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public int? RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int? ShowTimeId { get; set; }
        public virtual ShowTime ShowTime { get; set; }
        public int? BookingId { get; set; }
        public virtual Booking Booking { get; set; }


    }
}
