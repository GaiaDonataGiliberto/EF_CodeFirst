using EF_CodeFirst.Model;
using System;

namespace EF_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService dataService = new DataService();

            Console.WriteLine("=== ticket management ===");

            bool quit = false;

            do
            {
                Console.Write("Comando: ");
                string command = Console.ReadLine();
                Console.WriteLine();

                switch (command)
                {
                    case "q":
                        quit = true;
                        break;
                    case "a":
                        // ADD
                        Ticket ticket = new Ticket();

                        

                        ticket.Title = GetData("Titolo");
                        ticket.Description = GetData("Descrizione");
                        ticket.Category = GetData("Categoria");
                        ticket.Requestor = "GDG";
                        ticket.State = "New";
                        ticket.IssueDate = DateTime.Now;

                       var result = dataService.Add(ticket);

                        Console.WriteLine("Operation " + (result ? "Completed" : "Failed"));



                        break;
                    case "l":
                        // LIST
                        Console.WriteLine("TICKET LIST");

                        foreach (var item in dataService.List())
                        {
                            Console.WriteLine($"ID: {item.Id} - Titolo: {item.Title}");
                        }
                        Console.WriteLine("=== === ===");
                        break;
                    case "e":
                        // EDIT
                        break;
                    case "d":
                        // DELETE
                        break;
                    default:
                        Console.WriteLine("Comando sconosciuto");
                        break;
                }



            } while (!quit);




            Console.WriteLine("=== bye bye ===");
        }

        public static string GetData(string message)
        {
            Console.WriteLine(message + ": ");
            var value = Console.ReadLine();
            return value;
        }
    }
}
