using System;
using WebAPI.Models;

namespace WebAPI.Dtos
{
    public class CodeCreateDto
    {
      public Enterprise Owner { get; set; }

      public String Name { get; set; }
      
      public String Description { get; set; }
         
    }
}