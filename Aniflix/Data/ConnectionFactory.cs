using Npgsql;
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
        readonly string connString;

        public ConnectionFactory()
        {
            connString = String.Format("Server={0};Port={1};Database={2};Username={3};Password={4};SSL Mode=Require;Trust Server Certificate=true", serverName, port, databaseName, userName, password);
        }
        public DataTable GetFilmes()
        {
            var dt = new DataTable();
            var pgsqlConnection = new NpgsqlConnection(connString);
            try
            {
                pgsqlConnection.Open();
                var cmd = new NpgsqlCommand("get_filmes", pgsqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                var dr = cmd.ExecuteReader();
                dt.Load(dr);
                pgsqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message.ToString());
            }
            return dt;
        }
    }
}