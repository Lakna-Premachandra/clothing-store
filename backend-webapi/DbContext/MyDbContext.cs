using backend_webapi.models;
using Microsoft.EntityFrameworkCore;

namespace backend_webapi.MyDbContext
{
public class MyDbContext : DbContext
{
  public MyDbContext(DbContextOptions <MyDbContext> options) : base(options) { }
  public DbSet <Item> Items {get; set;}
  public DbSet <Category> Categories {get; set;}
  public DbSet <Order> Orders {get; set;}
  public DbSet <User> Users {get; set;}

}
}
