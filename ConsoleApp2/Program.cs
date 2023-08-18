using ConsoleApp2.Models;
using ConsoleApp2.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productRepository = PrepareProductRepository();

            Console.WriteLine("WITAJ W SYSTEMIE ZARZĄDZANIA OFERTAMI SPRZEDAŻY");

            // Zadanie:

            // Należy dodać serwis zarządzający ofertą, który powinien mieć funkcjonalności pozwalające na:
            // - Dodanie oferty do repozytorium
            // - Usunięcie oferty z repozytorium
            // - Pobranie oferty z repozytorium
            // - Dodanie istniejącego produktu w repozytorium do oferty
            // - Usunięcie produktu z oferty 
            // - Przeliczenie Ceny oferty na podstawie zawartych produktów w ofercie


            //Wyświetlenie wyników oraz interakcja z użytkownikiem:

            // Użytkownik w konsoli pownien móc:
            // - Wylistować oferty
            // - Dodać nową ofertę
            // - Wyświetlić dane konkretnej oferty
            // - Dodać do niej produkt
            // - Usunąć z niej produkt
            // - Przeliczyć gotową ofertę i wyświetlić cenę końcową


            // Jeżeli jakiś Model lub część aktualnego rozwiązania wymaga modyfikacji do wykonania zadania to należy ją zmodyfikować
            // Jeżeli jakaś część zadania wymaga dodania jakiegoś komponentu, należy go dodać.
            // Należy pamiętać o dobrych praktykach
        }

        /// <summary>
        /// Metoda służy tylko do uzupełnienia imitacji bazy danych produktami.
        /// </summary>
        /// <returns></returns>
        private static RepositoryService<Product> PrepareProductRepository()
        {
            var repository = new RepositoryService<Product>();

            repository.Add(new Product { Name = "P1", Price = new Money(10) });
            repository.Add(new Product { Name = "P2", Price = new Money(20) });
            repository.Add(new Product { Name = "P3", Price = new Money(30) });
            repository.Add(new Product { Name = "P4", Price = new Money(40) });
            repository.Add(new Product { Name = "P5", Price = new Money(50) });
            repository.Add(new Product { Name = "P6", Price = new Money(60) });
            repository.Add(new Product { Name = "P7", Price = new Money(70) });
            repository.Add(new Product { Name = "P8", Price = new Money(80) });
            repository.Add(new Product { Name = "P9", Price = new Money(90) });
            repository.Add(new Product { Name = "P10", Price = new Money(100) });

            return repository;
        }
    }
}
