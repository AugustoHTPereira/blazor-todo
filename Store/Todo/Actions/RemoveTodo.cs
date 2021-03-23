using TodoModel = TodoBlazor.Models.Todo;

namespace TodoBlazor.Store.Todo.Actions
{
    public class RemoveTodo
    {
        public TodoModel Todo { get; }

        public RemoveTodo(TodoModel todo)
        {
            Todo = todo;
        }
    }
}