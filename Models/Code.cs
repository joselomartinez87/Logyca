using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Code
    {
      [Key]
      public Int32 Id { get; set; }  
      
      [Required]
      public Enterprise Owner { get; set; }

      [Required]
      public String Name { get; set; }
      
      public String Description { get; set; }
      
    }

}