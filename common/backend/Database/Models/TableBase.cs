using System;
using Microsoft.EntityFrameworkCore;

namespace Common.Database.Models
{
    public class EntityBase
    {
      public string CreatedBy {get; set; }
      public DateTime CreateAt {get; set; }
      public string ModifyBy {get; set; }
      public DateTime ModifyAt {get; set; }
      public string SystemCreatedBy {get; set; }
      public DateTime SystemCreateAt {get; set; }
      public string SystemModifyBy {get; set; }
      public DateTime SystemModifyAt {get; set; }
    }
}
