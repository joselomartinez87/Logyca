using System;
using WebAPI.Models;

namespace WebAPI.Dtos
{
    public class CodeReadDto
    {
      
      public Int32 Id { get; set; }        
      public Enterprise Owner { get; set; }
      public String Name { get; set; }
      public String Description { get; set; }
      
    }

}