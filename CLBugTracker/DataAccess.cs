using BugTrackerLibrary;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Bugtracker
{
    public class DataAccess : IDataAccess
    {
        private readonly IConfiguration _config;

        public string ConnectionStringName { get; set; } = "DefaultConnection";

        public DataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<T>> LoadData<T, U>(string sqlCommand, U parameters)
        {
            string sqlconnectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(sqlconnectionString))
            {
                var data = await connection.QueryAsync<T>(sqlCommand, parameters);

                return data.ToList();
            }
        }

        public async Task SaveData<T>(string sqlCommand, T parameters)
        {
            string sqlConnectionString = _config.GetConnectionString(ConnectionStringName);
            using (IDbConnection connection = new SqlConnection(sqlConnectionString))
            {
                await connection.ExecuteAsync(sqlCommand, parameters);
            }
        }
    }
}
