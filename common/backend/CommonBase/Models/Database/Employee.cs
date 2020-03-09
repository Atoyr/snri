using System;
using Microsoft.EntityFrameworkCore;

namespace Common.CommonBase.Models.Database
{
    public class Employee
    {
      public int id {get;set;}
      public string FirstName {get;set;}
      public string LastName {get;set;}
    }
}
