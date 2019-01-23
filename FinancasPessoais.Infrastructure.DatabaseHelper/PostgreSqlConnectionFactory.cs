using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancasPessoais.Infrastructure.DatabaseHelper
{
    public interface IPostgreSqlConnectionFactory
    {
        NpgsqlConnection CreateConnection(string name);
    }

    public class PostgreSqlConnectionFactory
    {
        private readonly IConfiguration configuration;

        public PostgreSqlConnectionFactory(IConfiguration config)
        {
            this.configuration = config;
        }

        public NpgsqlConnection CreateConnection(string connectionName)
        {
            return new NpgsqlConnection(configuration.GetConnectionString(connectionName));
        }
    }
}
