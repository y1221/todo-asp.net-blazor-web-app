using Microsoft.EntityFrameworkCore;
using TodoBlazorApp.Data;
using TodoBlazorApp.Models;

namespace TodoBlazorApp.Seeds
{
    public static class TodoSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TodoBlazorAppContext(serviceProvider.GetRequiredService<DbContextOptions<TodoBlazorAppContext>>()))
            {
                if (context == null || context.Todo == null) throw new ArgumentNullException("Null TodoBlazorAppContext");

                // シード済みであれば、後続処理を行わない
                if (context.Todo.Any()) return;

                context.Todo.AddRange(
                    new Todo { Name = "掃除する" },
                    new Todo { Name = "洗濯する" },
                    new Todo { Name = "買い物行く" },
                    new Todo { Name = "料理作る" },
                    new Todo { Name = "洗い物やる" });
                context.SaveChanges();
            }
        }
    }
}
