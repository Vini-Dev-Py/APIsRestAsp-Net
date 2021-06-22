using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApisWithAspNet.Model
{
    public class DBContext : DbContext
    {
        public DBContext()
        {

        }

        public DBContext(DbContextOptions<DBContext> options) : base(options) {}

        public DbSet<Person> People { get; set; }
    }
}
