using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleAspDotNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace LittleAspDotNet.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;
        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
            
        }
        public async Task<IActionResult> Index()
        {
            var items = await _todoItemService.GetIncompleteItemsAsync();
            return View();
        }
    }
}