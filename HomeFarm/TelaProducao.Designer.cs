namespace HomeFarm
{
    partial class TelaProducao
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgImgListagem = new System.Windows.Forms.PictureBox();
            this.ImgCadProd = new System.Windows.Forms.PictureBox();
            this.ImgHome = new System.Windows.Forms.PictureBox();
            this.ImgMinimizar = new System.Windows.Forms.PictureBox();
            this.ImgFechar = new System.Windows.Forms.PictureBox();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgImgListagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCadProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(456, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Listagem de Produção";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cadastro de produção";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Home";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produção";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ImgImgListagem);
            this.panel2.Controls.Add(this.ImgCadProd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ImgHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 411);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImgMinimizar);
            this.panel1.Controls.Add(this.ImgFechar);
            this.panel1.Controls.Add(this.ImgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ImgImgListagem
            // 
            this.ImgImgListagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgImgListagem.Image = global::HomeFarm.Properties.Resources.oie_transparent_14_;
            this.ImgImgListagem.Location = new System.Drawing.Point(476, 77);
            this.ImgImgListagem.Name = "ImgImgListagem";
            this.ImgImgListagem.Size = new System.Drawing.Size(208, 156);
            this.ImgImgListagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgImgListagem.TabIndex = 4;
            this.ImgImgListagem.TabStop = false;
            this.ImgImgListagem.Click += new System.EventHandler(this.ImgImgListagem_Click);
            // 
            // ImgCadProd
            // 
            this.ImgCadProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgCadProd.Image = global::HomeFarm.Properties.Resources.oie_transparent_11_;
            this.ImgCadProd.Location = new System.Drawing.Point(159, 77);
            this.ImgCadProd.Name = "ImgCadProd";
            this.ImgCadProd.Size = new System.Drawing.Size(214, 156);
            this.ImgCadProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCadProd.TabIndex = 3;
            this.ImgCadProd.TabStop = false;
            this.ImgCadProd.Click += new System.EventHandler(this.ImgCadProd_Click);
            // 
            // ImgHome
            // 
            this.ImgHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgHome.Image = global::HomeFarm.Properties.Resources.home2;
            this.ImgHome.Location = new System.Drawing.Point(3, 101);
            this.ImgHome.Name = "ImgHome";
            this.ImgHome.Size = new System.Drawing.Size(88, 71);
            this.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgHome.TabIndex = 0;
            this.ImgHome.TabStop = false;
            this.ImgHome.Click += new System.EventHandler(this.ImgHome_Click);
            // 
            // ImgMinimizar
            // 
            this.ImgMinimizar.Image = global::HomeFarm.Properties.Resources.oie_transparent_4_;
            this.ImgMinimizar.Location = new System.Drawing.Point(714, 5);
            this.ImgMinimizar.Name = "ImgMinimizar";
            this.ImgMinimizar.Size = new System.Drawing.Size(31, 28);
            this.ImgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgMinimizar.TabIndex = 3;
            this.ImgMinimizar.TabStop = false;
            this.ImgMinimizar.Click += new System.EventHandler(this.ImgMinimizar_Click);
            // 
            // ImgFechar
            // 
            this.ImgFechar.Image = global::HomeFarm.Properties.Resources.oie_transparent_2_;
            this.ImgFechar.Location = new System.Drawing.Point(751, 5);
            this.ImgFechar.Name = "ImgFechar";
            this.ImgFechar.Size = new System.Drawing.Size(33, 31);
            this.ImgFechar.TabIndex = 2;
            this.ImgFechar.TabStop = false;
            this.ImgFechar.Click += new System.EventHandler(this.ImgFechar_Click);
            // 
            // ImgLogo
            // 
            this.ImgLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgLogo.Image = global::HomeFarm.Properties.Resources.greeen_horizonte;
            this.ImgLogo.Location = new System.Drawing.Point(0, 0);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(800, 39);
            this.ImgLogo.TabIndex = 0;
            this.ImgLogo.TabStop = false;
            this.ImgLogo.Click += new System.EventHandler(this.ImgLogo_Click);
            // 
            // TelaProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaProducao";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgImgListagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCadProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ImgImgListagem;
        private System.Windows.Forms.PictureBox ImgCadProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImgHome;
        private System.Windows.Forms.PictureBox ImgMinimizar;
        private System.Windows.Forms.PictureBox ImgFechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgLogo;
    }
}