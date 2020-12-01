using EF_CodeFirst.Context;
using EF_CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF_CodeFirst
{
    public class DataService
    {

        public List<Ticket> List()
        {
            using var ctx = new TicketContext();

            return ctx.Tickets.ToList();

            
        }

        public bool Add(Ticket ticket)
        {
            try
            {
                using var ctx = new TicketContext();

                if (ticket != null)
                {
                    ctx.Tickets.Add(ticket);
                    ctx.SaveChanges();
                }                    
                else
                    Console.WriteLine("Ticket non può essere nullo");

                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
        }

        
    }
}