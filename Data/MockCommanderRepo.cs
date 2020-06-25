using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var command = new List<Command>
            {
                new Command{ Id=0, HowTo="Boilan egg", Line="Boil water", Platform="Kettle & pan"},
                new Command{ Id=1, HowTo="Boilan egg1", Line="Boil water", Platform="Kettle & pan1"},
                new Command{ Id=2, HowTo="Boilan egg2", Line="Boil water", Platform="Kettle & pan2"}
            };

            return command;
        }

        public Command GetCommandById(int id)
        {
            return new Command{ Id=0, HowTo="Boilan egg", Line="Boil water", Platform="Kettle & pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }

}