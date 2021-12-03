using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions
{
    public class LoginFuncs
    {
        public static Boolean ValidateUserParams(Login lg)
        {
            return (!string.IsNullOrWhiteSpace(lg.Username) && !string.IsNullOrWhiteSpace(lg.Password));
        }
    }
}
