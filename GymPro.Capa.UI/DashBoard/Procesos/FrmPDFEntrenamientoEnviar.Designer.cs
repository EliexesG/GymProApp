
namespace GymPro.Capa.UI.DashBoard.Procesos
{
    partial class FrmPDFEntrenamientoEnviar
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
            this.DSEntrenamiento = new GymPro.Capa.UI.DashBoard.Procesos.DSEntrenamiento();
            this.EntrenamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EntrenamientoTableAdapter = new GymPro.Capa.UI.DashBoard.Procesos.DSEntrenamientoTableAdapters.EntrenamientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSEntrenamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntrenamientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "EntrenamientoVer";
            reportDataSource1.Value = this.EntrenamientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GymPro.Capa.UI.DashBoard.Procesos.ReporteEntrenamiento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 88);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(830, 463);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSEntrenamiento
            // 
            this.DSEntrenamiento.DataSetName = "DSEntrenamiento";
            this.DSEntrenamiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EntrenamientoBindingSource
            // 
            this.EntrenamientoBindingSource.DataMember = "Entrenamiento";
            this.EntrenamientoBindingSource.DataSource = this.DSEntrenamiento;
            // 
            // EntrenamientoTableAdapter
            // 
            this.EntrenamientoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPDFEntrenamientoEnviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPDFEntrenamientoEnviar";
            this.Text = "FrmPDFEntrenamientoEnviar";
            this.Load += new System.EventHandler(this.FrmPDFEntrenamientoEnviar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSEntrenamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntrenamientoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntrenamientoBindingSource;
        private DSEntrenamiento DSEntrenamiento;
        private DSEntrenamientoTableAdapters.EntrenamientoTableAdapter EntrenamientoTableAdapter;
    }
}