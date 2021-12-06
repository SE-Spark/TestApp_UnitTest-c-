using DAL.Database;
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
         DatabaseContext cxt;

        public ProcessLogins(DatabaseContext cxt)
        {
            this.cxt = cxt;
        }
        

        public int Delete(Login lg)
        {
            if (!LoginFuncs.ValidateUserParams(lg))
                return 0;
            var toInsert = cxt.logins.Find(lg.Username);
            if (toInsert == null)
                return 0;
            cxt.logins.Remove(lg);
            return cxt.SaveChanges();
        }

        public  int Validate(Login lg)
        {
            if (!LoginFuncs.ValidateUserParams(lg))
                return 0;

            return cxt.logins.Where(l => l.Username == lg.Username && l.Password == lg.Password).Count();
        }

        public int Update(Login lg)
        {
            if (!LoginFuncs.ValidateUserParams(lg))
                return 0;
            var toInsert = cxt.logins.Find(lg.Username);
            if (toInsert == null)
                return 0;
            cxt.logins.Update(lg);
            return cxt.SaveChanges();
        }

        public int Insert(Login lg)
        {
            if (!LoginFuncs.ValidateUserParams(lg))
                return 0;
            var toInsert = cxt.logins.Where(x=>x.Username==lg.Username).FirstOrDefault();
            if (toInsert != null)
                return 0;
            toInsert.Password = lg.Password;
            cxt.logins.Add(toInsert);
            return cxt.SaveChanges();
        }
    }
}
