using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Common.Database.Models;

namespace Common.Database
{
    public class DbInitializer 
    {
      public static async Task InsertInitializeData(CommonContext context)
      {
          await context.Database.EnsureCreatedAsync();
          if ( await context.Owners.AnyAsync() == false)
          {
              var owner = new Owner{ OwnerId = new Guid(), CompanyName = "My Company"};
              await context.Owners.AddAsync(owner);
          }

          if ( await context.Employees.AnyAsync() == false)
          {
              var employee = new Employee{ EmployeeId = new Guid(), FirstName = "Administrator"};
              await context.Employees.AddAsync(employee);
          }
          await context.SaveChangesAsync();
      }
    }
}




