using System;
using System.Linq;
using MyTodoApp.Models;
using MyTodoApp.Repository;

namespace MyTodoApp.Services
{
    public interface IAddNewTodoListService
    {
        bool SaveNewTodoList(string name);
        bool DeleteTodoList(string name);
    }

    public class AddNewTodoListService : IAddNewTodoListService
    {
        private readonly IRepository<TodoList> _repository;

        public AddNewTodoListService(IRepository<TodoList> repository)
        {
            _repository = repository;
        }

        public bool SaveNewTodoList(string name)
        {
            var allLists = _repository.GetAll();
            if (allLists.Any(c => c.Name.Equals(name))) return false;
            if (name.Equals(string.Empty)) return false;

            var items = _repository.GetAll();
            var count = items.Count == 0 ? 0 : items.Max(c => c.Id);

            var newList = new TodoList
            {
                Id = count + 1,
                Ident = Guid.NewGuid().ToString(),
                Name = name
            };

            return _repository.Add(newList);
        }

        public bool DeleteTodoList(string name)
        {
            return true;
            //_repository.Delete();
        }
    }
}