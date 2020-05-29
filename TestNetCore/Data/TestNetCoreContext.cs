using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestNetCore.Models;

namespace TestNetCore.Data
{
    public class TestNetCoreContext : DbContext
    {
        public TestNetCoreContext (DbContextOptions<TestNetCoreContext> options)
            : base(options)
        {
        }


        public DbSet<TestNetCore.Models.Movie> Movie { get; set; }
    }
}
