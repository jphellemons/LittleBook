using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LittleBook.Services;
using LittleBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace LittleBook.Controllers
{
    [Authorize]
    public class TodoController : Controller
    {

        private readonly ITodoItemService _todoItemService;
        private readonly UserManager<ApplicationUser> _userManager;

        public TodoController(ITodoItemService todoItemService, UserManager<ApplicationUser> userManager)
        {
            _todoItemService = todoItemService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if(currentUser == null) return Challenge();

            var todoItems = await _todoItemService.GetIncompleteItemsAsync(currentUser);
            var vm = new LittleBook.Models.TodoViewModel(){
                Items = todoItems
            };
            return View(vm);
        }

        public async Task<IActionResult> AddItem(NewTodoItem newItem)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null) return Unauthorized();

            var successful = await _todoItemService.AddItemAsync(newItem, currentUser);

            if (!successful)
                return BadRequest(new { error = "Could not add item"});

            return Ok();
        }

        public async Task<IActionResult> MarkDone(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null) return Unauthorized();

            var successful = await _todoItemService.MarkDoneAsync(id, currentUser);

            if (!successful)
                return BadRequest();

            return Ok();
        }
    }
}