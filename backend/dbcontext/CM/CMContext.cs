using System;
using Microsoft.EntityFrameworkCore;
using CM.Models;

namespace CM
{
    public class CMContext : DbContext
    {
      public CMContext(DbContextOptions<CMContext> options) : base(options) { }

      public DbSet<Emp> Emp { get; set; }
    }
}
