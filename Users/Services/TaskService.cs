using System;
using UserProject.Models;

namespace UserProject.Services
{
    public class TaskService
    {
        public void AddUserToTask(ToDoTask task, User user)
        {
            Console.WriteLine($"User {user.Name} was added to task {task.Name}");
        }
    }
}
