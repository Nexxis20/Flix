using MySqlConnector;
using System.Data;

namespace Aniflix.Repository
{
    public class ConnectionRepository
    {
        static readonly string serverName = "127.0.0.1";
        static readonly string databaseName = "aniflix";
        static readonly string userName = "Covenant9687";
        static readonly string password = "v*##GLBkB3r9tuUt";
        private readonly string? connString;

        public ConnectionRepository()
        {
            try
            {
                connString = string.Format("Server={0};Uid={1};Pwd={2};Database={3};", serverName, userName, password, databaseName);
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