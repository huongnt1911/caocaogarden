using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoCao.DataStore.SQL.Dapper.Helpers
{
    public class DataAccess : IDataAccess
    {
        private readonly string connectionString;
        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public T QuerySingle<T, U>(string sql, U parameter)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                return conn.QuerySingle<T>(sql, parameter);
            }
        }

        public T QueryFirst<T, U>(string sql, U parameter)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                return conn.QueryFirst<T>(sql, parameter);
            }
        }

        public List<T> Query<T, U>(string sql, U parameter)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                return conn.Query<T>(sql, parameter).ToList();
            }
        }
        public void ExecuteCommand<U>(string sql, U parameter)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                conn.Execute(sql, parameter);
            }
        }
    }
}
