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
    class TicketContext : DbContext
    {
        DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {            
            optionBuilder.UseSqlServer(Config.GetConnectionString("TicketDb"));
        }

    }
}
