using System;
using Microsoft.EntityFrameworkCore;
using Common.Database.Models;

namespace Common.Database
{
    public class CommonContext : DbContext
    {
      public CommonContext(DbContextOptions<CommonContext> options) : base(options) { }

      public DbSet<Owner> Owners { get; set; }
      public DbSet<Organaization> Organaization {get; set; }
      public DbSet<Employee> Employees { get; set; }
    }
}
