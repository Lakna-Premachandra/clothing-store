using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_webapi.MyDb;
using backend_webapi.models;

namespace backend_webapi
{
    public class Seed
    {
        private readonly MyDbContext _context;

        public Seed(MyDbContext context)
        {
            _context = context;
        }

        public void SeedDataContext()
        {
            // Seed Users
            if (!_context.Users.Any())
            {
                var users = new List<User>
                {
                    new User
                    {
                        UserName = "User1",
                        Email = "user1@example.com",
                        PhoneNo = "123456789",
                        UserType = "customer"
                    },
                    new User
                    {
                        UserName = "User2",
                        Email = "user2@example.com",
                        PhoneNo = "987654321",
                        UserType = "admin"
                    }
                };

                _context.Users.AddRange(users);
                _context.SaveChanges();
            }

            // Seed Categories
            if (!_context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category
                    {
                        categoryName = "Category 1",
                        categoryDescription = "Description for Category 1"
                    },
                    new Category
                    {
                        categoryName = "Category 2",
                        categoryDescription = "Description for Category 2"
                    }
                };

                _context.Categories.AddRange(categories);
                _context.SaveChanges();
            }

            // Seed Orders
            if (!_context.Orders.Any())
            {
                var orders = new List<Order>
                {
                    new Order
                    {
                        OrderDate = DateTime.Now,
                        TotalPrice = 100.0m,
                        UserId = 1 // Assuming there's a user with ID 1
                    },
                    new Order
                    {
                        OrderDate = DateTime.Now.AddDays(-1),
                        TotalPrice = 150.0m,
                        UserId = 2 // Assuming there's a user with ID 2
                    }
                };

                _context.Orders.AddRange(orders);
                _context.SaveChanges();
            }

            // Seed Items
            if (!_context.Items.Any())
            {
                var items = new List<Item>
                {
                    new Item
                    {
                        ItemName = "Item 1",
                        ItemDescription = "Description for Item 1",
                        Quantity = 10,
                        Price = 20.0m,
                        CategoryId = 1, 
                        OrderId = 1 
                    },
                    new Item
                    {
                        ItemName = "Item 2",
                        ItemDescription = "Description for Item 2",
                        Quantity = 5,
                        Price = 15.0m,
                        CategoryId = 2,
                        OrderId = 2 
                    }
                };

                _context.Items.AddRange(items);
                _context.SaveChanges();
            }
        }
    }
}



