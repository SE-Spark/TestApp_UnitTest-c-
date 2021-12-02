using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProcessLogins
    {
        int Validate(Login lg);

        int Update(Login lg);
        int Delete (Login lg);
        int Insert(Login lg);

    }
}
