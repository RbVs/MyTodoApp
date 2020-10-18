using System.Collections.Generic;
using MyTodoApp.Models;

namespace MyTodoApp.Repository
{
    public interface IRepository<T> where T : class
    {
        List<TodoList> GetAll();
        bool Add(T entity);
        bool Delete(T entity);
    }
}