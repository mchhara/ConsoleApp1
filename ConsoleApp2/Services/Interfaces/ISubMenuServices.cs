using ConsoleApp2.Models;
using ConsoleApp2.Services.Implementation;

namespace ConsoleApp2.Services.Interfaces
{
    public interface ISubMenuServices
    {
        void RenderSpecificQuoteDetails(RepositoryService<Quote> quoteRepository);
        void AddProductToQuote(RepositoryService<Quote> quoteRepository, RepositoryService<Product> productRepository);
        void DeleteProductFromQuote(RepositoryService<Quote> quoteRepository);
        void RecalculateAndDisplayOfferPrice(RepositoryService<Quote> quoteRepository);

    }
}
