using ChamadosTecnicosTec55.Adicionar;
using ChamadosTecnicosTec55.Alterar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void fECHARSOLUÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Tem certeza que deseja fechar a guia ? ","Sistema de gestao PDV",MessageBoxButtons.YesNo);
            if (msgBox!= DialogResult.Yes) {
            this.Close();
            }
               
             
                
            
        }

        private void dOCUMENTAÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"https://tjsecurity.com.br/",
                UseShellExecute = true,
            } );
        }

        private void cALCULADORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        public void coresFormularios()
        {
            foreach(Control ctrl in this.Controls)
            {
                try
                {
                    if (ctrl is MdiClient)
                    {
                        ctrl.BackColor = System.Drawing.Color.Orange;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            coresFormularios();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formcliente = new frmAdicionarCliente();
            //define o formulario pai
            formcliente.MdiParent = this;
            formcliente.Show();

            //ou  formcliente.ShowDialog(); se ultilizar retirar a linha mdiparetes
        }

        private void tECNICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formtecnico = new frmTecnicoAdicionar();
            //define o formulario pai
           formtecnico.MdiParent = this;
           formtecnico.Show();
        }

        private void gESTORDECHAMADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gESTORDECLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
         var frmGerirClientes = new frmGerirClientes();
            //define o formulario pai
           frmGerirClientes.MdiParent = this;
            frmGerirClientes.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}