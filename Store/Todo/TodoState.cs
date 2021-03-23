using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TodoModel = TodoBlazor.Models.Todo;

namespace TodoBlazor.Store.Todo
{
    public record TodoState
    {
        public IReadOnlyCollection<TodoModel> Todos { get; set; }

        public TodoState(IList<TodoModel> todos)
        {
            Todos = todos.ToArray();
        }
    }
}