using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
   public class Booking
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
