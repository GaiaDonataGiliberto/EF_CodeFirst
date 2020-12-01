using EF_CodeFirst.Model;
using EF_CodeFirst_Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EF_CodeFirst.Context
{
    public sealed class TicketContext : DbContext
    {
        DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {            
            optionBuilder.UseSqlServer(Config.GetConnectionString("TicketDb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ticketModel = modelBuilder.Entity<Ticket>();


            //la fluent API permette di fare un blocco per ogni property, in base al tipo di ritorno

            // is required automatico. Is Identity in automatico 1, 1
            ticketModel
                   .HasKey(t => t.Id);

            ticketModel
                .Property(t => t.Title)
                .HasMaxLength(100)
                .IsRequired();

            ticketModel
                .Property(t => t.Description)
                .HasMaxLength(500);

            ticketModel
                .Property(t => t.Category)
                .IsRequired();



                   

        }

    }
}
