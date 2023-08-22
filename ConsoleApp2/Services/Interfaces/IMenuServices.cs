using ConsoleApp2.Models;
using ConsoleApp2.Services.Implementation;

namespace ConsoleApp2.Services.Interfaces
{
    internal interface IMenuServices
    {
        void AddNewQuote(RepositoryService<Quote> quoteRepository);
        void RemoveQuote(RepositoryService<Quote> quoteRepository);
    }
}
