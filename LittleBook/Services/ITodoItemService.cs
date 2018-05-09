using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LittleBook.Models;

namespace LittleBook.Services{
    public interface ITodoItemService{
        Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync(ApplicationUser user);

        Task<bool> AddItemAsync(NewTodoItem newItem, ApplicationUser user);
        Task<bool> MarkDoneAsync(Guid id, ApplicationUser user);
    }
}