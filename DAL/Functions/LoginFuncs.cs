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
        public static void ValidateUserParams(Login lg)
        {
            if (string.IsNullOrWhiteSpace(lg.Username))
            {
                throw new ArgumentException("invalid username,cannot be null", "Username");
            }
            else if (string.IsNullOrWhiteSpace(lg.Password))
            {
                throw new ArgumentException("invalid Password,cannot be null", "Password");
            }

        }
    }
}
