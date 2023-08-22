using ConsoleApp2.Models;
using ConsoleApp2.Services.Implementation;
using System;

namespace ConsoleApp2
{
    public static class SubMenu
    {
        public static void RenderSubMenu(RepositoryService<Quote> quoteRepository, RepositoryService<Product> productRepository)
        {
            var subMenuServices = new SubMenuServices();

            while (true)
            {
                Console.WriteLine("Dostępne oferty: ");
                foreach (var quote in quoteRepository.Query())
                {
                    Console.WriteLine($"Id oferty: {quote.Id} Nazwa oferty: {quote.Title}");
                }

                Console.WriteLine();
                Console.WriteLine("1. Wyświetl dane konkretnej oferty \n" +
                    "2. Dodaj produkt do oferty \n" +
                    "3. Usuń produkt z oferty \n" +
                    "4. Przelicz i wyświetl cenę końcową oferty \n" +
                    "5. Powrót do głównego menu\n");

                var subChoice = Console.ReadKey().KeyChar;
                Console.Clear();
                try
                {
                    switch (subChoice)
                    {
                        case '1':
                            subMenuServices.RenderSpecificQuoteDetails(quoteRepository);
                            break;
                        case '2':
                            subMenuServices.AddProductToQuote(quoteRepository, productRepository);
                            break;
                        case '3':
                            subMenuServices.DeleteProductFromQuote(quoteRepository);
                            break;
                        case '4':
                            // Przeliczenie i wyświetlenie ceny końcowej oferty
                            subMenuServices.RecalculateAndDisplayOfferPrice(quoteRepository);
                            break;
                        case '5':
                            return; // Powrót do głównego menu
                        default:
                            Console.WriteLine("Nieprawidłowa opcja. \n");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił błąd: " + ex.Message +"\n");
                }
            }
        }
    }
}
