namespace ChamadosTecnicosTec55
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tECNICOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestorTecnicos = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTORDECLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cALCULADORAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOCUMENTAÇÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fECHARSOLUÇÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.GestorTecnicos,
            this.gESTORDECLIENTESToolStripMenuItem,
            this.cALCULADORAToolStripMenuItem,
            this.dOCUMENTAÇÃOToolStripMenuItem,
            this.sOBREToolStripMenuItem,
            this.fECHARSOLUÇÃOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.tECNICOToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem_Click);
            // 
            // tECNICOToolStripMenuItem
            // 
            this.tECNICOToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tECNICOToolStripMenuItem.Name = "tECNICOToolStripMenuItem";
            this.tECNICOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.tECNICOToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tECNICOToolStripMenuItem.Text = "TECNICO";
            this.tECNICOToolStripMenuItem.Click += new System.EventHandler(this.tECNICOToolStripMenuItem_Click);
            // 
            // GestorTecnicos
            // 
            this.GestorTecnicos.Name = "GestorTecnicos";
            this.GestorTecnicos.Size = new System.Drawing.Size(135, 20);
            this.GestorTecnicos.Text = "GESTOR DE TECNICOS";
            this.GestorTecnicos.Click += new System.EventHandler(this.gESTORDECHAMADOSToolStripMenuItem_Click);
            // 
            // gESTORDECLIENTESToolStripMenuItem
            // 
            this.gESTORDECLIENTESToolStripMenuItem.Name = "gESTORDECLIENTESToolStripMenuItem";
            this.gESTORDECLIENTESToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.gESTORDECLIENTESToolStripMenuItem.Text = "GESTOR DE CLIENTES";
            this.gESTORDECLIENTESToolStripMenuItem.Click += new System.EventHandler(this.gESTORDECLIENTESToolStripMenuItem_Click);
            // 
            // cALCULADORAToolStripMenuItem
            // 
            this.cALCULADORAToolStripMenuItem.Name = "cALCULADORAToolStripMenuItem";
            this.cALCULADORAToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.cALCULADORAToolStripMenuItem.Text = "CALCULADORA";
            this.cALCULADORAToolStripMenuItem.Click += new System.EventHandler(this.cALCULADORAToolStripMenuItem_Click);
            // 
            // dOCUMENTAÇÃOToolStripMenuItem
            // 
            this.dOCUMENTAÇÃOToolStripMenuItem.Name = "dOCUMENTAÇÃOToolStripMenuItem";
            this.dOCUMENTAÇÃOToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.dOCUMENTAÇÃOToolStripMenuItem.Text = "DOCUMENTAÇÃO";
            this.dOCUMENTAÇÃOToolStripMenuItem.Click += new System.EventHandler(this.dOCUMENTAÇÃOToolStripMenuItem_Click);
            // 
            // sOBREToolStripMenuItem
            // 
            this.sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            this.sOBREToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sOBREToolStripMenuItem.Text = "SOBRE";
            // 
            // fECHARSOLUÇÃOToolStripMenuItem
            // 
            this.fECHARSOLUÇÃOToolStripMenuItem.Name = "fECHARSOLUÇÃOToolStripMenuItem";
            this.fECHARSOLUÇÃOToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.fECHARSOLUÇÃOToolStripMenuItem.Text = "FECHAR SOLUÇÃO";
            this.fECHARSOLUÇÃOToolStripMenuItem.Click += new System.EventHandler(this.fECHARSOLUÇÃOToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sitema de Gestão PDV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tECNICOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestorTecnicos;
        private System.Windows.Forms.ToolStripMenuItem gESTORDECLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cALCULADORAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOCUMENTAÇÃOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOBREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fECHARSOLUÇÃOToolStripMenuItem;
    }
}