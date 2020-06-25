using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Enterprise
    {
      [Key]
      public Int32 Id { get; set; }  
      
      [Required]
      public String Name { get; set; }

      public Int64 Nit { get; set; }
      
      [Required]
      public Int64 Gln { get; set; }
      
    }

}