using System;
using Microsoft.EntityFrameworkCore;

namespace Common.CommonBase.Models.Database
{
    public class TableBase
    {
      public string CreatedBy {get; set; }
      public DateTime CreateDate {get; set; }
      public string ModifyBy {get; set; }
      public DateTime ModifyDate {get; set; }
    }
}
