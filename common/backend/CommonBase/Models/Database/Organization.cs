using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.CommonBase.Models.Database
{
    public class Organaization : TableBase
    {
      [Key]
      public Guid OrganaizationId { get; set; }

      public string OrganaizationName { get; set; }
      public List<Department> Departments { get; set; }
    }
}


