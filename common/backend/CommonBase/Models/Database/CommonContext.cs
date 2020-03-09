using System;
using Microsoft.EntityFrameworkCore;

namespace Common.CommonBase.Models.Database
{
    public class CommonContext : DbContext
    {
      public CommonContext(DbContextOptions<CommonContext> options) : base(options) { }

      public DbSet<Employee> Employees { get; set; }
    }
}
