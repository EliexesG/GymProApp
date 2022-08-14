
namespace GymPro.Capa.UI.DashBoard.Reportes
{
    partial class FrmReporteUsuariosMorosos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSUsuariosMorosos = new GymPro.Capa.UI.DashBoard.Reportes.DSUsuariosMorosos();
            this.UsuariosMorososBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsuariosMorososTableAdapter = new GymPro.Capa.UI.DashBoard.Reportes.DSUsuariosMorososTableAdapters.UsuariosMorososTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSUsuariosMorosos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosMorososBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "UsuariosMorososVer";
            reportDataSource1.Value = this.UsuariosMorososBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GymPro.Capa.UI.DashBoard.Reportes.ReporteUsuariosMorosos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(830, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSUsuariosMorosos
            // 
            this.DSUsuariosMorosos.DataSetName = "DSUsuariosMorosos";
            this.DSUsuariosMorosos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsuariosMorososBindingSource
            // 
            this.UsuariosMorososBindingSource.DataMember = "UsuariosMorosos";
            this.UsuariosMorososBindingSource.DataSource = this.DSUsuariosMorosos;
            // 
            // UsuariosMorososTableAdapter
            // 
            this.UsuariosMorososTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteUsuariosMorosos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteUsuariosMorosos";
            this.Text = "FrmReporteUsuariosMorosos";
            this.Load += new System.EventHandler(this.FrmReporteUsuariosMorosos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSUsuariosMorosos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosMorososBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UsuariosMorososBindingSource;
        private DSUsuariosMorosos DSUsuariosMorosos;
        private DSUsuariosMorososTableAdapters.UsuariosMorososTableAdapter UsuariosMorososTableAdapter;
    }
}