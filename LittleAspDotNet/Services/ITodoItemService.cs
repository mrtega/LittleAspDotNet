using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LittleAspDotNet.Models;

namespace LittleAspDotNet.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}
