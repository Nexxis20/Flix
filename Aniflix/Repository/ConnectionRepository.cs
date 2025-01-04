using MySqlConnector;
using System.Data;

namespace Aniflix.Repository
{
    public class ConnectionRepository
    {
        static readonly string serverName = "127.0.0.1";
        static readonly string port = "3306";
        static readonly string databaseName = "aniflix";
        static readonly string userName = "Covenant9687";
        static readonly string password = "v*##GLBkB3r9tuUt";
        private readonly string? connString;

        public ConnectionRepository()
        {
            try
            {
                connString = string.Format("Server={0};Port={1};Database={2};Username={3};Password={4};SSL Mode=Require;Trust Server Certificate=true", serverName, port, databaseName, userName, password);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro", "Erro: " + ex.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public IDbConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }
}