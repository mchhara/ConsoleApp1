using System;

namespace ConsoleApp2.Models
{
    public class Product : IEntity
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public Money Price { get; set; }

        public void NewId()
        {
            Id = new Guid();
        }
    }
}