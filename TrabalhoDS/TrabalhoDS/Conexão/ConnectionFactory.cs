using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TrabalhoDS.Conexão
{
    public class ConnectionFactory
    {
        public static MySqlConnection getConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["locadora_2iiem_1sem_2018"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
