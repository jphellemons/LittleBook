using System;
using System.ComponentModel.DataAnnotations;

namespace LittleBook.Models{
    public class NewTodoItem{
        [Required]
        public string Title { get; set; }
        
    }
}