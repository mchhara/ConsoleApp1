using System;

namespace ConsoleApp2.Models
{
    public interface IEntity
    {
        Guid Id { get; }

        void NewId();
    }
}
