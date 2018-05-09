using System.Collections.Generic;

namespace LittleBook.Models{
    public class TodoViewModel{
        public IEnumerable<TodoItem> Items{get;set;}
    }
}