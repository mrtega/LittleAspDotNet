using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleAspDotNet.Models;

namespace LittleAspDotNet.Services 

{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItems[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItems
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item2 = new TodoItems
            {
                Title = "Build awesome apps",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };
            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
