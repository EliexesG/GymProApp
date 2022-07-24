
namespace GymPro.Capa.UI.InicioSesion
{
    partial class FrmLogIn
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
            this.lblRegistrarse = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnIngresar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtContrasenna = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtIdentificacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMensajeError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrarse.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarse.ForeColor = System.Drawing.Color.Tomato;
            this.lblRegistrarse.Location = new System.Drawing.Point(292, 326);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(226, 23);
            this.lblRegistrarse.TabIndex = 13;
            this.lblRegistrarse.Text = "No tienes cuenta? Registrate!";
            this.lblRegistrarse.Click += new System.EventHandler(this.lblRegistrarse_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BorderRadius = 10;
            this.btnIngresar.CheckedState.Parent = this.btnIngresar;
            this.btnIngresar.CustomImages.Parent = this.btnIngresar;
            this.btnIngresar.FillColor = System.Drawing.Color.Lime;
            this.btnIngresar.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresar.HoverState.Parent = this.btnIngresar;
            this.btnIngresar.Location = new System.Drawing.Point(315, 275);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.ShadowDecoration.Parent = this.btnIngresar;
            this.btnIngresar.Size = new System.Drawing.Size(180, 45);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(258, 183);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(90, 23);
            this.guna2HtmlLabel3.TabIndex = 11;
            this.guna2HtmlLabel3.Text = "Contraseña";
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.BorderRadius = 10;
            this.txtContrasenna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasenna.DefaultText = "";
            this.txtContrasenna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContrasenna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContrasenna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasenna.DisabledState.Parent = this.txtContrasenna;
            this.txtContrasenna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasenna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasenna.FocusedState.Parent = this.txtContrasenna;
            this.txtContrasenna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasenna.HoverState.Parent = this.txtContrasenna;
            this.txtContrasenna.Location = new System.Drawing.Point(249, 213);
            this.txtContrasenna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.PasswordChar = '●';
            this.txtContrasenna.PlaceholderText = "";
            this.txtContrasenna.SelectedText = "";
            this.txtContrasenna.ShadowDecoration.Parent = this.txtContrasenna;
            this.txtContrasenna.Size = new System.Drawing.Size(313, 44);
            this.txtContrasenna.TabIndex = 10;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(258, 92);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(101, 23);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "Identificacion";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BorderRadius = 10;
            this.txtIdentificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentificacion.DefaultText = "";
            this.txtIdentificacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdentificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdentificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentificacion.DisabledState.Parent = this.txtIdentificacion;
            this.txtIdentificacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentificacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentificacion.FocusedState.Parent = this.txtIdentificacion;
            this.txtIdentificacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentificacion.HoverState.Parent = this.txtIdentificacion;
            this.txtIdentificacion.Location = new System.Drawing.Point(249, 122);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.PasswordChar = '\0';
            this.txtIdentificacion.PlaceholderText = "";
            this.txtIdentificacion.SelectedText = "";
            this.txtIdentificacion.ShadowDecoration.Parent = this.txtIdentificacion;
            this.txtIdentificacion.Size = new System.Drawing.Size(313, 44);
            this.txtIdentificacion.TabIndex = 8;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(353, 45);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(105, 42);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "LOG IN";
            // 
            // Errores
            // 
            this.Errores.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Errores.ContainerControl = this;
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensajeError.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajeError.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeError.ForeColor = System.Drawing.Color.Tomato;
            this.lblMensajeError.Location = new System.Drawing.Point(278, 16);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(254, 23);
            this.lblMensajeError.TabIndex = 14;
            this.lblMensajeError.Text = "Usuario o contraseña incorrectos";
            this.lblMensajeError.Visible = false;
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.lblRegistrarse);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtContrasenna);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogIn";
            this.Text = "FrmLogIn";
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblRegistrarse;
        private Guna.UI2.WinForms.Guna2Button btnIngresar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasenna;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtIdentificacion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ErrorProvider Errores;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMensajeError;
    }
}