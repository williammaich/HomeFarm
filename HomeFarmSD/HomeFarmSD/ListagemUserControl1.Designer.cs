namespace HomeFarmSD
{
    partial class ListagemUserControl1
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
            this.btnProducaoSuinos = new System.Windows.Forms.Button();
            this.btnProducaoOvinos = new System.Windows.Forms.Button();
            this.btnProducaoEquinos = new System.Windows.Forms.Button();
            this.btnProducaoBovinos = new System.Windows.Forms.Button();
            this.btnProducaoCampos = new System.Windows.Forms.Button();
            this.listagemBovinoUserControl11 = new HomeFarmSD.ListagemBovinoUserControl1();
            this.listagemHomeUserControl11 = new HomeFarmSD.ListagemHomeUserControl1();
            this.listagemEquinoUserControl11 = new HomeFarmSD.ListagemEquinoUserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProducaoSuinos);
            this.panel1.Controls.Add(this.btnProducaoOvinos);
            this.panel1.Controls.Add(this.btnProducaoEquinos);
            this.panel1.Controls.Add(this.btnProducaoBovinos);
            this.panel1.Controls.Add(this.btnProducaoCampos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 29);
            this.panel1.TabIndex = 1;
            // 
            // btnProducaoSuinos
            // 
            this.btnProducaoSuinos.Location = new System.Drawing.Point(420, 3);
            this.btnProducaoSuinos.Name = "btnProducaoSuinos";
            this.btnProducaoSuinos.Size = new System.Drawing.Size(75, 23);
            this.btnProducaoSuinos.TabIndex = 4;
            this.btnProducaoSuinos.Text = "Suinos";
            this.btnProducaoSuinos.UseVisualStyleBackColor = true;
            // 
            // btnProducaoOvinos
            // 
            this.btnProducaoOvinos.Location = new System.Drawing.Point(314, 3);
            this.btnProducaoOvinos.Name = "btnProducaoOvinos";
            this.btnProducaoOvinos.Size = new System.Drawing.Size(75, 23);
            this.btnProducaoOvinos.TabIndex = 3;
            this.btnProducaoOvinos.Text = "Ovinos";
            this.btnProducaoOvinos.UseVisualStyleBackColor = true;
            // 
            // btnProducaoEquinos
            // 
            this.btnProducaoEquinos.Location = new System.Drawing.Point(213, 3);
            this.btnProducaoEquinos.Name = "btnProducaoEquinos";
            this.btnProducaoEquinos.Size = new System.Drawing.Size(75, 23);
            this.btnProducaoEquinos.TabIndex = 2;
            this.btnProducaoEquinos.Text = "Equinos";
            this.btnProducaoEquinos.UseVisualStyleBackColor = true;
            this.btnProducaoEquinos.Click += new System.EventHandler(this.btnProducaoEquinos_Click);
            // 
            // btnProducaoBovinos
            // 
            this.btnProducaoBovinos.Location = new System.Drawing.Point(109, 3);
            this.btnProducaoBovinos.Name = "btnProducaoBovinos";
            this.btnProducaoBovinos.Size = new System.Drawing.Size(75, 23);
            this.btnProducaoBovinos.TabIndex = 1;
            this.btnProducaoBovinos.Text = "Bovinos";
            this.btnProducaoBovinos.UseVisualStyleBackColor = true;
            this.btnProducaoBovinos.Click += new System.EventHandler(this.btnProducaoBovinos_Click);
            // 
            // btnProducaoCampos
            // 
            this.btnProducaoCampos.Location = new System.Drawing.Point(3, 3);
            this.btnProducaoCampos.Name = "btnProducaoCampos";
            this.btnProducaoCampos.Size = new System.Drawing.Size(75, 23);
            this.btnProducaoCampos.TabIndex = 0;
            this.btnProducaoCampos.Text = "Campos";
            this.btnProducaoCampos.UseVisualStyleBackColor = true;
            // 
            // listagemBovinoUserControl11
            // 
            this.listagemBovinoUserControl11.BackColor = System.Drawing.Color.White;
            this.listagemBovinoUserControl11.Location = new System.Drawing.Point(0, 33);
            this.listagemBovinoUserControl11.Name = "listagemBovinoUserControl11";
            this.listagemBovinoUserControl11.Size = new System.Drawing.Size(664, 377);
            this.listagemBovinoUserControl11.TabIndex = 3;
            // 
            // listagemHomeUserControl11
            // 
            this.listagemHomeUserControl11.BackColor = System.Drawing.Color.White;
            this.listagemHomeUserControl11.Location = new System.Drawing.Point(4, 33);
            this.listagemHomeUserControl11.Name = "listagemHomeUserControl11";
            this.listagemHomeUserControl11.Size = new System.Drawing.Size(664, 377);
            this.listagemHomeUserControl11.TabIndex = 2;
            // 
            // listagemEquinoUserControl11
            // 
            this.listagemEquinoUserControl11.Location = new System.Drawing.Point(0, 33);
            this.listagemEquinoUserControl11.Name = "listagemEquinoUserControl11";
            this.listagemEquinoUserControl11.Size = new System.Drawing.Size(664, 377);
            this.listagemEquinoUserControl11.TabIndex = 4;
            // 
            // ListagemUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listagemEquinoUserControl11);
            this.Controls.Add(this.listagemBovinoUserControl11);
            this.Controls.Add(this.listagemHomeUserControl11);
            this.Controls.Add(this.panel1);
            this.Name = "ListagemUserControl1";
            this.Size = new System.Drawing.Size(667, 413);
            this.Load += new System.EventHandler(this.ListagemUserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProducaoSuinos;
        private System.Windows.Forms.Button btnProducaoOvinos;
        private System.Windows.Forms.Button btnProducaoEquinos;
        private System.Windows.Forms.Button btnProducaoBovinos;
        private System.Windows.Forms.Button btnProducaoCampos;
        private ListagemHomeUserControl1 listagemHomeUserControl11;
        private ListagemBovinoUserControl1 listagemBovinoUserControl11;
        private ListagemEquinoUserControl1 listagemEquinoUserControl11;
    }
}
