using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Models.Models
{
    public class AllContext : DbContext
    {

        public AllContext(DbContextOptions<AllContext> options) : base(options)
        {

        }

        public DbSet<post> Post { get; set; }
        public DbSet<photo> Photo { get; set; }
        public DbSet<user> User { get; set; }
        public DbSet<todo> Todo { get; set; }

    }
}


