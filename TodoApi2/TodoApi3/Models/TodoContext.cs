using Microsoft.EntityFrameworkCore;
using TodoApi3.Models;

namespace TodoApi3.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}
