using System;
using System.Data.SqlClient;

namespace Data
{
    public class TecnicoDaoBase
    {
        private string _conexao;

        // Inserir Cliente Vulgo XUXAR
        public void IncluiCliente(Tecnico tecnico)
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            {
                string sql = "insert into Clientes (nome,profissao,setor,obs) values (@nome,@profissao,@setor,@obs)";

                using (SqlCommand comando = new SqlCommand(sql, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@nome", tecnico.Nome);
                    comando.Parameters.AddWithValue("@especialidade", tecnico.Especialidade);
                    comando.Parameters.AddWithValue("@email", tecnico.Email);
                    comando.Parameters.AddWithValue("@obs", tecnico.Obs);
                    comando.Parameters.AddWithValue("@senha", tecnico.Senha);

                    try
                    {
                        conexaoBd.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception )
                    {
                        throw new Exception("Erro ao Incluir Cliente: { ex.Message }");
                    }
                }

            }
        }
    }
}