using ConsoleApp2.Models;
using ConsoleApp2.Services.Interfaces;
using System;

namespace ConsoleApp2.Services.Implementation
{
    public class SubMenuServices : ISubMenuServices
    {
        /// <summary>
        /// Wyświetlanie danych konkretnej oferty
        /// </summary>
        public void RenderSpecificQuoteDetails(RepositoryService<Quote> quoteRepository)
        {
            Console.Write("Podaj ID oferty do wyświetlenia: ");

            Quote displayedQuote = TryGetQuoteFromId(quoteRepository);

            if (displayedQuote == null)
            {
                Console.WriteLine("Oferta nie istnieje.\n");
                return;
            }

            Console.WriteLine($"\nDane oferty: ID: {displayedQuote.Id} Nazwa: {displayedQuote.Title} Data utworzenia: {displayedQuote.CreationDate}" );

            RenderQuoteProductsList(displayedQuote);
        }

        /// <summary>
        /// Dodawanie produktu do oferty
        /// </summary>
        public void AddProductToQuote(RepositoryService<Quote> quoteRepository, RepositoryService<Product> productRepository)
        {
            Console.Write("Podaj ID oferty do dodania produktu: ");

            Quote targetQuote = TryGetQuoteFromId(quoteRepository);

            if (targetQuote == null)
            {
                Console.WriteLine("Oferta nie istnieje. \n");
                return;
            }

            var availableProducts = productRepository.Query();

            Console.WriteLine("Dostępne produkty: \n");

            foreach (var availableProduct in availableProducts)
            {
                Console.WriteLine($"Id produktu: {availableProduct.Id} Nazwa produktu: {availableProduct.Name}, Cena produktu: {availableProduct.Price.Value}");
            }
            Console.WriteLine();

            Console.Write("Podaj ID produktu: ");
            Guid productId = new Guid(Console.ReadLine());
            Product product = productRepository.Get(productId);
            targetQuote.Products.Add(product);
            Console.WriteLine("Produkt dodany do oferty. \n");
        }

        /// <summary>
        /// Usuwanie produktu z oferty
        /// </summary>
        public void DeleteProductFromQuote(RepositoryService<Quote> quoteRepository)
        {
            Console.Write("Podaj ID oferty z której usunąć produkt: ");

            Quote quoteToRemoveProduct = TryGetQuoteFromId(quoteRepository);

            if (quoteToRemoveProduct == null)
            {
                Console.WriteLine("Oferta nie istnieje.\n");
                return;
            }
            RenderQuoteProductsList(quoteToRemoveProduct);
            Console.Write("Podaj nazwę produktu do usunięcia: ");

            string productToRemove = Console.ReadLine();
            Product product = quoteToRemoveProduct.Products.Find(p => p.Name == productToRemove);

            if (product == null)
            {
                Console.WriteLine("Produkt nie istnieje w ofercie.\n");
                return;
            }

            quoteToRemoveProduct.Products.Remove(product);
            Console.WriteLine("Produkt usunięty z oferty.\n");
        }

        /// <summary>
        /// Przeliczanie i wyświetlenie ceny końcowej oferty
        /// </summary>
        public void RecalculateAndDisplayOfferPrice(RepositoryService<Quote> quoteRepository)
        {
            Console.Write("Podaj ID oferty do przeliczenia ceny: ");

            Quote quoteToCalculatePrice = TryGetQuoteFromId(quoteRepository);
            QuoteTotalPriceCalculation totalPriceCalculation = new QuoteTotalPriceCalculation(quoteToCalculatePrice);

            if (quoteToCalculatePrice == null)
            {
                Console.WriteLine("Oferta nie istnieje. \n");
                return;
            }

            decimal totalPrice = totalPriceCalculation.CalculateTotalPrice();
            Console.WriteLine($"\nCena końcowa oferty {quoteToCalculatePrice.Title}: {totalPrice} \n");
        }

        private static Quote TryGetQuoteFromId(RepositoryService<Quote> repository)
        {
            Guid quoteId = new Guid(Console.ReadLine());
            Quote quote = repository.Get(quoteId);

            return quote;
        }

        private static void RenderQuoteProductsList(Quote displayedQuote)
        {
            if (displayedQuote.Products.Count > 0)
            {
                Console.WriteLine("Produkty w ofercie:");

                foreach (var product in displayedQuote.Products)
                {
                    Console.WriteLine($"Nazwa: {product.Name}, Cena: {product.Price.Value}");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Oferta nie posiada produktów. \n");
            }
        }
    }
}
