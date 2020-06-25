using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Dtos;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class SqlEnterpriseRepo : IEnterpriseRepo
    {
        private CommanderContext _context;

        public SqlEnterpriseRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateEnterprise(Enterprise cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEnterprise(Enterprise cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Enterprise> GetAllEnterprises()
        {
            return _context.Enterprise.ToList();
        }

        public Enterprise GetEnterpriseById(int id)
        {
            return _context.Enterprise.FirstOrDefault(p => p.Id == id);
        }

        public EnterpriseCodesDto GetEnterpriseByNit(Int64 nit)
        {
            var enterprise = _context.Enterprise.FirstOrDefault(p => p.Nit == nit);
            var codes = _context.Code.ToList().Where(p => p.Owner == enterprise);
            var res = new EnterpriseCodesDto();
            res.Id = enterprise.Id;
            res.Name = enterprise.Name;
            res.Nit = enterprise.Nit;
            res.Gln = enterprise.Gln;
            res.codes = codes;

            return res;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateEnterprise(Enterprise cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}