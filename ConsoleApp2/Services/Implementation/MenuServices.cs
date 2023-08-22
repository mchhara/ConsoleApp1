using ConsoleApp2.Models;
using ConsoleApp2.Services.Interfaces;
using System;

namespace ConsoleApp2.Services.Implementation
{
    public class MenuServices : IMenuServices
    {
        /// <summary>
        ///  Dodawanie nowej oferty
        /// </summary>
        public void AddNewQuote(RepositoryService<Quote> quoteRepository)
        {
            Console.Write("Podaj nazwę oferty: ");
            string quoteTitle = Console.ReadLine();
            Quote newQuote = new Quote { Title = quoteTitle };
            quoteRepository.Add(newQuote);
            Console.WriteLine("Oferta dodana. \n");
        }

        /// <summary>
        ///  Usuwanie oferty
        /// </summary>
        public void RemoveQuote(RepositoryService<Quote> quoteRepository)
        {
            var quotes = quoteRepository.Query();

            Console.WriteLine("Dostępne oferty:");

            foreach (var quote in quotes)
            {
                Console.WriteLine($"Id oferty: {quote.Id} Nazwa oferty: {quote.Title}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Podaj ID oferty którą chcesz usunąć: ");

            Guid quoteIdToRemove = new Guid(Console.ReadLine());
            Quote quoteToRemove = quoteRepository.Get(quoteIdToRemove);

            if (quoteToRemove == null)
            {
                Console.WriteLine("Oferta nie istnieje.\n");
                return;
            }
            quoteRepository.Remove(quoteToRemove.Id);
            Console.WriteLine("Oferta została usunięta.\n");
        }
    }
}
