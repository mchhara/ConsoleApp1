using System.Collections.Generic;

namespace ConsoleApp1
{
    internal interface IDoEverything
    {
        string GetUserFullName(User user);
        void UpdateUserEmail(long userId, string email);
        User GetById(long id);
        IDBConnection GetConnection(string connectionString);
        TEntity GetAll<TEntity>() where TEntity : class, IEntity;
        ITransaction BeginTransaction(IDBConnection connection);
        IEnumerable<User> GetAllUsers();
        void CommitTransaction(ITransaction transaction);
        string GetUsernamesByAgeDesc(IEnumerable<User> users);
        string GetRandomUserHobby();
    }





    internal interface IEntity
    {
    };

    internal interface IDBConnection
    {
    }

    internal interface ITransaction
    {        
    }

    internal class User : IEntity
    {
        long UserId { get; set; }
    }
}
