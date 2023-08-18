using System;

namespace ConsoleApp2.Models
{
    public class Quote : IEntity
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public Money TotalPrice { get; set; }
        public DateTime CreationDate { get; set; }

        public void NewId()
        {
            Id = new Guid();
        }
    }
}