namespace HomeFarm.Graficos
{
    partial class GrafFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrafFuncionarios));
            this.ImgProcurar = new System.Windows.Forms.PictureBox();
            this.chartFuncionario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboPropriedade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImgHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProcurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHome)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgProcurar
            // 
            this.ImgProcurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImgProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgProcurar.Image = global::HomeFarm.Properties.Resources.oie_transparent_9_;
            this.ImgProcurar.Location = new System.Drawing.Point(665, 35);
            this.ImgProcurar.Name = "ImgProcurar";
            this.ImgProcurar.Size = new System.Drawing.Size(49, 36);
            this.ImgProcurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgProcurar.TabIndex = 70;
            this.ImgProcurar.TabStop = false;
            this.ImgProcurar.Click += new System.EventHandler(this.ImgProcurar_Click_1);
            // 
            // chartFuncionario
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFuncionario.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFuncionario.Legends.Add(legend1);
            this.chartFuncionario.Location = new System.Drawing.Point(122, 163);
            this.chartFuncionario.Name = "chartFuncionario";
            this.chartFuncionario.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "NOME";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartFuncionario.Series.Add(series1);
            this.chartFuncionario.Size = new System.Drawing.Size(666, 277);
            this.chartFuncionario.TabIndex = 69;
            this.chartFuncionario.Text = "chart1";
            // 
            // comboPropriedade
            // 
            this.comboPropriedade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboPropriedade.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPropriedade.FormattingEnabled = true;
            this.comboPropriedade.Location = new System.Drawing.Point(352, 35);
            this.comboPropriedade.Name = "comboPropriedade";
            this.comboPropriedade.Size = new System.Drawing.Size(252, 29);
            this.comboPropriedade.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(211, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 67;
            this.label3.Text = "Propriedades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Home";
            // 
            // ImgHome
            // 
            this.ImgHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgHome.Image = global::HomeFarm.Properties.Resources.home2;
            this.ImgHome.Location = new System.Drawing.Point(20, 69);
            this.ImgHome.Name = "ImgHome";
            this.ImgHome.Size = new System.Drawing.Size(88, 71);
            this.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgHome.TabIndex = 65;
            this.ImgHome.TabStop = false;
            this.ImgHome.Click += new System.EventHandler(this.ImgHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 45);
            this.label1.TabIndex = 64;
            this.label1.Text = "Graficos";
            // 
            // GrafFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImgProcurar);
            this.Controls.Add(this.chartFuncionario);
            this.Controls.Add(this.comboPropriedade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImgHome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrafFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrafFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.ImgProcurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgProcurar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFuncionario;
        private System.Windows.Forms.ComboBox comboPropriedade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ImgHome;
        private System.Windows.Forms.Label label1;
    }
}