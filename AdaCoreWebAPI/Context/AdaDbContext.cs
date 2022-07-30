using AdaCoreWebAPI.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaCoreWebAPI.Context
{
    public class AdaDbContext : DbContext
    {
        public AdaDbContext(DbContextOptions options)
            : base(options)
        { }
        public DbSet<Policy> Policies { get; set; }
    }
}
