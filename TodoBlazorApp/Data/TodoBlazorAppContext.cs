using Microsoft.EntityFrameworkCore;
using TodoBlazorApp.Models;

namespace TodoBlazorApp.Data
{
    public class TodoBlazorAppContext : DbContext
    {
        public TodoBlazorAppContext (DbContextOptions<TodoBlazorAppContext> options)
            : base(options) 
        {
        }

        public DbSet<Todo> Todo { get; set; } = default!;
    }
}
