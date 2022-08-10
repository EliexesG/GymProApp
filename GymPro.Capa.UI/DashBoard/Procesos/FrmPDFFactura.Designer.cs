
namespace GymPro.Capa.UI.DashBoard.Procesos
{
    partial class FrmPDFFactura
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
            this.DSUltimaFactura = new GymPro.Capa.UI.DashBoard.Procesos.DSUltimaFactura();
            this.FacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturacionTableAdapter = new GymPro.Capa.UI.DashBoard.Procesos.DSUltimaFacturaTableAdapters.FacturacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSUltimaFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "UltimaFactura";
            reportDataSource1.Value = this.FacturacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GymPro.Capa.UI.DashBoard.Procesos.ReporteFacturacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(854, 563);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSUltimaFactura
            // 
            this.DSUltimaFactura.DataSetName = "DSUltimaFactura";
            this.DSUltimaFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturacionBindingSource
            // 
            this.FacturacionBindingSource.DataMember = "Facturacion";
            this.FacturacionBindingSource.DataSource = this.DSUltimaFactura;
            // 
            // FacturacionTableAdapter
            // 
            this.FacturacionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPDFFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPDFFactura";
            this.Text = "FrmPDFFactura";
            this.Load += new System.EventHandler(this.FrmPDFFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSUltimaFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturacionBindingSource;
        private DSUltimaFactura DSUltimaFactura;
        private DSUltimaFacturaTableAdapters.FacturacionTableAdapter FacturacionTableAdapter;
    }
}