using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dtos
{
    public class EnterpriseCreateDto
    { 
      
      [Required]
      public String Name { get; set; }

      public Int64 Nit { get; set; }
      
      [Required]
      public Int64 Gln { get; set; }
         
    }
}