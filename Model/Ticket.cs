using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF_CodeFirst.Model
{
    public class Ticket
    {
        // seguo convenzione EF, questa proprietà viene riconosciuta come chiave primaria

        /*
         * fluent API
         * Data Annotations (using System.ComponentModel.DataAnnotations;)
         * Convenzioni
         * ALTRIMENTI ERRORE
         */
        [Key] // is required automatico. Is Identity in automatico 1, 1
        public int Id { get; set; }

        public DateTime IssueDate { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }

        public string State { get; set; }

        [Required]
        [MaxLength(50)]
        public string Requestor { get; set; }

        //navigation property
        public virtual List<Note> Notes { get; set; }


    }
}
