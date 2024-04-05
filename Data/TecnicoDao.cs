using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // ADO.net
using System.Data.SqlClient; // ADO para SQL SERVER

namespace Data
{
    public class TecnicoDao
    {
        private string _conexao;

        // Metodo Construtor => Inicializa Objeto buscando Conexao
        public TecnicoDao(string conexao)
        {
            // RECEBA Conexão 
            _conexao = conexao;
        }

        public Exception Message { get; private set; }

        // Inserir Cliente Vulgo XUXAR
        public void IncluiTecnicos(Tecnico tecnicos)
        {
            using(SqlConnection conexaoBd = new SqlConnection(_conexao))
            {
                string sql = "insert into Tecnicos (nome,especialidade,senha,email,obs) values (@nome,@especialidade,@senha,@email,@obs)";

                using (SqlCommand comando = new SqlCommand(sql, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@nome", tecnicos.Nome);
                    comando.Parameters.AddWithValue("@especialidade", tecnicos.Especialidade);
                    comando.Parameters.AddWithValue("@email", tecnicos.Email);
                    comando.Parameters.AddWithValue("@obs", tecnicos.Obs);
                    comando.Parameters.AddWithValue("@senha", tecnicos.Senha);

                    try
                    {
                        conexaoBd.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception )
                    {
                        throw new Exception("Erro ao Incluir Tecnicos:{ ex.Message }");
                    }
                }

            }
        }
    }
}
