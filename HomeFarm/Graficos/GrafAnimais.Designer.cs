namespace HomeFarm.Graficos
{
    partial class GrafAnimais
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrafAnimais));
            this.label2 = new System.Windows.Forms.Label();
            this.ImgHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPropriedade = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboAnimal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ImgProcurar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProcurar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Home";
            // 
            // ImgHome
            // 
            this.ImgHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgHome.Image = global::HomeFarm.Properties.Resources.home2;
            this.ImgHome.Location = new System.Drawing.Point(20, 67);
            this.ImgHome.Name = "ImgHome";
            this.ImgHome.Size = new System.Drawing.Size(88, 71);
            this.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgHome.TabIndex = 38;
            this.ImgHome.TabStop = false;
            this.ImgHome.Click += new System.EventHandler(this.ImgHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 45);
            this.label1.TabIndex = 37;
            this.label1.Text = "Graficos";
            // 
            // comboPropriedade
            // 
            this.comboPropriedade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboPropriedade.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPropriedade.FormattingEnabled = true;
            this.comboPropriedade.Location = new System.Drawing.Point(358, 28);
            this.comboPropriedade.Name = "comboPropriedade";
            this.comboPropriedade.Size = new System.Drawing.Size(252, 29);
            this.comboPropriedade.TabIndex = 59;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(217, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 21);
            this.label17.TabIndex = 58;
            this.label17.Text = "Propriedade";
            // 
            // comboAnimal
            // 
            this.comboAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboAnimal.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAnimal.FormattingEnabled = true;
            this.comboAnimal.Location = new System.Drawing.Point(358, 77);
            this.comboAnimal.Name = "comboAnimal";
            this.comboAnimal.Size = new System.Drawing.Size(252, 29);
            this.comboAnimal.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(217, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Animais";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(122, 161);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "QUANTIDADE";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(666, 277);
            this.chart1.TabIndex = 62;
            this.chart1.Text = "chart1";
            // 
            // ImgProcurar
            // 
            this.ImgProcurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImgProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgProcurar.Image = global::HomeFarm.Properties.Resources.oie_transparent_9_;
            this.ImgProcurar.Location = new System.Drawing.Point(671, 77);
            this.ImgProcurar.Name = "ImgProcurar";
            this.ImgProcurar.Size = new System.Drawing.Size(49, 36);
            this.ImgProcurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgProcurar.TabIndex = 63;
            this.ImgProcurar.TabStop = false;
            this.ImgProcurar.Click += new System.EventHandler(this.ImgProcurar_Click);
            // 
            // GrafAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImgProcurar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboAnimal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboPropriedade);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImgHome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrafAnimais";
            this.Text = "GrafAnimais";
            this.Load += new System.EventHandler(this.GrafAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProcurar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ImgHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPropriedade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox ImgProcurar;
    }
}