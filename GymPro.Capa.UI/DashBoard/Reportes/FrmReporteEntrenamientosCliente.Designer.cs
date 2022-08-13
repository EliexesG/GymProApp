
namespace GymPro.Capa.UI.DashBoard.Reportes
{
    partial class FrmReporteEntrenamientosCliente
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
            this.EntrenamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSEntrenamientoCliente = new GymPro.Capa.UI.DashBoard.Reportes.DSEntrenamientoCliente();
            this.cmbClientes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbEntrenamientos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EntrenamientoTableAdapter = new GymPro.Capa.UI.DashBoard.Reportes.DSEntrenamientoClienteTableAdapters.EntrenamientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EntrenamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEntrenamientoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // EntrenamientoBindingSource
            // 
            this.EntrenamientoBindingSource.DataMember = "Entrenamiento";
            this.EntrenamientoBindingSource.DataSource = this.DSEntrenamientoCliente;
            // 
            // DSEntrenamientoCliente
            // 
            this.DSEntrenamientoCliente.DataSetName = "DSEntrenamientoCliente";
            this.DSEntrenamientoCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbClientes
            // 
            this.cmbClientes.BackColor = System.Drawing.Color.Transparent;
            this.cmbClientes.BorderRadius = 10;
            this.cmbClientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FocusedColor = System.Drawing.Color.Empty;
            this.cmbClientes.FocusedState.Parent = this.cmbClientes;
            this.cmbClientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.HoverState.Parent = this.cmbClientes;
            this.cmbClientes.ItemHeight = 30;
            this.cmbClientes.ItemsAppearance.Parent = this.cmbClientes;
            this.cmbClientes.Location = new System.Drawing.Point(12, 51);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.ShadowDecoration.Parent = this.cmbClientes;
            this.cmbClientes.Size = new System.Drawing.Size(184, 36);
            this.cmbClientes.TabIndex = 0;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 23);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(124, 23);
            this.guna2HtmlLabel2.TabIndex = 84;
            this.guna2HtmlLabel2.Text = "Clientes";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(234, 23);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(124, 23);
            this.guna2HtmlLabel1.TabIndex = 86;
            this.guna2HtmlLabel1.Text = "Entrenamientos";
            // 
            // cmbEntrenamientos
            // 
            this.cmbEntrenamientos.BackColor = System.Drawing.Color.Transparent;
            this.cmbEntrenamientos.BorderRadius = 10;
            this.cmbEntrenamientos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEntrenamientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntrenamientos.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEntrenamientos.FocusedState.Parent = this.cmbEntrenamientos;
            this.cmbEntrenamientos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEntrenamientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEntrenamientos.FormattingEnabled = true;
            this.cmbEntrenamientos.HoverState.Parent = this.cmbEntrenamientos;
            this.cmbEntrenamientos.ItemHeight = 30;
            this.cmbEntrenamientos.ItemsAppearance.Parent = this.cmbEntrenamientos;
            this.cmbEntrenamientos.Location = new System.Drawing.Point(234, 51);
            this.cmbEntrenamientos.Name = "cmbEntrenamientos";
            this.cmbEntrenamientos.ShadowDecoration.Parent = this.cmbEntrenamientos;
            this.cmbEntrenamientos.Size = new System.Drawing.Size(279, 36);
            this.cmbEntrenamientos.TabIndex = 85;
            this.cmbEntrenamientos.SelectedIndexChanged += new System.EventHandler(this.cmbEntrenamientos_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "EntrenamientoVer";
            reportDataSource1.Value = this.EntrenamientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GymPro.Capa.UI.DashBoard.Reportes.ReportesEntrenamientoCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(830, 442);
            this.reportViewer1.TabIndex = 87;
            // 
            // EntrenamientoTableAdapter
            // 
            this.EntrenamientoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteEntrenamientosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cmbEntrenamientos);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cmbClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteEntrenamientosCliente";
            this.Text = "FrmReporteEntrenamientosCliente";
            this.Load += new System.EventHandler(this.FrmReporteEntrenamientosCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntrenamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEntrenamientoCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cmbClientes;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEntrenamientos;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntrenamientoBindingSource;
        private DSEntrenamientoCliente DSEntrenamientoCliente;
        private DSEntrenamientoClienteTableAdapters.EntrenamientoTableAdapter EntrenamientoTableAdapter;
    }
}