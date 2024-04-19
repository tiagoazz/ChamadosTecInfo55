using ChamadosTecnicosTec55.Adicionar;
using ChamadosTecnicosTec55.Alterar;
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

namespace ChamadosTecnicosTec55
{
    public partial class frmGerirTecnico : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public IFormatProvider Value { get; private set; }
        public frmGerirTecnico()
        {
            InitializeComponent();
        }
        //buscar no dao o cliente
        private void ListarTecnicos()
        {
            //chama o cliente dao
            TecnicoDao tecnicodao = new TecnicoDao(_conexao);

            //captura o valor digitado na barra texto TXB
            string busca = txtBuscar.Text.ToString();

            //chama o metodo BuscarCliente do objeto
            DataSet ds = new DataSet();
            ds = tecnicodao.BuscarTecnicos(busca);
            // Defeni o DataSource do datagridview
            dgt1.DataSource = ds;
            // defini o menbro do DataSet
            dgt1.DataMember = "Tecnicos";

        }

        private void frmGerirTecnicos_Load(object sender, EventArgs e)
        {
            ListarTecnicos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                ListarTecnicos();

            }
            else
            {
                MessageBox.Show("Digite algo para Buscar");
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            var frmaddTecnico = new frmTecnicoAdicionar();
            frmaddTecnico.Show();



            //ou  formcliente.ShowDialog(); se ultilizar retirar a linha mdiparetes
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // verifique se alguma limha selecionada do DGV
            if (dgt1.SelectedRows.Count > 0)
            {
                // obtem o codigo do cliente da linha selecionada 
                int codigo = Convert.ToInt32(dgt1.CurrentRow.Cells[0].Value);
                var frmAlterarTecnico = new frmAlterarTecnico(codigo);
                frmAlterarTecnico.ShowDialog();
                //apos a tela 
                ListarTecnicos();
            }
            else
            {
                //Exibe uma mensagem de aviso se nenhuma linha estiver selecionada 
                MessageBox.Show("Selecione um registro para alteracaoes");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // BOTAO EXCLUIR
            //selecionar data grid, capturar id, enviar para dao, excluir

            if (dgt1.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgt1.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show("Deseja excluir?",
                                                "Pergunta",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {

                    TecnicoDao TecnicoDao = new TecnicoDao(_conexao);
                    TecnicoDao.ExcluirTecnico(codigo);
                    ListarTecnicos();
                }

            }
            else
            {

                MessageBox.Show("Selecione um Registro !");

            }




        }
    }
}


