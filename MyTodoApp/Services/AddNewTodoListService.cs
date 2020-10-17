using System;
using System.Linq;
using MyTodoApp.Models;
using MyTodoApp.Repository;

namespace MyTodoApp.Services
{
    public interface IAddNewTodoListService
    {
        bool Add(string name);
    }

    public class AddNewTodoListService : IAddNewTodoListService
    {
        private readonly IRepository<TodoList> _repository;

        public AddNewTodoListService(IRepository<TodoList> repository)
        {
            _repository = repository;
        }

        public bool Add(string name)
        {
            var allLists = _repository.GetAll();
            if (allLists.Any(c => c.Name.Equals(name))) return false;
            if (name.Equals(string.Empty)) return false;

            var newList = new TodoList
            {
                Id = _repository.GetAll().Max(c => c.Id) + 1,
                Ident = Guid.NewGuid().ToString(),
                Name = name
            };

            return _repository.Add(newList);
        }
    }
}