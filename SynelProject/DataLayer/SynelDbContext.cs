using Microsoft.EntityFrameworkCore;
using SynelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynelProject.DataLayer
{
    public class SynelDbContext : DbContext
    {
        public SynelDbContext(DbContextOptions<SynelDbContext> options)
            :base(options)
        { 
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
