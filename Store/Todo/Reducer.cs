using System;
using System.Linq;
using Fluxor;
using TodoBlazor.Store.Todo.Actions;

namespace TodoBlazor.Store.Todo
{
    public static class Reducer
    {
        [ReducerMethod]
        public static TodoState OnAddTodo(TodoState state, AddTodo action)
        {
            var todoList = state.Todos.ToList();
            todoList.Add(action.Todo);
            return new TodoState(todoList);
        }

        [ReducerMethod]
        public static TodoState OnRemoveTodo(TodoState state, RemoveTodo action)
            => new TodoState(state.Todos.Where(x => x.Id != action.Todo.Id).ToList());


        [ReducerMethod]
        public static TodoState OnToogleTodo(TodoState state, ToogleTodo action) {
            var todoList = state.Todos.ToList();
            todoList.First(x => x.Id == action.Todo.Id).Done = !action.Todo.Done;

            return new TodoState(todoList);
        }
    }
}