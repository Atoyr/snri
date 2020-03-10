using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Database.Models
{
    public class Owner : EntityBase
    {
      [Key]
      public Guid OwnerId {get; set; }

      public string CompanyName {get; set; }
      public string CompanyGlobalName {get; set; }
      public byte[] CompanyImage {get; set; }

      public int NowFiscalYear {get; set; }
      public DateTime ValidFromDate {get; set; }
      public DateTime ValidToDate {get; set; }
    }
}

