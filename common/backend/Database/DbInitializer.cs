using System;
using Microsoft.EntityFrameworkCore;
using Common.Database.Models;

namespace Common.Database
{
    public class DbInitializer 
    {
      public static async Task InsertInitializeData(CommonContext context)
      {
          await context.Database.EnsureCreatedAsync();
          if ( await context.Owner.AnyAsync() == false)
          {
              var owner = new Owner{ OwnerId = new Guid(), CompanyName = "My Company"};
              await context.Owners.AddAsync(owner);
              await context.Owners.SaveChangesAsync();
          }

          if ( await context.Employees.AnyAsync() == false)
          {
              var employee = new Employee{ EmployeesId = new Guid(), FirstName = "Administrator"};
              await context.Employees.AddAsync(employee);
              await context.Employees.SaveChangesAsync();
          }
      }
    }
}




