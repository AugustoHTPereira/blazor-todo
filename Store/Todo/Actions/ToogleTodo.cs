using TodoModel = TodoBlazor.Models.Todo;

namespace TodoBlazor.Store.Todo.Actions
{
    public class ToogleTodo 
    {
        public TodoModel Todo { get; set; }

        public ToogleTodo(TodoModel todo)
        {
            Todo = todo;
        }
    }
}