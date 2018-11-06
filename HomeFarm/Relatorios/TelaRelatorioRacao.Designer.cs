namespace HomeFarm.Relatorios
{
    partial class TelaRelatorioRacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorioRacao));
            this.racaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homefarmDataSet3 = new HomeFarm.homefarmDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.racaoTableAdapter = new HomeFarm.homefarmDataSet3TableAdapters.racaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.racaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // racaoBindingSource
            // 
            this.racaoBindingSource.DataMember = "racao";
            this.racaoBindingSource.DataSource = this.homefarmDataSet3;
            // 
            // homefarmDataSet3
            // 
            this.homefarmDataSet3.DataSetName = "homefarmDataSet3";
            this.homefarmDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetEstoque";
            reportDataSource1.Value = this.racaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HomeFarm.Relatorios.RelatorioEstoque.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // racaoTableAdapter
            // 
            this.racaoTableAdapter.ClearBeforeFill = true;
            // 
            // TelaRelatorioRacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaRelatorioRacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Ração";
            this.Load += new System.EventHandler(this.TelaRelatorioRacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private homefarmDataSet3 homefarmDataSet3;
        private System.Windows.Forms.BindingSource racaoBindingSource;
        private homefarmDataSet3TableAdapters.racaoTableAdapter racaoTableAdapter;
    }
}