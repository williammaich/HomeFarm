namespace HomeFarm.Relatorios
{
    partial class TelaRelatorioUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorioUsuario));
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.homefarmDataSet31BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homefarmDataSet31 = new HomeFarm.homefarmDataSet3();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homefarmDataSet3 = new HomeFarm.homefarmDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usuarioTableAdapter = new HomeFarm.homefarmDataSet1TableAdapters.usuarioTableAdapter();
            this.usuarioTableAdapter1 = new HomeFarm.homefarmDataSet3TableAdapters.usuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet31BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "usuario";
            this.usuarioBindingSource1.DataSource = this.homefarmDataSet31BindingSource;
            // 
            // homefarmDataSet31BindingSource
            // 
            this.homefarmDataSet31BindingSource.DataSource = this.homefarmDataSet31;
            this.homefarmDataSet31BindingSource.Position = 0;
            // 
            // homefarmDataSet31
            // 
            this.homefarmDataSet31.DataSetName = "homefarmDataSet3";
            this.homefarmDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.homefarmDataSet3;
            // 
            // homefarmDataSet3
            // 
            this.homefarmDataSet3.DataSetName = "homefarmDataSet1";
            this.homefarmDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BancoHomeFarm";
            reportDataSource1.Value = this.usuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HomeFarm.Relatorios.RelatorioUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // TelaRelatorioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaRelatorioUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório De Usuário";
            this.Load += new System.EventHandler(this.TelaRelatorioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet31BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private homefarmDataSet1 homefarmDataSet3;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private homefarmDataSet1TableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource homefarmDataSet31BindingSource;
        private homefarmDataSet3 homefarmDataSet31;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private homefarmDataSet3TableAdapters.usuarioTableAdapter usuarioTableAdapter1;
    }
}