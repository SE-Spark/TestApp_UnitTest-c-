using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DAL.Interfaces;

namespace DAL.Database
{
    public static class SqlDataAccess
    {
        public static string GetConnectionString(string constr_name="TaskAppDb")
        {
            return ConfigurationManager.ConnectionStrings["TaskAppDb"].ConnectionString;
        }
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection (GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql,data);
            }
        }
    }
}
