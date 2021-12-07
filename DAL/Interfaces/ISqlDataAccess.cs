using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public  interface ISqlDataAccess
    {
        List<T> LoadData<T>(string sql);
        void SaveData<T>(T data, string sql);
        void UpdateData<T>(T data, string sql);
    }
}
