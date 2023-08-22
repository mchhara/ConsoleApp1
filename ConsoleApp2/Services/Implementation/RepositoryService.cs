using ConsoleApp2.Models;
using ConsoleApp2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2.Services.Implementation
{
    public class RepositoryService<T> : IRepositoryService<T> where T : class, IEntity, new()
    {
        private List<T> _entities;

        public RepositoryService() 
        {
            _entities = new List<T>();
        }

        public Guid Add(T entity)
        {
            entity.NewId();

            _entities.Add(entity);

            return entity.Id;
        }

        public void Remove(Guid id)
        {
            var entity = _entities.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _entities.Remove(entity);
            }
        }

        public void Update(T entity)
        {
            var oldEntity = _entities.FirstOrDefault(x => x.Id == entity.Id);
            if (oldEntity != null)
            {
                _entities.Remove(oldEntity);
                _entities.Add(entity);
            }
        }

        public T Get(Guid id) 
        {
            var entity = _entities
                .FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public IQueryable<T> Query()
        {
            return _entities.AsQueryable();
        }
    }
}
