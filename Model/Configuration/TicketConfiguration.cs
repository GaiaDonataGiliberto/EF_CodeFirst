using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CodeFirst.Model.Configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            // var ticketModel = modelBuilder.Entity<Ticket>();


            //la fluent API permette di fare un blocco per ogni property, in base al tipo di ritorno

            // is required automatico. Is Identity in automatico 1, 1
            builder
                   .HasKey(t => t.Id);

            builder
                .Property(t => t.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(t => t.Description)
                .HasMaxLength(500);

            builder
                .Property(t => t.Category)
                .IsRequired();

            builder
                .Property(t => t.Requestor)
                .HasMaxLength(50)
                .IsRequired();

            //gestisco la relazione 1:N con la lista di note
            builder
                .HasMany(t => t.Notes)
                .WithOne(n => n.Ticket)
                .HasForeignKey(n => n.TicketId)
                .HasConstraintName("FK_Ticket_Notes")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
