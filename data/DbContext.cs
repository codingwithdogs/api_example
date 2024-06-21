using Microsoft.EntityFrameworkCore;
using interview.Models;

namespace interview.Data;

public class ApiContext : DbContext
{
    protected override void OnConfiguring
    (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "InventoryDb");
    }
    public DbSet<Inventory> Inventory { get; set; }
    public DbSet<Item> Items { get; set; }
}
