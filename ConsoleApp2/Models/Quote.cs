using System;
using System.Collections.Generic;

namespace ConsoleApp2.Models
{
    public class Quote : IEntity
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public Money TotalPrice { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow.AddHours(2);
        public List<Product> Products { get; set; } = new List<Product>();

        public void NewId()
        { 
            Id = Guid.NewGuid();
        }
    }
}