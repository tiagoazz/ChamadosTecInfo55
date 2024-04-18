namespace ChamadosTecnicosTec55.Alterar
{
    partial class frmAlterarCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbSetor = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSetor = new System.Windows.Forms.TextBox();
            this.lbProf = new System.Windows.Forms.Label();
            this.txbProfissao = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.lbSetor);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbSetor);
            this.panel1.Controls.Add(this.lbProf);
            this.panel1.Controls.Add(this.txbProfissao);
            this.panel1.Controls.Add(this.txbNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 452);
            this.panel1.TabIndex = 16;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(524, 52);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 25;
            // 
            // lbSetor
            // 
            this.lbSetor.AutoSize = true;
            this.lbSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetor.Location = new System.Drawing.Point(168, 232);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(42, 17);
            this.lbSetor.TabIndex = 24;
            this.lbSetor.Text = "Setor";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(168, 115);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 17);
            this.lbNome.TabIndex = 23;
            this.lbNome.Text = "Nome";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(170, 315);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(455, 80);
            this.txtObs.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Observação";
            // 
            // txbSetor
            // 
            this.txbSetor.Location = new System.Drawing.Point(169, 252);
            this.txbSetor.Name = "txbSetor";
            this.txbSetor.Size = new System.Drawing.Size(456, 20);
            this.txbSetor.TabIndex = 19;
            // 
            // lbProf
            // 
            this.lbProf.AutoSize = true;
            this.lbProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProf.Location = new System.Drawing.Point(168, 173);
            this.lbProf.Name = "lbProf";
            this.lbProf.Size = new System.Drawing.Size(67, 17);
            this.lbProf.TabIndex = 21;
            this.lbProf.Text = "Profissão";
            // 
            // txbProfissao
            // 
            this.txbProfissao.Location = new System.Drawing.Point(169, 193);
            this.txbProfissao.Name = "txbProfissao";
            this.txbProfissao.Size = new System.Drawing.Size(456, 20);
            this.txbProfissao.TabIndex = 18;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(169, 135);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(456, 20);
            this.txbNome.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Alterar Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmAlterarCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSetor;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSetor;
        private System.Windows.Forms.Label lbProf;
        private System.Windows.Forms.TextBox txbProfissao;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button1;
    }
}