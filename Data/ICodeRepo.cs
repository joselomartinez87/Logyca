using System;
using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Data
{

    public interface ICodeRepo
    {
        bool SaveChanges();
        IEnumerable<Code> GetAllCodes();
        Code GetCodeById(Int32 id);
        IEnumerable<Code> GetCodeEnterpriseById(Enterprise id);
        void CreateCode(Code cmd);
        void UpdateCode(Code cmd);
        void DeleteCode(Enterprise cmd);
                        
    }

}