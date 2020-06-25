using System;

namespace WebAPI.Dtos
{
    public class EnterpriseReadDto
    {            
      public Int32 Id { get; set; }  
      public String Name { get; set; }

      public Int64 Nit { get; set; }
      
      public Int64 Gln { get; set; }
      
    }

}