using backend_webapi.models;
using Microsoft.EntityFrameworkCore;

namespace backend_webapi.MyDb
{
  public class MyDbContext : DbContext
  {
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    public DbSet<Item> Items { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Item>()
          .Property(item => item.Price)
          .HasColumnType("decimal(18,2)");

      modelBuilder.Entity<Order>()
          .Property(order => order.TotalPrice)
          .HasColumnType("decimal(18,2)");

      base.OnModelCreating(modelBuilder);
    }
  }
}
