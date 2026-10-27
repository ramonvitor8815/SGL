using MySql.Data.MySqlClient;

namespace SGL
{
    public static class Conexao
    {
        private const string StringConexao =
            "Server=localhost;Port=3306;Database=projeto_logistica;Uid=root;Pwd=password;";

        public static MySqlConnection Criar()
        {
            return new MySqlConnection(StringConexao);
        }
    }
}