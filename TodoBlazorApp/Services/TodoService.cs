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

        public async Task ChangeIsDoneAsync(int id, bool isDone)
        {
            var todo = await _context.Todo.FindAsync(id);

            if (todo != null)
            {
                todo.IsDone = isDone;
                _context.Attach(todo).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var todo = await _context.Todo.FindAsync(id);

            if (todo != null)
            {
                todo.IsDelete = true;
                _context.Attach(todo).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
        }

        public async Task CreateAsync(Todo todo)
        {
            _context.Todo.Add(todo);

            await _context.SaveChangesAsync();
        }
    }
}
