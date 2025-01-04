using System.Data;

namespace Aniflix.Data
{
    public class ConnectionFactory
    {
        static readonly string serverName = "127.0.0.1";
        static readonly string port = "5432";
        static readonly string databaseName = "aniflix";
        static readonly string userName = "OverHung6393";
        static readonly string password = "Skyline-Freeware-Snugly-Barrier7-Expand-Monopoly";
        private readonly string connString;

        public ConnectionFactory()
        {
            connString = String.Format("Server={0};Port={1};Database={2};Username={3};Password={4};SSL Mode=Require;Trust Server Certificate=true", serverName, port, databaseName, userName, password);
        }
        public IDbConnection GetConnection()
        {
            return new Npgsql.NpgsqlConnection(connString);
        }
    }
}