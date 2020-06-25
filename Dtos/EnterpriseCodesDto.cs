using System;
using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Dtos
{
    public class EnterpriseCodesDto
    {            
      public Int32 Id { get; set; }  
      public String Name { get; set; }
      public Int64 Nit { get; set; }      
      public Int64 Gln { get; set; }
      public IEnumerable<Code> codes { get; set; }
      
    }

}