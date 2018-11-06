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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorioAnimais));
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homefarmDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homefarmDataSet3 = new HomeFarm.homefarmDataSet3();
            this.reportViewerAnimais = new Microsoft.Reporting.WinForms.ReportViewer();
            this.homefarmDataSet1 = new HomeFarm.homefarmDataSet1();
            this.homefarmDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new HomeFarm.homefarmDataSet3TableAdapters.animalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).BeginInit();
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
            // reportViewerAnimais
            // 
            this.reportViewerAnimais.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "animalDataSet";
            reportDataSource1.Value = this.animalBindingSource;
            this.reportViewerAnimais.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerAnimais.LocalReport.ReportEmbeddedResource = "HomeFarm.Relatorios.RelatorioAnimal.rdlc";
            this.reportViewerAnimais.Location = new System.Drawing.Point(0, 0);
            this.reportViewerAnimais.Name = "reportViewerAnimais";
            this.reportViewerAnimais.ServerReport.BearerToken = null;
            this.reportViewerAnimais.Size = new System.Drawing.Size(800, 450);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaRelatorioAnimais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório De Animais";
            this.Load += new System.EventHandler(this.TelaRelatorioAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAnimais;
        private System.Windows.Forms.BindingSource homefarmDataSet1BindingSource;
        private homefarmDataSet1 homefarmDataSet1;
        private System.Windows.Forms.BindingSource homefarmDataSet3BindingSource;
        private homefarmDataSet3 homefarmDataSet3;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private homefarmDataSet3TableAdapters.animalTableAdapter animalTableAdapter;
    }
}