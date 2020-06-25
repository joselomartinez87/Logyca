using System;
using System.Collections.Generic;
using WebAPI.Dtos;
using WebAPI.Models;

namespace WebAPI.Data
{

    public interface IEnterpriseRepo
    {
        bool SaveChanges();
        IEnumerable<Enterprise> GetAllEnterprises();
        Enterprise GetEnterpriseById(Int32 id);
        EnterpriseCodesDto GetEnterpriseByNit(Int64 nit);
        void CreateEnterprise(Enterprise cmd);
        void UpdateEnterprise(Enterprise cmd);
        void DeleteEnterprise(Enterprise cmd);
                        
    }

}