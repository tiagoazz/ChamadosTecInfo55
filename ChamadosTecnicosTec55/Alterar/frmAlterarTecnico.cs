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
    public partial class frmAlterarTecnico : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmAlterarTecnico(int codigo)
        {
            InitializeComponent();
            if (codigo > 0)
            {

                // verifica se o codigo e maior que zero
                Tecnico tecnico = new Tecnico();
                TecnicoDao tecnicodao = new TecnicoDao(_conexao);

                tecnico = tecnicodao.ObterTecnico(codigo);
                //se o cliente nao foi encontrado
                if (tecnico == null)
                {

                    MessageBox.Show("Tecnico nao encotrado");
                    this.Close();
                }
                txtid.Text = tecnico.CodigoTecnico.ToString();
                txbNome.Text = tecnico.Nome;
                txbEspecialidade.Text = tecnico.Especialidade;
                txbEmail.Text = tecnico.Email;
                txtSenha.Text = tecnico.Senha;
                txtObs.Text = tecnico.Obs;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();
            TecnicoDao tecnicodao = new TecnicoDao(_conexao);

            try
            {
                tecnico.Nome = txbNome.Text;
                tecnico.Especialidade = txbEspecialidade.Text;
                tecnico.Email = txbEmail.Text;
                tecnico.Senha = txtSenha.Text;
                tecnico.Obs = txtObs.Text;

                int codigo = Convert.ToInt32(txtid.Text);

                tecnico.CodigoTecnico = codigo;

                tecnicodao.AlterarTecnico(tecnico);
                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
