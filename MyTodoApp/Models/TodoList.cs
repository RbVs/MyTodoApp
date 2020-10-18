using System.Collections.Generic;

namespace MyTodoApp.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        public string Ident { get; set; }
        public string Name { get; set; }
        public List<Todo> Todos { get; set; }
    }
}