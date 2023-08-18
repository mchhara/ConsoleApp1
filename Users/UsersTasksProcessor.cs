using System;
using System.Collections.Generic;
using UserProject.Models;
using UserProject.Services;

namespace UserProject
{
    public static class UsersTasksProcessor
    {
        public static void AddTasksForUser(string username)
        {
            List<ToDoTask> tasks = new List<ToDoTask>()
            {
                new ToDoTask("Debug code"),
                new ToDoTask("Write tests"),
                new ToDoTask("Deploy app"),
                new ToDoTask("Go home"),
            };

            var userService = new UserService();
            foreach (var task in tasks)
            {
                var taskService = new TaskService();
                taskService.AddUserToTask(task, userService.GetUser(username));

                Console.WriteLine();
            }

            Console.WriteLine("Done, user was added to tasks!");
        }
    }
}