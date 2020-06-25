using System;
using System.ComponentModel.DataAnnotations;
using WebAPI.Models;

namespace WebAPI.Dtos
{
    public class CodeUpdateDto
    {
      
      [Required]
      public Enterprise Owner { get; set; }

      [Required]
      public String Name { get; set; }      
      public String Description { get; set; }
         
    }
}