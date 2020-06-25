using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class CommanderContext : DbContext
    {

        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        public DbSet<Enterprise> Enterprise { get; set; }

        public DbSet<Code> Code { get; set; }
        
    }
    
}