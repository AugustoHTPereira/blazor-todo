using System.Collections.Generic;
using Fluxor;
using TodoModel = TodoBlazor.Models.Todo;

namespace TodoBlazor.Store.Todo
{
    public class Feature : Feature<TodoState>
    {
        public override string GetName() => "Todo";

        protected override TodoState GetInitialState()
            => new TodoState(new List<TodoModel>());
    }
}