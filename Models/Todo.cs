using System;
using System.ComponentModel.DataAnnotations;

namespace TodoBlazor.Models
{
    public class Todo
    {
        public Guid Id { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "The Name min length is 10")]
        [MaxLength(100, ErrorMessage = "The Name max length is 100")]
        public string Name { get; set; }
        public bool Done { get; set; }

        public override string ToString()
            => Name;
    }
}