namespace HomeFarmSD
{
    partial class ListagemOvinosUserControl1
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
            this.dataGridOvino = new System.Windows.Forms.DataGridView();
            this.btnConecta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOvino)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOvino
            // 
            this.dataGridOvino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOvino.Location = new System.Drawing.Point(3, 56);
            this.dataGridOvino.Name = "dataGridOvino";
            this.dataGridOvino.Size = new System.Drawing.Size(657, 318);
            this.dataGridOvino.TabIndex = 1;
            // 
            // btnConecta
            // 
            this.btnConecta.Location = new System.Drawing.Point(3, 16);
            this.btnConecta.Name = "btnConecta";
            this.btnConecta.Size = new System.Drawing.Size(75, 23);
            this.btnConecta.TabIndex = 2;
            this.btnConecta.Text = "Carrega";
            this.btnConecta.UseVisualStyleBackColor = true;
            this.btnConecta.Click += new System.EventHandler(this.btnConecta_Click);
            // 
            // ListagemOvinosUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConecta);
            this.Controls.Add(this.dataGridOvino);
            this.Name = "ListagemOvinosUserControl1";
            this.Size = new System.Drawing.Size(664, 377);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOvino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOvino;
        private System.Windows.Forms.Button btnConecta;
    }
}
