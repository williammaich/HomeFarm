namespace HomeFarm.Relatorios
{
    partial class TelaRelatorioAnimais
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homefarmDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homefarmDataSet3 = new HomeFarm.homefarmDataSet3();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgMinimizar = new System.Windows.Forms.PictureBox();
            this.ImgFechar = new System.Windows.Forms.PictureBox();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.reportViewerAnimais = new Microsoft.Reporting.WinForms.ReportViewer();
            this.homefarmDataSet1 = new HomeFarm.homefarmDataSet1();
            this.homefarmDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new HomeFarm.homefarmDataSet3TableAdapters.animalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.homefarmDataSet3BindingSource;
            // 
            // homefarmDataSet3BindingSource
            // 
            this.homefarmDataSet3BindingSource.DataSource = this.homefarmDataSet3;
            this.homefarmDataSet3BindingSource.Position = 0;
            // 
            // homefarmDataSet3
            // 
            this.homefarmDataSet3.DataSetName = "homefarmDataSet3";
            this.homefarmDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImgMinimizar);
            this.panel1.Controls.Add(this.ImgFechar);
            this.panel1.Controls.Add(this.ImgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 0;
            // 
            // ImgMinimizar
            // 
            this.ImgMinimizar.Image = global::HomeFarm.Properties.Resources.oie_transparent_4_;
            this.ImgMinimizar.Location = new System.Drawing.Point(727, 3);
            this.ImgMinimizar.Name = "ImgMinimizar";
            this.ImgMinimizar.Size = new System.Drawing.Size(31, 28);
            this.ImgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgMinimizar.TabIndex = 9;
            this.ImgMinimizar.TabStop = false;
            // 
            // ImgFechar
            // 
            this.ImgFechar.Image = global::HomeFarm.Properties.Resources.oie_transparent_2_;
            this.ImgFechar.Location = new System.Drawing.Point(764, 3);
            this.ImgFechar.Name = "ImgFechar";
            this.ImgFechar.Size = new System.Drawing.Size(33, 31);
            this.ImgFechar.TabIndex = 8;
            this.ImgFechar.TabStop = false;
            this.ImgFechar.Click += new System.EventHandler(this.ImgFechar_Click);
            // 
            // ImgLogo
            // 
            this.ImgLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgLogo.Image = global::HomeFarm.Properties.Resources.greeen_horizonte;
            this.ImgLogo.Location = new System.Drawing.Point(0, 0);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(800, 43);
            this.ImgLogo.TabIndex = 0;
            this.ImgLogo.TabStop = false;
            // 
            // reportViewerAnimais
            // 
            this.reportViewerAnimais.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "animalDataSet";
            reportDataSource1.Value = this.animalBindingSource;
            this.reportViewerAnimais.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerAnimais.LocalReport.ReportEmbeddedResource = "HomeFarm.Relatorios.animalRel.rdlc";
            this.reportViewerAnimais.Location = new System.Drawing.Point(0, 43);
            this.reportViewerAnimais.Name = "reportViewerAnimais";
            this.reportViewerAnimais.ServerReport.BearerToken = null;
            this.reportViewerAnimais.Size = new System.Drawing.Size(800, 407);
            this.reportViewerAnimais.TabIndex = 1;
            // 
            // homefarmDataSet1
            // 
            this.homefarmDataSet1.DataSetName = "homefarmDataSet1";
            this.homefarmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // homefarmDataSet1BindingSource
            // 
            this.homefarmDataSet1BindingSource.DataSource = this.homefarmDataSet1;
            this.homefarmDataSet1BindingSource.Position = 0;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // TelaRelatorioAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerAnimais);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaRelatorioAnimais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioAnimais";
            this.Load += new System.EventHandler(this.TelaRelatorioAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.PictureBox ImgMinimizar;
        private System.Windows.Forms.PictureBox ImgFechar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAnimais;
        private System.Windows.Forms.BindingSource homefarmDataSet1BindingSource;
        private homefarmDataSet1 homefarmDataSet1;
        private System.Windows.Forms.BindingSource homefarmDataSet3BindingSource;
        private homefarmDataSet3 homefarmDataSet3;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private homefarmDataSet3TableAdapters.animalTableAdapter animalTableAdapter;
    }
}