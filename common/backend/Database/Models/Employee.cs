using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Database.Models
{
    public class Employee : EntityBase
    {
      [Key]
      public Guid EmployeeId {get; set; }

      public int EmployeeCode {get; set; }
      public string FirstName {get; set; }
      public string MiddleName {get; set; }
      public string LastName {get; set; }
      public string NickName {get; set; }
      public byte[] EmployeeImage {get; set; }
      public bool IsValid {get; set; }
    }
}
