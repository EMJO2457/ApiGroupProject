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

        public DbSet<ApiGroupProject.Models.Employee> Employee { get; set; } = default!;
    }
}
