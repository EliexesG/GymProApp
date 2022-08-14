
namespace GymPro.Capa.UI.DashBoard
{
    partial class FrmDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashBoard));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSalir = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblNombreUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnReportes = new Guna.UI2.WinForms.Guna2Button();
            this.btnProcesos = new Guna.UI2.WinForms.Guna2Button();
            this.btnMantenimientos = new Guna.UI2.WinForms.Guna2Button();
            this.btnVerPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTipoUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbFotoUsuario = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlDisplay = new Guna.UI2.WinForms.Guna2Panel();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtMulta = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMulta = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnModificarMulta = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUsuario)).BeginInit();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnMinimizar);
            this.guna2GradientPanel1.Controls.Add(this.btnSalir);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Lime;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1146, 35);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.CheckedState.Parent = this.btnMinimizar;
            this.btnMinimizar.CustomImages.Parent = this.btnMinimizar;
            this.btnMinimizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMinimizar.HoverState.Parent = this.btnMinimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1084, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimizar.ShadowDecoration.Parent = this.btnMinimizar;
            this.btnMinimizar.Size = new System.Drawing.Size(24, 24);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.CheckedState.Parent = this.btnSalir;
            this.btnSalir.CustomImages.Parent = this.btnSalir;
            this.btnSalir.FillColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Maroon;
            this.btnSalir.HoverState.Parent = this.btnSalir;
            this.btnSalir.Location = new System.Drawing.Point(1114, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSalir.ShadowDecoration.Parent = this.btnSalir;
            this.btnSalir.Size = new System.Drawing.Size(24, 24);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "X";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = false;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(271, 36);
            this.lblNombreUsuario.TabIndex = 12;
            this.lblNombreUsuario.Text = "Usuario";
            this.lblNombreUsuario.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnModificarMulta);
            this.guna2ShadowPanel1.Controls.Add(this.txtMulta);
            this.guna2ShadowPanel1.Controls.Add(this.btnReportes);
            this.guna2ShadowPanel1.Controls.Add(this.lblMulta);
            this.guna2ShadowPanel1.Controls.Add(this.btnProcesos);
            this.guna2ShadowPanel1.Controls.Add(this.btnMantenimientos);
            this.guna2ShadowPanel1.Controls.Add(this.btnVerPerfil);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Controls.Add(this.lblTipoUsuario);
            this.guna2ShadowPanel1.Controls.Add(this.pbFotoUsuario);
            this.guna2ShadowPanel1.Controls.Add(this.lblNombreUsuario);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 41);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(271, 633);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // btnReportes
            // 
            this.btnReportes.BorderRadius = 10;
            this.btnReportes.CheckedState.Parent = this.btnReportes;
            this.btnReportes.CustomImages.Parent = this.btnReportes;
            this.btnReportes.FillColor = System.Drawing.Color.Lime;
            this.btnReportes.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnReportes.ForeColor = System.Drawing.Color.Teal;
            this.btnReportes.HoverState.Parent = this.btnReportes;
            this.btnReportes.Location = new System.Drawing.Point(45, 368);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.ShadowDecoration.Parent = this.btnReportes;
            this.btnReportes.Size = new System.Drawing.Size(180, 45);
            this.btnReportes.TabIndex = 16;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnProcesos
            // 
            this.btnProcesos.BorderRadius = 10;
            this.btnProcesos.CheckedState.Parent = this.btnProcesos;
            this.btnProcesos.CustomImages.Parent = this.btnProcesos;
            this.btnProcesos.FillColor = System.Drawing.Color.Lime;
            this.btnProcesos.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnProcesos.ForeColor = System.Drawing.Color.Teal;
            this.btnProcesos.HoverState.Parent = this.btnProcesos;
            this.btnProcesos.Location = new System.Drawing.Point(45, 307);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.ShadowDecoration.Parent = this.btnProcesos;
            this.btnProcesos.Size = new System.Drawing.Size(180, 45);
            this.btnProcesos.TabIndex = 15;
            this.btnProcesos.Text = "Procesos";
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // btnMantenimientos
            // 
            this.btnMantenimientos.BorderRadius = 10;
            this.btnMantenimientos.CheckedState.Parent = this.btnMantenimientos;
            this.btnMantenimientos.CustomImages.Parent = this.btnMantenimientos;
            this.btnMantenimientos.FillColor = System.Drawing.Color.Lime;
            this.btnMantenimientos.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnMantenimientos.ForeColor = System.Drawing.Color.Teal;
            this.btnMantenimientos.HoverState.Parent = this.btnMantenimientos;
            this.btnMantenimientos.Location = new System.Drawing.Point(45, 246);
            this.btnMantenimientos.Name = "btnMantenimientos";
            this.btnMantenimientos.ShadowDecoration.Parent = this.btnMantenimientos;
            this.btnMantenimientos.Size = new System.Drawing.Size(180, 45);
            this.btnMantenimientos.TabIndex = 14;
            this.btnMantenimientos.Text = "Mantenimientos";
            this.btnMantenimientos.Click += new System.EventHandler(this.btnMantenimientos_Click);
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BorderRadius = 10;
            this.btnVerPerfil.CheckedState.Parent = this.btnVerPerfil;
            this.btnVerPerfil.CustomImages.Parent = this.btnVerPerfil;
            this.btnVerPerfil.FillColor = System.Drawing.Color.Lime;
            this.btnVerPerfil.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnVerPerfil.ForeColor = System.Drawing.Color.Teal;
            this.btnVerPerfil.HoverState.Parent = this.btnVerPerfil;
            this.btnVerPerfil.Image = global::GymPro.Capa.UI.Properties.Resources.Usuario;
            this.btnVerPerfil.ImageSize = new System.Drawing.Size(24, 24);
            this.btnVerPerfil.Location = new System.Drawing.Point(45, 145);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.ShadowDecoration.Parent = this.btnVerPerfil;
            this.btnVerPerfil.Size = new System.Drawing.Size(180, 45);
            this.btnVerPerfil.TabIndex = 0;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(14, 205);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(243, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = false;
            this.lblTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.lblTipoUsuario.Location = new System.Drawing.Point(0, 581);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(271, 52);
            this.lblTipoUsuario.TabIndex = 13;
            this.lblTipoUsuario.Text = "Admin";
            this.lblTipoUsuario.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFotoUsuario
            // 
            this.pbFotoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFotoUsuario.Location = new System.Drawing.Point(89, 42);
            this.pbFotoUsuario.Name = "pbFotoUsuario";
            this.pbFotoUsuario.ShadowDecoration.Enabled = true;
            this.pbFotoUsuario.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbFotoUsuario.ShadowDecoration.Parent = this.pbFotoUsuario;
            this.pbFotoUsuario.Size = new System.Drawing.Size(88, 88);
            this.pbFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoUsuario.TabIndex = 0;
            this.pbFotoUsuario.TabStop = false;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnlDisplay.Controls.Add(this.pbLogo);
            this.pnlDisplay.Location = new System.Drawing.Point(280, 41);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.ShadowDecoration.Parent = this.pnlDisplay;
            this.pnlDisplay.Size = new System.Drawing.Size(854, 633);
            this.pnlDisplay.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BorderRadius = 15;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::GymPro.Capa.UI.Properties.Resources._1;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.ShadowDecoration.Enabled = true;
            this.pbLogo.ShadowDecoration.Parent = this.pbLogo;
            this.pbLogo.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 5);
            this.pbLogo.Size = new System.Drawing.Size(854, 633);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // txtMulta
            // 
            this.txtMulta.BorderRadius = 10;
            this.txtMulta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMulta.DefaultText = "";
            this.txtMulta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMulta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMulta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMulta.DisabledState.Parent = this.txtMulta;
            this.txtMulta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMulta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMulta.FocusedState.Parent = this.txtMulta;
            this.txtMulta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMulta.HoverState.Parent = this.txtMulta;
            this.txtMulta.Location = new System.Drawing.Point(45, 465);
            this.txtMulta.Margin = new System.Windows.Forms.Padding(5);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.PasswordChar = '\0';
            this.txtMulta.PlaceholderText = "";
            this.txtMulta.SelectedText = "";
            this.txtMulta.ShadowDecoration.Parent = this.txtMulta;
            this.txtMulta.Size = new System.Drawing.Size(180, 34);
            this.txtMulta.TabIndex = 74;
            // 
            // lblMulta
            // 
            this.lblMulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMulta.AutoSize = false;
            this.lblMulta.BackColor = System.Drawing.Color.Transparent;
            this.lblMulta.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMulta.Location = new System.Drawing.Point(45, 436);
            this.lblMulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(180, 38);
            this.lblMulta.TabIndex = 73;
            this.lblMulta.Text = "Multa";
            this.lblMulta.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnModificarMulta
            // 
            this.btnModificarMulta.BorderRadius = 10;
            this.btnModificarMulta.CheckedState.Parent = this.btnModificarMulta;
            this.btnModificarMulta.CustomImages.Parent = this.btnModificarMulta;
            this.btnModificarMulta.FillColor = System.Drawing.Color.Lime;
            this.btnModificarMulta.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnModificarMulta.ForeColor = System.Drawing.Color.Teal;
            this.btnModificarMulta.HoverState.Parent = this.btnModificarMulta;
            this.btnModificarMulta.Image = global::GymPro.Capa.UI.Properties.Resources.Editar;
            this.btnModificarMulta.ImageSize = new System.Drawing.Size(24, 24);
            this.btnModificarMulta.Location = new System.Drawing.Point(45, 507);
            this.btnModificarMulta.Name = "btnModificarMulta";
            this.btnModificarMulta.ShadowDecoration.Parent = this.btnModificarMulta;
            this.btnModificarMulta.Size = new System.Drawing.Size(180, 45);
            this.btnModificarMulta.TabIndex = 75;
            this.btnModificarMulta.Text = "Modificar Multa";
            this.btnModificarMulta.Click += new System.EventHandler(this.btnModificarMulta_Click);
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 686);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.FrmDashBoard_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUsuario)).EndInit();
            this.pnlDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimizar;
        private Guna.UI2.WinForms.Guna2CircleButton btnSalir;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombreUsuario;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnlDisplay;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbFotoUsuario;
        private Guna.UI2.WinForms.Guna2Button btnVerPerfil;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTipoUsuario;
        private Guna.UI2.WinForms.Guna2Button btnReportes;
        private Guna.UI2.WinForms.Guna2Button btnProcesos;
        private Guna.UI2.WinForms.Guna2Button btnMantenimientos;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2TextBox txtMulta;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMulta;
        private Guna.UI2.WinForms.Guna2Button btnModificarMulta;
    }
}