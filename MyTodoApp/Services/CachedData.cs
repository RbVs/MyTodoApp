using System;
using System.Collections.Generic;
using MyTodoApp.Models;

namespace MyTodoApp.Services
{
    public interface ICachedData
    {
        List<Todo> Todos { get; set; }
        List<TodoList> TodoLists { get; set; }
    }

    public class CachedData : ICachedData
    {
        public CachedData()
        {
            Initialize();
        }

        public List<Todo> Todos { get; set; } = new List<Todo>();
        public List<TodoList> TodoLists { get; set; } = new List<TodoList>();

        private void Initialize()
        {
            var l1 = new TodoList
            {
                Id = 1,
                Ident = Guid.NewGuid().ToString(),
                Name = "Home",
                Todos = new List<Todo>
                {
                    new Todo
                    {
                        Id = 1
                    },
                    new Todo
                    {
                        Id = 2
                    },
                }
            };
            var l2 = new TodoList
            {
                Id = 2,
                Ident = Guid.NewGuid().ToString(),
                Name = "Work"
            };

            TodoLists.Add(l1);
            TodoLists.Add(l2);
        }
    }
}