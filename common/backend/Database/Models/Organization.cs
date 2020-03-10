using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Database.Models
{
    public class Organaization : EntityBase
    {
      [Key]
      public Guid OrganaizationId { get; set; }

      public string OrganaizationName { get; set; }
      public List<Department> Departments { get; set; }
    }
}


