using EF_CodeFirst.Model;
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
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) //forzo il builder a usare la directory che è 
                //  in esecuzione quando si fa la build, così trova il file json anche quando farò l'assembly
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("TicketDb");
            // OPPURE config.GetSection("ConnectionStrings")["TicketDb"];

            optionBuilder.UseSqlServer("connString");
        
        }

    }
}
