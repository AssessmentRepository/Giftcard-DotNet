using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GiftCards.Tests
{
  public  class DatabaseConnectionTests
    {
        string _dbLocation = "./personalFitnessTracker.db";
        //private readonly IDbConnectionFactory _dbConnectionFactory;

        //public DatabaseConnectionTests(IDbConnectionFactory dbConnectionFactory)
        //{
        //    _dbConnectionFactory = dbConnectionFactory;

        //}

        public async Task<IDbConnection> CreateConnectionAsync()
        {
            var connection = new SqliteConnection($"Data Source={_dbLocation}");
            await connection.OpenAsync();
            return connection;
        }

        [Fact]
        public void Test_For_DatabaseConnection()
        {
            // var connection = _dbConnectionFactory.CreateConnectionAsync();
            var connection = CreateConnectionAsync();
            Assert.NotNull(connection);
        }
    }
}
