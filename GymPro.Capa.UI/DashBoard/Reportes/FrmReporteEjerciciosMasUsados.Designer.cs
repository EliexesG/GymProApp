
namespace GymPro.Capa.UI.DashBoard.Reportes
{
    partial class FrmReporteEjerciciosMasUsados
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
            this.DSEjerciciosMasUsados = new GymPro.Capa.UI.DashBoard.Reportes.DSEjerciciosMasUsados();
            this.EjerciciosMasUsadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EjerciciosMasUsadosTableAdapter = new GymPro.Capa.UI.DashBoard.Reportes.DSEjerciciosMasUsadosTableAdapters.EjerciciosMasUsadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSEjerciciosMasUsados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EjerciciosMasUsadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "EjerciciosMasUsadosVer";
            reportDataSource1.Value = this.EjerciciosMasUsadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GymPro.Capa.UI.DashBoard.Reportes.ReporteEjerciciosMasUsados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(830, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSEjerciciosMasUsados
            // 
            this.DSEjerciciosMasUsados.DataSetName = "DSEjerciciosMasUsados";
            this.DSEjerciciosMasUsados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EjerciciosMasUsadosBindingSource
            // 
            this.EjerciciosMasUsadosBindingSource.DataMember = "EjerciciosMasUsados";
            this.EjerciciosMasUsadosBindingSource.DataSource = this.DSEjerciciosMasUsados;
            // 
            // EjerciciosMasUsadosTableAdapter
            // 
            this.EjerciciosMasUsadosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteEjerciciosMasUsados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteEjerciciosMasUsados";
            this.Text = "FrmReporteEjerciciosMasUsados";
            this.Load += new System.EventHandler(this.FrmReporteEjerciciosMasUsados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSEjerciciosMasUsados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EjerciciosMasUsadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EjerciciosMasUsadosBindingSource;
        private DSEjerciciosMasUsados DSEjerciciosMasUsados;
        private DSEjerciciosMasUsadosTableAdapters.EjerciciosMasUsadosTableAdapter EjerciciosMasUsadosTableAdapter;
    }
}