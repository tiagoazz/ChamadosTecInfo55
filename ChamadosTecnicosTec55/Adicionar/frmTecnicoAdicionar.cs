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

namespace ChamadosTecnicosTec55.Adicionar
{
    public partial class frmTecnicoAdicionar : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;


        public frmTecnicoAdicionar()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {


            txbNome.Clear();
            txbObs.Clear();
            txbEspecialidade.Clear();
            txbEmail.Clear();
            txbSenha.Clear();


        }

        private void frmTecnicoAdicionar_Load(object sender, EventArgs e)
        {
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Chama o objeto Cliente
            Tecnico tecnicos = new Tecnico();
            TecnicoDao tecnicodao = new TecnicoDao(_conexao);

            if (string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbObs.Text) || string.IsNullOrWhiteSpace(txbEspecialidade.Text) || string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbSenha.Text))
            {
                MessageBox.Show("Por Favor preencher corretamente ??");
            }
            else


            {
                //toda vez que mexer com bd usar o comando ''try''

                try
                {
                    //preenche o objeto tecnicos

                    tecnicos.Nome = txbNome.Text.ToUpper();
                    tecnicos.Especialidade = txbEspecialidade.Text.ToUpper();
                    tecnicos.Email = txbEmail.Text.ToUpper();
                    tecnicos.Obs = txbObs.Text.ToUpper();
                    tecnicos.Senha = txbSenha.Text.ToUpper();

                    //Chama o dao para incluir o tecnico
            

                    tecnicodao.IncluiTecnicos(tecnicos);

                    MessageBox.Show("Cadastrado com sucesso !");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar "+ex , "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

    


