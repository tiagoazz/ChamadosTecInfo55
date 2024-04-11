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

                cliente = clientedao.obtemCliente(codigo);
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
                lbObs.Text = cliente.Obs;
            }
        }
    }
}
