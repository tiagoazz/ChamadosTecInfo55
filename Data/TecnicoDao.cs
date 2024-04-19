using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // ADO.net
using System.Data.SqlClient; // ADO para SQL SERVER

namespace Data
{
    // Metodo Construtor => Inicializa Objeto buscando Conexao


    public class TecnicoDao
    {
        private string _conexao;

        public TecnicoDao(string conexao)
        {
            _conexao = conexao;
        }

        public void IncluirTecnico(Tecnico tecnico)
        {
            try
            {
                using (SqlConnection conexaoBd = new SqlConnection(_conexao))
                {
                    string sql = "insert into Tecnicos (nome, especialidade, email,senha, obs) values (@nome, @especialidade,@email, @senha, @obs)";

                    using (SqlCommand comando = new SqlCommand(sql, conexaoBd))
                    {
                        comando.Parameters.AddWithValue("@nome", tecnico.Nome);
                        comando.Parameters.AddWithValue("@especialidade", tecnico.Especialidade);
                        comando.Parameters.AddWithValue("@email", tecnico.Email);
                        comando.Parameters.AddWithValue("@senha", tecnico.Senha);
            
                        comando.Parameters.AddWithValue("@obs", tecnico.Obs);

                        conexaoBd.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Incluir Técnico: {ex.Message}", ex);
            }
        }

        public DataSet BuscarClientes(string pesquisa = "")
        {
            try
            {
                const string query = "Select * From Tecnicos Where Nome like @pesquisa";

                using (SqlConnection conexaoBd = new SqlConnection(_conexao))
                using (SqlCommand comando = new SqlCommand(query, conexaoBd))
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    string parametroPesquisa = $"%{pesquisa}%";
                    comando.Parameters.AddWithValue("@pesquisa", parametroPesquisa);

                    conexaoBd.Open();
                    var dsTecnicos = new DataSet();
                    adaptador.Fill(dsTecnicos, "Tecnicos");

                    return dsTecnicos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar técnicos: {ex.Message}", ex);
            }
        }

        public Tecnico ObterTecnico(int codigoTecnico)
        {
            try
            {
                const string query = @"select * from Tecnicos where CodigoTecnico = @CodigoTecnico";
                Tecnico tecnico = null;

                using (SqlConnection conexaoBd = new SqlConnection(_conexao))
                using (SqlCommand comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@CodigoTecnico", codigoTecnico);
                    conexaoBd.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tecnico = new Tecnico
                            {
                                CodigoTecnico = Convert.ToInt32(reader["CodigoTecnico"]),
                                Nome = reader["Nome"].ToString(),
                                Especialidade = reader["Especialidade"].ToString(),
                                Senha = reader["Senha"].ToString(),
                                Email = reader["Email"].ToString(),
                                Obs = reader["Obs"].ToString()
                            };
                        }
                    }
                }

                return tecnico;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter o técnico: {ex.Message}", ex);
            }
        }

        public void AlterarTecnico(Tecnico tecnico)
        {
            try
            {
                const string query = @"update Tecnicos set Nome=@Nome, Especialidade=@Especialidade, Senha=@Senha, Email=@Email, Obs=@Obs where CodigoTecnico=@CodTecnico";

                using (SqlConnection conexao = new SqlConnection(_conexao))
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", tecnico.Nome);
                    comando.Parameters.AddWithValue("@Especialidade", tecnico.Especialidade);
                    comando.Parameters.AddWithValue("@Senha", tecnico.Senha);
                    comando.Parameters.AddWithValue("@Email", tecnico.Email);
                    comando.Parameters.AddWithValue("@Obs", tecnico.Obs);
                    comando.Parameters.AddWithValue("@CodTecnico", tecnico.CodigoTecnico);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao alterar o técnico: {ex.Message}", ex);
            }
        }

        public void ExcluirTecnico(int codigoTecnico)
        {
            try
            {
                const string query = @"delete from Tecnicos where CodigoTecnico = @CodigoTecnico";

                using (SqlConnection conexaoBd = new SqlConnection(_conexao))
                using (SqlCommand comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@CodigoTecnico", codigoTecnico);
                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir o técnico: {ex.Message}", ex);
            }
        }

        public void IncluirTecnicos(Tecnico tecnicos)
        {
            throw new NotImplementedException();
        }

        public void AlterarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void IncluirClientes(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public DataSet BuscarTecnicos(string busca)
        {
            throw new NotImplementedException();
        }
    }
}


/* public TecnicoDao(string conexao)
 {
     // RECEBA Conexão 
     _conexao = conexao;
 }

 public Exception Message { get; private set; }

 // Inserir Cliente Vulgo XUXAR
 public void IncluiTecnicos(Tecnico tecnicos)
 {
     using (SqlConnection conexaoBd = new SqlConnection(_conexao))
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
             catch (Exception)
             {
                 throw new Exception("Erro ao Incluir Tecnicos:{ ex.Message }");
             }
         }

     }
 }

 public void ExcluirTecnico(int codigoTecnico)
 {
     const string query = @"delete from Tecnicos where CodigoTecnico = @CodigoTecnico";


     try
     {
         using (var conexaoBd = new SqlConnection(_conexao))
         using (var comando = new SqlCommand(query, conexaoBd))
         {
             comando.Parameters.AddWithValue("@CodigoTecnico", codigoTecnico);
             conexaoBd.Open();
             comando.ExecuteNonQuery();



         }

     }
     catch (Exception ex)
     {
         throw new Exception($"Erro ao excluir{ex.Message}", ex);
     }
 }
}
}
*/


/*
    public class TecnicoDao
    {
        private string _conexao;

        public TecnicoDao(string conexao)
        {
            _conexao = conexao;
        }

        public void IncluirTecnicos(Tecnico tecnicos)
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            {
                string sql = "insert into Tecnicos (nome, especialidade, senha, email, obs) values (@nome, @especialidade, @senha, @email, @obs)";

                using (SqlCommand comando = new SqlCommand(sql, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@nome", tecnicos.Nome);
                    comando.Parameters.AddWithValue("@especialidade", tecnicos.Especialidade);
                    comando.Parameters.AddWithValue("@senha", tecnicos.Senha);
                    comando.Parameters.AddWithValue("@email", tecnicos.Email);
                    comando.Parameters.AddWithValue("@obs", tecnicos.Obs);

                    try
                    {
                        conexaoBd.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Erro ao Incluir Técnico: {ex.Message}");
                    }
                }
            }
        }

        public void ExcluirTecnico(int codigoTecnico)
        {
            const string query = @"delete from Tecnicos where CodigoTecnico = @CodigoTecnico";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@CodigoTecnico", codigoTecnico);
                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir técnico: {ex.Message}", ex);
            }
        }

        public Tecnico ObtemTecnico(int codigoTecnico)
        {
            const string query = @"select * from Tecnicos where CodigoTecnico = @CodigoTecnico";
            Tecnico tecnico = null;

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@CodigoTecnico", codigoTecnico);
                    conexaoBd.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tecnico = new Tecnico
                            {
                                CodigoTecnico = Convert.ToInt32(reader["CodigoTecnico"]),
                                Nome = reader["Nome"].ToString(),
                                Especialidade = reader["Especialidade"].ToString(),
                                Senha = reader["Senha"].ToString(),
                                Email = reader["Email"].ToString(),
                                Obs = reader["Obs"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter técnico: {ex.Message}", ex);
            }

            return tecnico;
        }
    }
}*/