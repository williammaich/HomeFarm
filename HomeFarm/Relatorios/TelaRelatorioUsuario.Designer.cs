﻿namespace HomeFarm.Relatorios
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
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homefarmDataSet3 = new HomeFarm.homefarmDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgMinimizar = new System.Windows.Forms.PictureBox();
            this.ImgFechar = new System.Windows.Forms.PictureBox();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usuarioTableAdapter = new HomeFarm.homefarmDataSet1TableAdapters.usuarioTableAdapter();
            this.homefarmDataSet31 = new HomeFarm.homefarmDataSet3();
            this.homefarmDataSet31BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter1 = new HomeFarm.homefarmDataSet3TableAdapters.usuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet31BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.ImgMinimizar);
            this.panel1.Controls.Add(this.ImgFechar);
            this.panel1.Controls.Add(this.ImgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 0;
            // 
            // ImgMinimizar
            // 
            this.ImgMinimizar.Image = global::HomeFarm.Properties.Resources.oie_transparent_4_;
            this.ImgMinimizar.Location = new System.Drawing.Point(727, 4);
            this.ImgMinimizar.Name = "ImgMinimizar";
            this.ImgMinimizar.Size = new System.Drawing.Size(31, 28);
            this.ImgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgMinimizar.TabIndex = 7;
            this.ImgMinimizar.TabStop = false;
            // 
            // ImgFechar
            // 
            this.ImgFechar.Image = global::HomeFarm.Properties.Resources.oie_transparent_2_;
            this.ImgFechar.Location = new System.Drawing.Point(764, 4);
            this.ImgFechar.Name = "ImgFechar";
            this.ImgFechar.Size = new System.Drawing.Size(33, 31);
            this.ImgFechar.TabIndex = 6;
            this.ImgFechar.TabStop = false;
            this.ImgFechar.Click += new System.EventHandler(this.ImgFechar_Click);
            // 
            // ImgLogo
            // 
            this.ImgLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgLogo.Image = global::HomeFarm.Properties.Resources.greeen_horizonte;
            this.ImgLogo.Location = new System.Drawing.Point(0, 0);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(800, 41);
            this.ImgLogo.TabIndex = 0;
            this.ImgLogo.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BancoHomeFarm";
            reportDataSource1.Value = this.usuarioBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HomeFarm.Relatorios.usuarioRel.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 409);
            this.reportViewer1.TabIndex = 1;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // homefarmDataSet31
            // 
            this.homefarmDataSet31.DataSetName = "homefarmDataSet3";
            this.homefarmDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // homefarmDataSet31BindingSource
            // 
            this.homefarmDataSet31BindingSource.DataSource = this.homefarmDataSet31;
            this.homefarmDataSet31BindingSource.Position = 0;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "usuario";
            this.usuarioBindingSource1.DataSource = this.homefarmDataSet31BindingSource;
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaRelatorioUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaRelatorioUsuario";
            this.Load += new System.EventHandler(this.TelaRelatorioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homefarmDataSet31BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.PictureBox ImgMinimizar;
        private System.Windows.Forms.PictureBox ImgFechar;
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