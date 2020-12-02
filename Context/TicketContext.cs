using EF_CodeFirst.Model;
using EF_CodeFirst.Model.Configuration;
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
        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {            
            string conString = Config.GetConnectionString("TicketDb");
            optionBuilder.UseLazyLoadingProxies();
            optionBuilder.UseSqlServer(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Ticket>(new TicketConfiguration());
            modelBuilder.ApplyConfiguration<Note>(new NoteConfiguration());
                   
        }

    }
}
