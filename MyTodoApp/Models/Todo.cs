using System;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
    }
}