using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CodeFirst.Model
{
    public class Note
    {
        public int Id { get; set; }

        public string Comments { get; set; }


        public int TicketId { get; set; } // foreign key -> Ticket

        public virtual Ticket Ticket { get; set; }
    }
}
