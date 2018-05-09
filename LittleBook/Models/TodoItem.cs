using System;

namespace LittleBook.Models
{
    public class TodoItem{
        public Guid Id { get; set; }

        public bool IsDone { get; set; }

        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }

        public string OwnerId {get;set;}
        
    }
}