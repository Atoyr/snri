using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.CommonBase.Models.Database
{
    public class Organaization : TableBase
    {
      [Key]
      public Guid OrganaizationId {get; set; }

      public string DepartmentCode {get; set; }
      public string DepartmentName {get; set; }
      public string GlobalDepartmentName {get; set; }
      public int DepartmentLevel {get; set; }
      public string ParentDepartmentCode {get; set; }
    }
}


