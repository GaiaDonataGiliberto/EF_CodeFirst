using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CodeFirst.Model.Configuration
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        

        public void Configure(EntityTypeBuilder<Note> builder)
        {
            //la fluent API permette di fare un blocco per ogni property, in base al tipo di ritorno

            // is required automatico. Is Identity in automatico 1, 1
            builder
                .HasKey(n => n.Id);

            builder
                .Property(n => n.Comments)
                .HasMaxLength(500)
                .IsRequired();

            //builder
            //    .HasOne(n => n.Ticket)
            //    .WithMany(t => t.Notes);
        }
    }
}
