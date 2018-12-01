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
            this.label1 = new System.Windows.Forms.Label();
            this.comboAnimal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ImgProcurar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ImgGraf = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProcurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 45);
            this.label1.TabIndex = 37;
            this.label1.Text = "Graficos Animais";
            // 
            // comboAnimal
            // 
            this.comboAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboAnimal.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAnimal.FormattingEnabled = true;
            this.comboAnimal.Location = new System.Drawing.Point(324, 79);
            this.comboAnimal.Name = "comboAnimal";
            this.comboAnimal.Size = new System.Drawing.Size(252, 29);
            this.comboAnimal.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(183, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Animais";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(122, 161);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "QUANTIDADE";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(666, 277);
            this.chart1.TabIndex = 62;
            this.chart1.Text = "chart1";
            // 
            // ImgProcurar
            // 
            this.ImgProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgProcurar.Image = global::HomeFarm.Properties.Resources.oie_transparent_9_;
            this.ImgProcurar.Location = new System.Drawing.Point(637, 79);
            this.ImgProcurar.Name = "ImgProcurar";
            this.ImgProcurar.Size = new System.Drawing.Size(49, 36);
            this.ImgProcurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgProcurar.TabIndex = 63;
            this.ImgProcurar.TabStop = false;
            this.ImgProcurar.Click += new System.EventHandler(this.ImgProcurar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Graficos";
            // 
            // ImgGraf
            // 
            this.ImgGraf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgGraf.Image = global::HomeFarm.Properties.Resources.oie_transparent_18_;
            this.ImgGraf.Location = new System.Drawing.Point(20, 79);
            this.ImgGraf.Name = "ImgGraf";
            this.ImgGraf.Size = new System.Drawing.Size(88, 71);
            this.ImgGraf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgGraf.TabIndex = 67;
            this.ImgGraf.TabStop = false;
            this.ImgGraf.Click += new System.EventHandler(this.ImgGraf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HomeFarm.Properties.Resources.Ltrans;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // GrafAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImgGraf);
            this.Controls.Add(this.ImgProcurar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboAnimal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrafAnimais";
            this.Text = "Graficos de Animais";
            this.Load += new System.EventHandler(this.GrafAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProcurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox ImgProcurar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ImgGraf;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}