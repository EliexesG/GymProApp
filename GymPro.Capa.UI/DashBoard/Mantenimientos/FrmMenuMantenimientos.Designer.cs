
namespace GymPro.Capa.UI.DashBoard.Mantenimientos
{
    partial class FrmMenuMantenimientos
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnTiposEntrenamientos = new Guna.UI2.WinForms.Guna2Button();
            this.btnEjercicios = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDisplay = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 10;
            this.guna2GradientPanel1.Controls.Add(this.guna2VSeparator2);
            this.guna2GradientPanel1.Controls.Add(this.guna2VSeparator1);
            this.guna2GradientPanel1.Controls.Add(this.btnTiposEntrenamientos);
            this.guna2GradientPanel1.Controls.Add(this.btnEjercicios);
            this.guna2GradientPanel1.Controls.Add(this.btnUsuarios);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Green;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(854, 64);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator2.Location = new System.Drawing.Point(573, 6);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(14, 52);
            this.guna2VSeparator2.TabIndex = 20;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.Location = new System.Drawing.Point(265, 6);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(14, 52);
            this.guna2VSeparator1.TabIndex = 19;
            // 
            // btnTiposEntrenamientos
            // 
            this.btnTiposEntrenamientos.BackColor = System.Drawing.Color.Transparent;
            this.btnTiposEntrenamientos.BorderRadius = 10;
            this.btnTiposEntrenamientos.CheckedState.Parent = this.btnTiposEntrenamientos;
            this.btnTiposEntrenamientos.CustomImages.Parent = this.btnTiposEntrenamientos;
            this.btnTiposEntrenamientos.FillColor = System.Drawing.Color.Lime;
            this.btnTiposEntrenamientos.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnTiposEntrenamientos.ForeColor = System.Drawing.Color.Teal;
            this.btnTiposEntrenamientos.HoverState.Parent = this.btnTiposEntrenamientos;
            this.btnTiposEntrenamientos.Image = global::GymPro.Capa.UI.Properties.Resources.TipoEjercicio;
            this.btnTiposEntrenamientos.ImageSize = new System.Drawing.Size(24, 24);
            this.btnTiposEntrenamientos.Location = new System.Drawing.Point(628, 10);
            this.btnTiposEntrenamientos.Name = "btnTiposEntrenamientos";
            this.btnTiposEntrenamientos.ShadowDecoration.Parent = this.btnTiposEntrenamientos;
            this.btnTiposEntrenamientos.Size = new System.Drawing.Size(212, 45);
            this.btnTiposEntrenamientos.TabIndex = 18;
            this.btnTiposEntrenamientos.Text = "Tipos de Ejercicio";
            this.btnTiposEntrenamientos.Click += new System.EventHandler(this.btnTiposEntrenamientos_Click);
            // 
            // btnEjercicios
            // 
            this.btnEjercicios.BackColor = System.Drawing.Color.Transparent;
            this.btnEjercicios.BorderRadius = 10;
            this.btnEjercicios.CheckedState.Parent = this.btnEjercicios;
            this.btnEjercicios.CustomImages.Parent = this.btnEjercicios;
            this.btnEjercicios.FillColor = System.Drawing.Color.Lime;
            this.btnEjercicios.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnEjercicios.ForeColor = System.Drawing.Color.Teal;
            this.btnEjercicios.HoverState.Parent = this.btnEjercicios;
            this.btnEjercicios.Image = global::GymPro.Capa.UI.Properties.Resources.Ejercicio;
            this.btnEjercicios.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEjercicios.Location = new System.Drawing.Point(320, 10);
            this.btnEjercicios.Name = "btnEjercicios";
            this.btnEjercicios.ShadowDecoration.Parent = this.btnEjercicios;
            this.btnEjercicios.Size = new System.Drawing.Size(212, 45);
            this.btnEjercicios.TabIndex = 16;
            this.btnEjercicios.Text = "Ejercicios";
            this.btnEjercicios.Click += new System.EventHandler(this.btnEjercicios_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.BorderRadius = 10;
            this.btnUsuarios.CheckedState.Parent = this.btnUsuarios;
            this.btnUsuarios.CustomImages.Parent = this.btnUsuarios;
            this.btnUsuarios.FillColor = System.Drawing.Color.Lime;
            this.btnUsuarios.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.Teal;
            this.btnUsuarios.HoverState.Parent = this.btnUsuarios;
            this.btnUsuarios.Image = global::GymPro.Capa.UI.Properties.Resources.Usuario;
            this.btnUsuarios.ImageSize = new System.Drawing.Size(24, 24);
            this.btnUsuarios.Location = new System.Drawing.Point(12, 10);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.ShadowDecoration.Parent = this.btnUsuarios;
            this.btnUsuarios.Size = new System.Drawing.Size(212, 45);
            this.btnUsuarios.TabIndex = 15;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 70);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.ShadowDecoration.Parent = this.pnlDisplay;
            this.pnlDisplay.Size = new System.Drawing.Size(854, 563);
            this.pnlDisplay.TabIndex = 1;
            // 
            // FrmMenuMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 633);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuMantenimientos";
            this.Text = "FrmMenuMantenimientos";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnlDisplay;
        private Guna.UI2.WinForms.Guna2Button btnUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnTiposEntrenamientos;
        private Guna.UI2.WinForms.Guna2Button btnEjercicios;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}