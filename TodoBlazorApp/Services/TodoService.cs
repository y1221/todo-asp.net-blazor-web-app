using Microsoft.EntityFrameworkCore;
using TodoBlazorApp.Data;
using TodoBlazorApp.Models;

namespace TodoBlazorApp.Services
{
    public class TodoService
    {
        private readonly TodoBlazorAppContext _context;

        public TodoService(TodoBlazorAppContext context)
        {
            _context = context;
        }

        public async Task<List<Todo>> GetTodosAsync()
        {
            return await _context.Todo.Where(todo => todo.IsDone == false && todo.IsDelete == false).ToListAsync();
        }

        public async Task<List<Todo>> GetDoneTodosAsync()
        {
            return await _context.Todo.Where(todo => todo.IsDone == true && todo.IsDelete == false).ToListAsync();
        }
    }
}
