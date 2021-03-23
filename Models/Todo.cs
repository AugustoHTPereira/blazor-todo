using System;

namespace TodoBlazor.Models
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }

        public override string ToString()
            => Name;
    }
}