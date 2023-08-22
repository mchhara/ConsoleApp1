using ConsoleApp2.Models;
using System;
using System.Linq;

namespace ConsoleApp2.Services.Interfaces
{
    public interface IRepositoryService<T> where T : class, IEntity
    {
        Guid Add(T entity);
        void Remove(Guid id);
        void Update(T entity);
        IQueryable<T> Query();
        T Get(Guid id);
    }
}