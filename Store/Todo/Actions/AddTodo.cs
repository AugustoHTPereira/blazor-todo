using System;
using TodoModel = TodoBlazor.Models.Todo;

namespace TodoBlazor.Store.Todo.Actions
{
    public class AddTodo
    {
        public TodoModel Todo;
        public AddTodo(string name)
        {
            Todo = new TodoModel { Name = name, Done = false, Id = Guid.NewGuid() };
        }
    }
}