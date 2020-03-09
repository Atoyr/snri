using System;
using System.Collection.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.CommonBase.Models.Database
{
    public class Department : TableBase
    {
      [Key]
      public Guid DepartmentId { get; set; }
    
      public string DepartmentCode { get; set; }
      public string DepartmentName { get; set; }
      public string GlobalDepartmentName { get; set; }

      public int DepartmentLevel { get; set; }
      public string ParentDepartmentCode { get; set; }

      public int OrganaizationId { get; set; }
      public Organaization Organaization { get; set; }
    }
}



