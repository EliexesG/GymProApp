
namespace GymPro.Capa.UI.DashBoard.Reportes
{
    partial class FrmReporteFacturacionPorFechas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FacturacionPorFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSFacturacionPorFechas = new GymPro.Capa.UI.DashBoard.Reportes.DSFacturacionPorFechas();
            this.dtpFechaA = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpFechaB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturacionPorFechasTableAdapter = new GymPro.Capa.UI.DashBoard.Reportes.DSFacturacionPorFechasTableAdapters.FacturacionPorFechasTableAdapter();
            this.btnConsultar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.FacturacionPorFechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSFacturacionPorFechas)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacturacionPorFechasBindingSource
            // 
            this.FacturacionPorFechasBindingSource.DataMember = "FacturacionPorFechas";
            this.FacturacionPorFechasBindingSource.DataSource = this.DSFacturacionPorFechas;
            // 
            // DSFacturacionPorFechas
            // 
            this.DSFacturacionPorFechas.DataSetName = "DSFacturacionPorFechas";
            this.DSFacturacionPorFechas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFechaA
            // 
            this.dtpFechaA.BorderRadius = 10;
            this.dtpFechaA.CheckedState.Parent = this.dtpFechaA;
            this.dtpFechaA.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaA.HoverState.Parent = this.dtpFechaA;
            this.dtpFechaA.Location = new System.Drawing.Point(88, 81);
            this.dtpFechaA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaA.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaA.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaA.Name = "dtpFechaA";
            this.dtpFechaA.ShadowDecoration.Parent = this.dtpFechaA;
            this.dtpFechaA.Size = new System.Drawing.Size(192, 47);
            this.dtpFechaA.TabIndex = 50;
            this.dtpFechaA.Value = new System.DateTime(2022, 7, 26, 8, 22, 26, 640);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(95, 51);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(185, 39);
            this.guna2HtmlLabel8.TabIndex = 49;
            this.guna2HtmlLabel8.Text = "Fecha A";
            // 
            // dtpFechaB
            // 
            this.dtpFechaB.BorderRadius = 10;
            this.dtpFechaB.CheckedState.Parent = this.dtpFechaB;
            this.dtpFechaB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaB.HoverState.Parent = this.dtpFechaB;
            this.dtpFechaB.Location = new System.Drawing.Point(548, 81);
            this.dtpFechaB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaB.Name = "dtpFechaB";
            this.dtpFechaB.ShadowDecoration.Parent = this.dtpFechaB;
            this.dtpFechaB.Size = new System.Drawing.Size(192, 47);
            this.dtpFechaB.TabIndex = 53;
            this.dtpFechaB.Value = new System.DateTime(2022, 7, 26, 8, 22, 26, 640);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(555, 51);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(158, 39);
            this.guna2HtmlLabel2.TabIndex = 52;
            this.guna2HtmlLabel2.Text = "Fecha B";
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "FacturacionPorFechasVer";
            reportDataSource5.Value = this.FacturacionPorFechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GymPro.Capa.UI.DashBoard.Reportes.ReporteFacturacionPorFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 159);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(830, 392);
            this.reportViewer1.TabIndex = 54;
            // 
            // FacturacionPorFechasTableAdapter
            // 
            this.FacturacionPorFechasTableAdapter.ClearBeforeFill = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.BorderRadius = 10;
            this.btnConsultar.CheckedState.Parent = this.btnConsultar;
            this.btnConsultar.CustomImages.Parent = this.btnConsultar;
            this.btnConsultar.FillColor = System.Drawing.Color.Lime;
            this.btnConsultar.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnConsultar.ForeColor = System.Drawing.Color.Teal;
            this.btnConsultar.HoverState.Parent = this.btnConsultar;
            this.btnConsultar.Image = global::GymPro.Capa.UI.Properties.Resources.Consultar;
            this.btnConsultar.ImageSize = new System.Drawing.Size(24, 24);
            this.btnConsultar.Location = new System.Drawing.Point(318, 76);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(5);
            this.btnConsultar.ShadowDecoration.Parent = this.btnConsultar;
            this.btnConsultar.Size = new System.Drawing.Size(192, 46);
            this.btnConsultar.TabIndex = 76;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dtpFechaA);
            this.guna2GroupBox1.Controls.Add(this.btnConsultar);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2GroupBox1.Controls.Add(this.dtpFechaB);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(830, 141);
            this.guna2GroupBox1.TabIndex = 77;
            this.guna2GroupBox1.Text = "Rango de Fechas";
            // 
            // FrmReporteFacturacionPorFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteFacturacionPorFechas";
            this.Text = "FrmReporteFacturacionPorFechas";
            this.Load += new System.EventHandler(this.FrmReporteFacturacionPorFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturacionPorFechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSFacturacionPorFechas)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaA;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturacionPorFechasBindingSource;
        private DSFacturacionPorFechas DSFacturacionPorFechas;
        private DSFacturacionPorFechasTableAdapters.FacturacionPorFechasTableAdapter FacturacionPorFechasTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnConsultar;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}