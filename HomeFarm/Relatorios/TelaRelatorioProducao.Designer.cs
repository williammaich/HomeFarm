namespace HomeFarm.Relatorios
{
    partial class TelaRelatorioProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorioProducao));
            this.producaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homefarmDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homefarmDataSet3 = new HomeFarm.homefarmDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.producaoTableAdapter = new HomeFarm.homefarmDataSet3TableAdapters.producaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.producaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // producaoBindingSource
            // 
            this.producaoBindingSource.DataMember = "producao";
            this.producaoBindingSource.DataSource = this.homefarmDataSet3BindingSource;
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetProducao";
            reportDataSource1.Value = this.producaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HomeFarm.Relatorios.RelatorioProducao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(746, 371);
            this.reportViewer1.TabIndex = 0;
            // 
            // producaoTableAdapter
            // 
            this.producaoTableAdapter.ClearBeforeFill = true;
            // 
            // TelaRelatorioProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 371);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaRelatorioProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Produção";
            this.Load += new System.EventHandler(this.TelaRelatorioProducao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.producaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private homefarmDataSet3 homefarmDataSet3;
        private System.Windows.Forms.BindingSource homefarmDataSet3BindingSource;
        private System.Windows.Forms.BindingSource producaoBindingSource;
        private homefarmDataSet3TableAdapters.producaoTableAdapter producaoTableAdapter;
    }
}