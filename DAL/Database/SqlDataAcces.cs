using DAL.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database
{
    public class SqlDataAcces : ISqlDataAccess
    {
        public List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn= new SqlConnection(LoadConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public void SaveData<T>(T data, string sql)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute(sql, data);
            }
        }

        public void UpdateData<T>(T data, string sql)
        {
            using (IDbConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Execute(sql, data);
            }
        }
        private string LoadConnectionString(string con_str = "TaskAppDb")
        {
            return ConfigurationManager.ConnectionStrings[con_str].ConnectionString;
        }
    }
}
