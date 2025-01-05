using MySqlConnector;
using System.Data;

namespace Aniflix.Repository
{
    public class ConnectionRepository
    {
        private readonly string connString;

        public ConnectionRepository()
        {
            try
            {
                connString = string.Format("Server={0};Uid={1};Pwd={2};Database={3};",
                                            ServerName, UserName, Password, DatabaseName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao configurar a string de conexão: {ex.Message}");
                throw;
            }
        }

        private static readonly string ServerName = "127.0.0.1";
        private static readonly string DatabaseName = "aniflix";
        private static readonly string UserName = "Covenant9687";
        private static readonly string Password = "v*##GLBkB3r9tuUt";

        public IDbConnection GetConnection()
        {
            try
            {
                var connection = new MySqlConnection(connString);
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro ao abrir conexão com o banco de dados: {ex.Message}");
                throw;
            }
        }
    }

}