using ConsoleApp2.Models;
using ConsoleApp2.Services.Implementation;
using System;

namespace ConsoleApp2
{
    public static class Menu
    {
        public static void RenderMenu(RepositoryService<Quote> quoteRepository, RepositoryService<Product> productRepository)
        {
            var menuServices = new MenuServices();

            while (true)
            {
                Console.WriteLine("1. Wylistuj oferty \n" +
                    "2. Dodaj nową ofertę \n" +
                    "3. Usuń ofertę \n" +
                    "4. Wyjdź\n");

                var choice = Console.ReadKey().KeyChar;
                Console.Clear();

                try
                {
                    switch (choice)
                    {
                        case '1':
                            //Wypisanie podmenu
                            SubMenu.RenderSubMenu(quoteRepository, productRepository);
                            break;
                        case '2':
                            menuServices.AddNewQuote(quoteRepository);
                            break;
                        case '3':
                            menuServices.RemoveQuote(quoteRepository);
                            break;
                        case '4':
                            return; // Wyjście z programu
                        default:
                            Console.WriteLine("Nieprawidłowa opcja. \n");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił błąd: " + ex.Message);
                }
            }
        }
    }
}
