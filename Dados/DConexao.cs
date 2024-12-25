using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Dados
{
    public class ConnectiontoSql
    {
        // Tornando o campo readonly
        private readonly string ConnectionString;

        // Construtor define a string de conexão
        public ConnectiontoSql()
        {
            ConnectionString = @"Server=GHDSE-PC8\MSSQLSERVERT;Database=dbContactos;Integrated Security=True;";
        }

        // Método para obter a conexão SQL
        public SqlConnection GetSqlConnection()
        {
            try
            {
                // Usando 'using' para garantir que a conexão seja fechada automaticamente
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    return connection; // Retorna a conexão aberta

                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Erro ao conectar ao banco de dados: {ex.Message}");
            }
            
        }
    }
}









