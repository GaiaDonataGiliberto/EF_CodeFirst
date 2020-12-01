using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CodeFirst.Model
{
    public class Ticket
    {
        // seguo convenzione EF, questa proprietà viene riconosciuta come chiave primaria
        public int Id { get; set; }

        public DateTime IssueDate { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string State { get; set; }



    }
}
