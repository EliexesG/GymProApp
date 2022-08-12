
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EntrenamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSEntrenamiento = new GymPro.Capa.UI.DashBoard.Procesos.DSEntrenamiento();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EntrenamientoTableAdapter = new GymPro.Capa.UI.DashBoard.Procesos.DSEntrenamientoTableAdapters.EntrenamientoTableAdapter();
            this.pbFoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEnviarCorreo = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.EntrenamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEntrenamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // EntrenamientoBindingSource
            // 
            this.EntrenamientoBindingSource.DataMember = "Entrenamiento";
            this.EntrenamientoBindingSource.DataSource = this.DSEntrenamiento;
            // 
            // DSEntrenamiento
            // 
            this.DSEntrenamiento.DataSetName = "DSEntrenamiento";
            this.DSEntrenamiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "EntrenamientoVer";
            reportDataSource2.Value = this.EntrenamientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GymPro.Capa.UI.DashBoard.Procesos.ReporteEntrenamiento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 88);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(830, 463);
            this.reportViewer1.TabIndex = 0;
            // 
            // EntrenamientoTableAdapter
            // 
            this.EntrenamientoTableAdapter.ClearBeforeFill = true;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbFoto.Location = new System.Drawing.Point(55, 12);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbFoto.ShadowDecoration.Parent = this.pbFoto;
            this.pbFoto.Size = new System.Drawing.Size(67, 60);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderRadius = 10;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.DefaultText = "";
            this.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.DisabledState.Parent = this.txtCorreo;
            this.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.FocusedState.Parent = this.txtCorreo;
            this.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.HoverState.Parent = this.txtCorreo;
            this.txtCorreo.Location = new System.Drawing.Point(306, 25);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PlaceholderText = "ejemplo@gmail.com";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.ShadowDecoration.Parent = this.txtCorreo;
            this.txtCorreo.Size = new System.Drawing.Size(212, 34);
            this.txtCorreo.TabIndex = 65;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(220, 31);
            this.guna2HtmlLabel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(69, 23);
            this.guna2HtmlLabel9.TabIndex = 64;
            this.guna2HtmlLabel9.Text = "Correo";
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviarCorreo.BorderRadius = 10;
            this.btnEnviarCorreo.CheckedState.Parent = this.btnEnviarCorreo;
            this.btnEnviarCorreo.CustomImages.Parent = this.btnEnviarCorreo;
            this.btnEnviarCorreo.FillColor = System.Drawing.Color.Lime;
            this.btnEnviarCorreo.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnEnviarCorreo.ForeColor = System.Drawing.Color.Teal;
            this.btnEnviarCorreo.HoverState.Parent = this.btnEnviarCorreo;
            this.btnEnviarCorreo.Image = global::GymPro.Capa.UI.Properties.Resources.Email;
            this.btnEnviarCorreo.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEnviarCorreo.Location = new System.Drawing.Point(627, 19);
            this.btnEnviarCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Padding = new System.Windows.Forms.Padding(5);
            this.btnEnviarCorreo.ShadowDecoration.Parent = this.btnEnviarCorreo;
            this.btnEnviarCorreo.Size = new System.Drawing.Size(192, 46);
            this.btnEnviarCorreo.TabIndex = 76;
            this.btnEnviarCorreo.Text = "Enviar";
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // FrmPDFEntrenamientoEnviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.btnEnviarCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPDFEntrenamientoEnviar";
            this.Text = "FrmPDFEntrenamientoEnviar";
            this.Load += new System.EventHandler(this.FrmPDFEntrenamientoEnviar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntrenamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEntrenamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntrenamientoBindingSource;
        private DSEntrenamiento DSEntrenamiento;
        private DSEntrenamientoTableAdapters.EntrenamientoTableAdapter EntrenamientoTableAdapter;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbFoto;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2Button btnEnviarCorreo;
    }
}