using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiGroupProject.Models;

namespace ApiGroupProject.Data
{
    public class GroupDbContext : DbContext
    {
        public GroupDbContext (DbContextOptions<GroupDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Item> Items { get; set; } = default!;
        public DbSet<ApiGroupProject.Models.Orderline> Orderline { get; set; } = default!;
        public DbSet<ApiGroupProject.Models.Order> Order { get; set; } = default!;
    }
}
