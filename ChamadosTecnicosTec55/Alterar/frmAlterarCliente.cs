using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55.Alterar
{
    public partial class frmAlterarCliente : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frmAlterarCliente(int codigo)
        {
           


            InitializeComponent();
            if (codigo > 0)
            {

                // verifica se o codigo e maior que zero
                Cliente cliente = new Cliente();
                ClienteDao clientedao = new ClienteDao(_conexao);

                cliente = clientedao.ObtemCliente(codigo);
                //se o cliente nao foi encontrado
                if (cliente == null)
                {

                    MessageBox.Show("Cliente nao encotrado");
                    this.Close();
                }
                txtid.Text = cliente.CodigoCliente.ToString();
                txbNome.Text = cliente.Nome;
                txbProfissao.Text = cliente.Profissao;
                txbSetor.Text = cliente.Setor;
                txtObs.Text = cliente.Obs;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDao clientedao = new ClienteDao(_conexao);

            try
            {
                cliente.Nome = txbNome.Text;
                cliente.Profissao = txbProfissao.Text;
                cliente.Setor = txbSetor.Text;
                cliente.Obs = txtObs.Text;

                int codigo = Convert.ToInt32(txtid.Text);

                cliente.CodigoCliente = codigo;

                clientedao.AlterarCliente(cliente);
                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
