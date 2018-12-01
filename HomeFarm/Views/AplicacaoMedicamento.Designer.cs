namespace HomeFarm.Views
{
    partial class AplicacaoMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AplicacaoMedicamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboFuncionario = new System.Windows.Forms.ComboBox();
            this.comboMedicamento = new System.Windows.Forms.ComboBox();
            this.comboAnimal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCarencia = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtDataAplicacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ImgCadastros = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCadastros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.comboFuncionario);
            this.panel1.Controls.Add(this.comboMedicamento);
            this.panel1.Controls.Add(this.comboAnimal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.txtCarencia);
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.txtDataAplicacao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ImgCadastros);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // comboFuncionario
            // 
            this.comboFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboFuncionario.FormattingEnabled = true;
            this.comboFuncionario.Location = new System.Drawing.Point(414, 192);
            this.comboFuncionario.Name = "comboFuncionario";
            this.comboFuncionario.Size = new System.Drawing.Size(362, 21);
            this.comboFuncionario.TabIndex = 49;
            // 
            // comboMedicamento
            // 
            this.comboMedicamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboMedicamento.FormattingEnabled = true;
            this.comboMedicamento.Location = new System.Drawing.Point(414, 230);
            this.comboMedicamento.Name = "comboMedicamento";
            this.comboMedicamento.Size = new System.Drawing.Size(362, 21);
            this.comboMedicamento.TabIndex = 48;
            // 
            // comboAnimal
            // 
            this.comboAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboAnimal.FormattingEnabled = true;
            this.comboAnimal.Location = new System.Drawing.Point(414, 318);
            this.comboAnimal.Name = "comboAnimal";
            this.comboAnimal.Size = new System.Drawing.Size(362, 21);
            this.comboAnimal.TabIndex = 47;
            this.comboAnimal.SelectedIndexChanged += new System.EventHandler(this.comboAdm_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(127, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "Animal";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(393, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 39);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(234, 387);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(116, 39);
            this.btnConfirmar.TabIndex = 44;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCarencia
            // 
            this.txtCarencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCarencia.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarencia.Location = new System.Drawing.Point(414, 270);
            this.txtCarencia.Name = "txtCarencia";
            this.txtCarencia.Size = new System.Drawing.Size(362, 29);
            this.txtCarencia.TabIndex = 43;
            this.txtCarencia.TextChanged += new System.EventHandler(this.txtCSenha_TextChanged);
            // 
            // txtObs
            // 
            this.txtObs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObs.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(414, 151);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(362, 29);
            this.txtObs.TabIndex = 40;
            this.txtObs.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(414, 108);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(362, 29);
            this.txtQuantidade.TabIndex = 39;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtSobrenome_TextChanged);
            // 
            // txtDataAplicacao
            // 
            this.txtDataAplicacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataAplicacao.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAplicacao.Location = new System.Drawing.Point(414, 66);
            this.txtDataAplicacao.Name = "txtDataAplicacao";
            this.txtDataAplicacao.Size = new System.Drawing.Size(362, 29);
            this.txtDataAplicacao.TabIndex = 38;
            this.txtDataAplicacao.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(127, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Carencia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(127, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Medicamento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(127, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Funcionário que Aplicou ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(127, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Observações";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(127, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Quantidade";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(127, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 25);
            this.label10.TabIndex = 32;
            this.label10.Text = "Data de Aplicação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cadastros";
            // 
            // ImgCadastros
            // 
            this.ImgCadastros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgCadastros.Image = global::HomeFarm.Properties.Resources.oie_transparent_5_;
            this.ImgCadastros.Location = new System.Drawing.Point(12, 66);
            this.ImgCadastros.Name = "ImgCadastros";
            this.ImgCadastros.Size = new System.Drawing.Size(87, 85);
            this.ImgCadastros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCadastros.TabIndex = 25;
            this.ImgCadastros.TabStop = false;
            this.ImgCadastros.Click += new System.EventHandler(this.ImgCadastros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aplicação de Medicamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HomeFarm.Properties.Resources.Ltrans;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AplicacaoMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AplicacaoMedicamento";
            this.Text = "Aplicacao de Medicamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCadastros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ImgCadastros;
        private System.Windows.Forms.ComboBox comboAnimal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtCarencia;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtDataAplicacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboFuncionario;
        private System.Windows.Forms.ComboBox comboMedicamento;
    }
}