using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDataAccess<T> where T:class
    {
        int Insert(T entity);
        int Update(T entity);
        int Delete(int id);
        List<T> LoadData();
        List<T> Search(T entity);
    }

}
