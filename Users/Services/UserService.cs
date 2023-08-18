using System;
using UserProject.Models;

namespace UserProject.Services
{
    public class UserService
    {
        public User GetUser(string name)
        {
            Console.WriteLine($"Retreive user data: {name}");
            return new User
            {
                Name = name,
            };
        }
    }
}
