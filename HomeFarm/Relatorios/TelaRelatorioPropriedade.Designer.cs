namespace HomeFarm.Relatorios
{
    partial class TelaRelatorioPropriedade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorioPropriedade));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.homefarmDataSet3 = new HomeFarm.homefarmDataSet3();
            this.propriedadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propriedadeTableAdapter = new HomeFarm.homefarmDataSet3TableAdapters.propriedadeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propriedadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPropriedade";
            reportDataSource1.Value = this.propriedadeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HomeFarm.Relatorios.RelatorioPropriedade.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // homefarmDataSet3
            // 
            this.homefarmDataSet3.DataSetName = "homefarmDataSet3";
            this.homefarmDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propriedadeBindingSource
            // 
            this.propriedadeBindingSource.DataMember = "propriedade";
            this.propriedadeBindingSource.DataSource = this.homefarmDataSet3;
            // 
            // propriedadeTableAdapter
            // 
            this.propriedadeTableAdapter.ClearBeforeFill = true;
            // 
            // TelaRelatorioPropriedade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaRelatorioPropriedade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Propriedade";
            this.Load += new System.EventHandler(this.TelaRelatorioPropriedade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propriedadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private homefarmDataSet3 homefarmDataSet3;
        private System.Windows.Forms.BindingSource propriedadeBindingSource;
        private homefarmDataSet3TableAdapters.propriedadeTableAdapter propriedadeTableAdapter;
    }
}