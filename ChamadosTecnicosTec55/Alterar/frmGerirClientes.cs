using ChamadosTecnicosTec55.Adicionar;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55.Alterar
{
    public partial class frmGerirClientes : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmGerirClientes()
        {
            InitializeComponent();
        }
      //buscar no dao o cliente
      private void ListarClientes()
        {
            //chama o cliente dao
            ClienteDao clientedao =new ClienteDao(_conexao);

            //captura o valor digitado na barra texto TXB
            string busca = txtBuscar.Text.ToString();

            //chama o metodo BuscarCliente do objeto
            DataSet ds = new DataSet(); 
            ds = clientedao.BuscarClientes(busca);  
            // Defeni o DataSource do datagridview
            dgt1.DataSource = ds;
            // defini o menbro do DataSet
            dgt1.DataMember = "Clientes";

        }

        private void frmGerirClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtBuscar.Text !="")
                {
                ListarClientes();

            }
            else{
                MessageBox.Show("Digite algo para Buscar");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formcliente = new frmAdicionarCliente();
            //define o formulario pai
            formcliente.MdiParent = this;
            formcliente.Show();

            //ou  formcliente.ShowDialog(); se ultilizar retirar a linha mdiparetes
        }
    }
}
