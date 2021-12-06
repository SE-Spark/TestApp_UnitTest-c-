using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities
{
    public class DataAccess<T> : IDataAccess<T> where T : class
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> LoadData()
        {
            throw new NotImplementedException();
        }

        public List<T> Search(T entity)
        {
            throw new NotImplementedException();
        }
        public int Update(T entity)
        {
            
            throw new NotImplementedException();
        }
    }
}
