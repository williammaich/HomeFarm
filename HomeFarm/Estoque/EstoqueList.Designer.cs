namespace HomeFarm.Estoque
{
    partial class EstoqueList
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.ImgMinimizar = new System.Windows.Forms.PictureBox();
            this.ImgFechar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImgMinimizar);
            this.panel1.Controls.Add(this.ImgFechar);
            this.panel1.Controls.Add(this.ImgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 410);
            this.panel2.TabIndex = 1;
            // 
            // ImgLogo
            // 
            this.ImgLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgLogo.Image = global::HomeFarm.Properties.Resources.greeen_horizonte;
            this.ImgLogo.Location = new System.Drawing.Point(0, 0);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(800, 40);
            this.ImgLogo.TabIndex = 0;
            this.ImgLogo.TabStop = false;
            // 
            // ImgMinimizar
            // 
            this.ImgMinimizar.Image = global::HomeFarm.Properties.Resources.oie_transparent_4_;
            this.ImgMinimizar.Location = new System.Drawing.Point(716, 5);
            this.ImgMinimizar.Name = "ImgMinimizar";
            this.ImgMinimizar.Size = new System.Drawing.Size(33, 29);
            this.ImgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgMinimizar.TabIndex = 12;
            this.ImgMinimizar.TabStop = false;
            // 
            // ImgFechar
            // 
            this.ImgFechar.Image = global::HomeFarm.Properties.Resources.oie_transparent_2_;
            this.ImgFechar.Location = new System.Drawing.Point(755, 5);
            this.ImgFechar.Name = "ImgFechar";
            this.ImgFechar.Size = new System.Drawing.Size(33, 29);
            this.ImgFechar.TabIndex = 11;
            this.ImgFechar.TabStop = false;
            this.ImgFechar.Click += new System.EventHandler(this.ImgFechar_Click);
            // 
            // EstoqueList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstoqueList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstoqueList";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ImgMinimizar;
        private System.Windows.Forms.PictureBox ImgFechar;
    }
}