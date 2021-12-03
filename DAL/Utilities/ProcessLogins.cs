using DAL.Functions;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities
{
    public class ProcessLogins : IProcessLogins
    {
        public int Delete(Login lg)
        {
            throw new NotImplementedException();
        }

        public  int Validate(Login lg)
        {
            LoginFuncs.ValidateUserParams(lg);
            return 1;
        }

        public int Update(Login lg)
        {
            throw new NotImplementedException();
        }

        public int Insert(Login lg)
        {
            throw new NotImplementedException();
        }
    }
}
