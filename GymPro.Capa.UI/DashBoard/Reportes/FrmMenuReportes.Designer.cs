
namespace GymPro.Capa.UI.DashBoard.Reportes
{
    partial class FrmMenuReportes
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
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnEntrenamientosCliente = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDisplay = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnEjerciciosMasUsados = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 10;
            this.guna2GradientPanel1.Controls.Add(this.btnEjerciciosMasUsados);
            this.guna2GradientPanel1.Controls.Add(this.guna2VSeparator1);
            this.guna2GradientPanel1.Controls.Add(this.btnEntrenamientosCliente);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Green;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(854, 64);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.Location = new System.Drawing.Point(215, 6);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(14, 52);
            this.guna2VSeparator1.TabIndex = 19;
            // 
            // btnEntrenamientosCliente
            // 
            this.btnEntrenamientosCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrenamientosCliente.BorderRadius = 10;
            this.btnEntrenamientosCliente.CheckedState.Parent = this.btnEntrenamientosCliente;
            this.btnEntrenamientosCliente.CustomImages.Parent = this.btnEntrenamientosCliente;
            this.btnEntrenamientosCliente.FillColor = System.Drawing.Color.Lime;
            this.btnEntrenamientosCliente.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnEntrenamientosCliente.ForeColor = System.Drawing.Color.Teal;
            this.btnEntrenamientosCliente.HoverState.Parent = this.btnEntrenamientosCliente;
            this.btnEntrenamientosCliente.Image = global::GymPro.Capa.UI.Properties.Resources.Entrenamiento;
            this.btnEntrenamientosCliente.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEntrenamientosCliente.Location = new System.Drawing.Point(12, 10);
            this.btnEntrenamientosCliente.Name = "btnEntrenamientosCliente";
            this.btnEntrenamientosCliente.ShadowDecoration.Parent = this.btnEntrenamientosCliente;
            this.btnEntrenamientosCliente.Size = new System.Drawing.Size(188, 45);
            this.btnEntrenamientosCliente.TabIndex = 15;
            this.btnEntrenamientosCliente.Text = "Entrenamientos";
            this.btnEntrenamientosCliente.Click += new System.EventHandler(this.btnEntrenamientosCliente_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Controls.Add(this.guna2Panel1);
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 70);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.ShadowDecoration.Parent = this.pnlDisplay;
            this.pnlDisplay.Size = new System.Drawing.Size(854, 563);
            this.pnlDisplay.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pbLogo);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(854, 563);
            this.guna2Panel1.TabIndex = 2;
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
            this.pbLogo.Size = new System.Drawing.Size(854, 563);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // btnEjerciciosMasUsados
            // 
            this.btnEjerciciosMasUsados.BackColor = System.Drawing.Color.Transparent;
            this.btnEjerciciosMasUsados.BorderRadius = 10;
            this.btnEjerciciosMasUsados.CheckedState.Parent = this.btnEjerciciosMasUsados;
            this.btnEjerciciosMasUsados.CustomImages.Parent = this.btnEjerciciosMasUsados;
            this.btnEjerciciosMasUsados.FillColor = System.Drawing.Color.Lime;
            this.btnEjerciciosMasUsados.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnEjerciciosMasUsados.ForeColor = System.Drawing.Color.Teal;
            this.btnEjerciciosMasUsados.HoverState.Parent = this.btnEjerciciosMasUsados;
            this.btnEjerciciosMasUsados.Image = global::GymPro.Capa.UI.Properties.Resources.Ejercicio;
            this.btnEjerciciosMasUsados.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEjerciciosMasUsados.Location = new System.Drawing.Point(246, 10);
            this.btnEjerciciosMasUsados.Name = "btnEjerciciosMasUsados";
            this.btnEjerciciosMasUsados.ShadowDecoration.Parent = this.btnEjerciciosMasUsados;
            this.btnEjerciciosMasUsados.Size = new System.Drawing.Size(188, 45);
            this.btnEjerciciosMasUsados.TabIndex = 20;
            this.btnEjerciciosMasUsados.Text = "Mas Usados";
            this.btnEjerciciosMasUsados.Click += new System.EventHandler(this.btnEjerciciosMasUsados_Click);
            // 
            // FrmMenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 633);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuReportes";
            this.Text = "FrmMenuReportes";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Button btnEntrenamientosCliente;
        private Guna.UI2.WinForms.Guna2Panel pnlDisplay;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2Button btnEjerciciosMasUsados;
    }
}