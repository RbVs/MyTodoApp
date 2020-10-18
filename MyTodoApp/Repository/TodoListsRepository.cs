using System;
using System.Collections.Generic;
using MyTodoApp.Models;
using MyTodoApp.Services;

namespace MyTodoApp.Repository
{
    public class TodoListsRepository : IRepository<TodoList>
    {
        private readonly ICachedData _cachedData;

        public TodoListsRepository(ICachedData cachedData)
        {
            _cachedData = cachedData;
        }

        public List<TodoList> GetAll()
        {
            return _cachedData.TodoLists;
        }

        public bool Add(TodoList entity)
        {
            try
            {
                _cachedData.TodoLists.Add(entity);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(TodoList entity)
        {
            try
            {
                _cachedData.TodoLists.Remove(entity);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}