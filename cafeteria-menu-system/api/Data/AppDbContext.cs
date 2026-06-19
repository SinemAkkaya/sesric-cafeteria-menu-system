
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Data;

// apppDbcontext inherits database features from ef core Dbcontext class
public class AppDbContext : DbContext
{
    //this constructor receives the database connection settings
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) {
    }

    // this represents the MenuItems table in the database
    public DbSet<MenuItem> MenuItems { get; set; } = null!; //means MenuItems can be empty in the beginning
}