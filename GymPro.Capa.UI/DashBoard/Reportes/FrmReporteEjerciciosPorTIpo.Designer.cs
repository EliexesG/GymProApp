
namespace GymPro.Capa.UI.DashBoard.Reportes
{
    partial class FrmReporteEjerciciosPorTIpo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbTipoEjercicio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSEjerciciosPorTipo = new GymPro.Capa.UI.DashBoard.Reportes.DSEjerciciosPorTipo();
            this.EjerciciosPorTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EjerciciosPorTipoTableAdapter = new GymPro.Capa.UI.DashBoard.Reportes.DSEjerciciosPorTipoTableAdapters.EjerciciosPorTipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSEjerciciosPorTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EjerciciosPorTipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(236, 23);
            this.guna2HtmlLabel2.TabIndex = 86;
            this.guna2HtmlLabel2.Text = "Tipo de Ejercicio";
            // 
            // cmbTipoEjercicio
            // 
            this.cmbTipoEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoEjercicio.BorderRadius = 10;
            this.cmbTipoEjercicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEjercicio.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipoEjercicio.FocusedState.Parent = this.cmbTipoEjercicio;
            this.cmbTipoEjercicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoEjercicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipoEjercicio.FormattingEnabled = true;
            this.cmbTipoEjercicio.HoverState.Parent = this.cmbTipoEjercicio;
            this.cmbTipoEjercicio.ItemHeight = 30;
            this.cmbTipoEjercicio.ItemsAppearance.Parent = this.cmbTipoEjercicio;
            this.cmbTipoEjercicio.Location = new System.Drawing.Point(12, 40);
            this.cmbTipoEjercicio.Name = "cmbTipoEjercicio";
            this.cmbTipoEjercicio.ShadowDecoration.Parent = this.cmbTipoEjercicio;
            this.cmbTipoEjercicio.Size = new System.Drawing.Size(184, 36);
            this.cmbTipoEjercicio.TabIndex = 85;
            this.cmbTipoEjercicio.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEjercicio_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "EjerciciosPorTipoVer";
            reportDataSource2.Value = this.EjerciciosPorTipoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GymPro.Capa.UI.DashBoard.Reportes.ReporteEjerciciosPorTipo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 104);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(830, 447);
            this.reportViewer1.TabIndex = 87;
            // 
            // DSEjerciciosPorTipo
            // 
            this.DSEjerciciosPorTipo.DataSetName = "DSEjerciciosPorTipo";
            this.DSEjerciciosPorTipo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EjerciciosPorTipoBindingSource
            // 
            this.EjerciciosPorTipoBindingSource.DataMember = "EjerciciosPorTipo";
            this.EjerciciosPorTipoBindingSource.DataSource = this.DSEjerciciosPorTipo;
            // 
            // EjerciciosPorTipoTableAdapter
            // 
            this.EjerciciosPorTipoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteEjerciciosPorTIpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cmbTipoEjercicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteEjerciciosPorTIpo";
            this.Text = "FrmReporteEjerciciosPorTIpo";
            this.Load += new System.EventHandler(this.FrmReporteEjerciciosPorTIpo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSEjerciciosPorTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EjerciciosPorTipoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoEjercicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EjerciciosPorTipoBindingSource;
        private DSEjerciciosPorTipo DSEjerciciosPorTipo;
        private DSEjerciciosPorTipoTableAdapters.EjerciciosPorTipoTableAdapter EjerciciosPorTipoTableAdapter;
    }
}