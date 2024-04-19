using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // ADO.net
using System.Data.SqlClient; // ADO para SQL SERVER

namespace Data
{
    public class ClientesDao
    {
        private string _conexao;

        // Metodo Construtor => Inicializa Objeto buscando Conexao
        public ClientesDao(string conexao)
        {
            // RECEBA Conexão 
            _conexao = conexao;
        }

        // Inserir Cliente Vulgo XUXAR
        public void IncluiCliente(Cliente cliente)
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            {
                string sql = "insert into Clientes (nome,profissao,setor,obs) values (@nome,@profissao,@setor,@obs)";

                using (SqlCommand comando = new SqlCommand(sql, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@nome", cliente.Nome);
                    comando.Parameters.AddWithValue("@profissao", cliente.Profissao);
                    comando.Parameters.AddWithValue("@setor", cliente.Setor);
                    comando.Parameters.AddWithValue("@obs", cliente.Obs);

                    try
                    {
                        conexaoBd.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao Incluir Cliente:" + ex.Message);
                    }
                }

            }

        }
        public DataSet BuscarClientes(string pesquisa = "")
        {

            //constante com o codigo SQL que faz busca a partir do texto
            const string query = "Select * From Clientes Where Nome like @pesquisa";

            //Validar Erro
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                using (var adaptador = new SqlDataAdapter(comando))
                {

                    string parametroPesquisa = $"%{pesquisa}%";
                    comando.Parameters.AddWithValue("@pesquisa", parametroPesquisa);
                    conexaoBd.Open();
                    var dsClientes = new DataSet();
                    adaptador.Fill(dsClientes, "Clientes");
                    return dsClientes;

                }
            } catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar clientes:{ex.Message}");
            }




        }
        public Cliente ObtemCliente(int codigoCliente)
        {
            //Define o SQl para obter o cliente 
            const string query = @"select * from Clientes where CodigoCliente = @CodigoCliente";

            Cliente cliente = null;

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@CodigoCliente", codigoCliente);
                    conexaoBd.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new Cliente
                            {

                                CodigoCliente = Convert.ToInt32(reader["CodigoCliente"]),
                                Nome = reader["Nome"].ToString(),
                                Profissao = reader["Profissao"].ToString(),
                                Obs = reader["Obs"].ToString(),
                                Setor = reader["Setor"].ToString()
                            };
                        }

                    }
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter o cliente{ex.Message}", ex);
            }
            return cliente;

        }



        public void AlterarCliente(Cliente cliente)
        {
            const string query = @"update Clientes set Nome=@Nome, Setor = @Setor, Profissao = @Profissao,Obs=@Obs where CodigoCliente = @CodCliente";
            try
            {
                using (var conexao = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", cliente.Nome);
                    comando.Parameters.AddWithValue("@Setor", cliente.Setor);
                    comando.Parameters.AddWithValue("@Profissao", cliente.Profissao);
                    comando.Parameters.AddWithValue("@Obs", cliente.Obs);
                    comando.Parameters.AddWithValue("@CodCliente", cliente.CodigoCliente);    
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }

            }
            catch (Exception ex) {
                throw new Exception($"Erro {ex}");

            
        }

            //excluir clientes 

          

        }
        public void ExcluirCliente(int codigoCliente)
        {
            const string query = @"delete from Clientes where CodigoCliente = @CodigoCliente";


            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@codigoCliente", codigoCliente);
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



