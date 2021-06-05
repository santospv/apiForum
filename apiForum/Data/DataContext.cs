using apiForum.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiForum.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Cathegory> Cathegory { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Subcathegory> Subcathegory { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<User> User { get; set; }

    }
}
