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

        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<Item> Item { get; set; } = default!;
    }
}
