﻿namespace HomeFarmSD
{
    partial class ListagemBovinoUserControl1
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
            this.dataGridBovino = new System.Windows.Forms.DataGridView();
            this.btnConecta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBovino)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBovino
            // 
            this.dataGridBovino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBovino.Location = new System.Drawing.Point(4, 56);
            this.dataGridBovino.Name = "dataGridBovino";
            this.dataGridBovino.Size = new System.Drawing.Size(657, 318);
            this.dataGridBovino.TabIndex = 0;
            this.dataGridBovino.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBovino_CellContentClick);
            // 
            // btnConecta
            // 
            this.btnConecta.Location = new System.Drawing.Point(13, 20);
            this.btnConecta.Name = "btnConecta";
            this.btnConecta.Size = new System.Drawing.Size(75, 23);
            this.btnConecta.TabIndex = 1;
            this.btnConecta.Text = "Carrega";
            this.btnConecta.UseVisualStyleBackColor = true;
            this.btnConecta.Click += new System.EventHandler(this.btnConecta_Click);
            // 
            // ListagemBovinoUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnConecta);
            this.Controls.Add(this.dataGridBovino);
            this.Name = "ListagemBovinoUserControl1";
            this.Size = new System.Drawing.Size(664, 377);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBovino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBovino;
        private System.Windows.Forms.Button btnConecta;
    }
}
