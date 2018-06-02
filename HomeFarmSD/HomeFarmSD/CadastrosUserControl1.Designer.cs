namespace HomeFarmSD
{
    partial class CadastrosUserControl1
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastroCampos = new System.Windows.Forms.Button();
            this.btnCadastroFuncionarios = new System.Windows.Forms.Button();
            this.btnCadastroAnimais = new System.Windows.Forms.Button();
            this.cadastroFuncionarioUserControl11 = new HomeFarmSD.CadastroFuncionarioUserControl1();
            this.cadastroAnimaisUserControl11 = new HomeFarmSD.CadastroAnimaisUserControl1();
            this.cadastrosHomeUserControl11 = new HomeFarmSD.CadastrosHomeUserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCadastroCampos);
            this.panel1.Controls.Add(this.btnCadastroFuncionarios);
            this.panel1.Controls.Add(this.btnCadastroAnimais);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 413);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastros";
            // 
            // btnCadastroCampos
            // 
            this.btnCadastroCampos.Location = new System.Drawing.Point(3, 182);
            this.btnCadastroCampos.Name = "btnCadastroCampos";
            this.btnCadastroCampos.Size = new System.Drawing.Size(130, 23);
            this.btnCadastroCampos.TabIndex = 2;
            this.btnCadastroCampos.Text = "Campos";
            this.btnCadastroCampos.UseVisualStyleBackColor = true;
            // 
            // btnCadastroFuncionarios
            // 
            this.btnCadastroFuncionarios.Location = new System.Drawing.Point(3, 113);
            this.btnCadastroFuncionarios.Name = "btnCadastroFuncionarios";
            this.btnCadastroFuncionarios.Size = new System.Drawing.Size(130, 23);
            this.btnCadastroFuncionarios.TabIndex = 1;
            this.btnCadastroFuncionarios.Text = "Funcionarios";
            this.btnCadastroFuncionarios.UseVisualStyleBackColor = true;
            this.btnCadastroFuncionarios.Click += new System.EventHandler(this.btnCadastroFuncionarios_Click);
            // 
            // btnCadastroAnimais
            // 
            this.btnCadastroAnimais.Location = new System.Drawing.Point(3, 53);
            this.btnCadastroAnimais.Name = "btnCadastroAnimais";
            this.btnCadastroAnimais.Size = new System.Drawing.Size(130, 23);
            this.btnCadastroAnimais.TabIndex = 0;
            this.btnCadastroAnimais.Text = "Animais";
            this.btnCadastroAnimais.UseVisualStyleBackColor = true;
            this.btnCadastroAnimais.Click += new System.EventHandler(this.btnCadastroAnimais_Click);
            // 
            // cadastroFuncionarioUserControl11
            // 
            this.cadastroFuncionarioUserControl11.BackColor = System.Drawing.Color.White;
            this.cadastroFuncionarioUserControl11.Location = new System.Drawing.Point(133, 0);
            this.cadastroFuncionarioUserControl11.Name = "cadastroFuncionarioUserControl11";
            this.cadastroFuncionarioUserControl11.Size = new System.Drawing.Size(601, 413);
            this.cadastroFuncionarioUserControl11.TabIndex = 2;
            // 
            // cadastroAnimaisUserControl11
            // 
            this.cadastroAnimaisUserControl11.BackColor = System.Drawing.Color.White;
            this.cadastroAnimaisUserControl11.Dock = System.Windows.Forms.DockStyle.Left;
            this.cadastroAnimaisUserControl11.Location = new System.Drawing.Point(133, 0);
            this.cadastroAnimaisUserControl11.Name = "cadastroAnimaisUserControl11";
            this.cadastroAnimaisUserControl11.Size = new System.Drawing.Size(601, 413);
            this.cadastroAnimaisUserControl11.TabIndex = 1;
            this.cadastroAnimaisUserControl11.Load += new System.EventHandler(this.cadastroAnimaisUserControl11_Load);
            // 
            // cadastrosHomeUserControl11
            // 
            this.cadastrosHomeUserControl11.BackColor = System.Drawing.Color.White;
            this.cadastrosHomeUserControl11.Location = new System.Drawing.Point(133, 0);
            this.cadastrosHomeUserControl11.Name = "cadastrosHomeUserControl11";
            this.cadastrosHomeUserControl11.Size = new System.Drawing.Size(601, 413);
            this.cadastrosHomeUserControl11.TabIndex = 3;
            // 
            // CadastrosUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cadastrosHomeUserControl11);
            this.Controls.Add(this.cadastroFuncionarioUserControl11);
            this.Controls.Add(this.cadastroAnimaisUserControl11);
            this.Controls.Add(this.panel1);
            this.Name = "CadastrosUserControl1";
            this.Size = new System.Drawing.Size(667, 413);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastroCampos;
        private System.Windows.Forms.Button btnCadastroFuncionarios;
        private System.Windows.Forms.Button btnCadastroAnimais;
        private CadastroAnimaisUserControl1 cadastroAnimaisUserControl11;
        private CadastroFuncionarioUserControl1 cadastroFuncionarioUserControl11;
        private CadastrosHomeUserControl1 cadastrosHomeUserControl11;
    }
}
