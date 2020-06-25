using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class SqlCodeRepo : ICodeRepo
    {
        private CommanderContext _context;

        public SqlCodeRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCode(Code cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Code.Add(cmd);
        }

        public void DeleteCode(Code cmd)
        {
            
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Code.Add(cmd);

        }

        public void DeleteCode(Enterprise cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Code> GetAllCodes()
        {
            return _context.Code.ToList();
        }

        public Code GetCodeById(Int32 id)
        {
            return _context.Code.FirstOrDefault( p => p.Id == id);
        }        

        public IEnumerable<Code> GetCodeEnterpriseById(Enterprise id)
        {
            return _context.Code.ToList().Where( p => p.Owner == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCode(Code cmd)
        {
            //Nothing
        }
    }
}