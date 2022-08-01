
namespace GymPro.Capa.UI.DashBoard.Mantenimientos
{
    partial class FrmMantenimientoEjercicios
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
            Guna.UI2.WinForms.Guna2ShadowPanel btnAsignarImagen;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAsignarVideo = new Guna.UI2.WinForms.Guna2Button();
            this.pbImagen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAsignarFotografia = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbVideo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmdTipoEjercicio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvEjercicios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdBuscadorImagenes = new System.Windows.Forms.OpenFileDialog();
            this.ofdBuscadorVideos = new System.Windows.Forms.OpenFileDialog();
            btnAsignarImagen = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnAsignarImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignarImagen
            // 
            btnAsignarImagen.BackColor = System.Drawing.Color.Transparent;
            btnAsignarImagen.Controls.Add(this.btnAsignarVideo);
            btnAsignarImagen.Controls.Add(this.pbImagen);
            btnAsignarImagen.Controls.Add(this.btnAsignarFotografia);
            btnAsignarImagen.Controls.Add(this.guna2HtmlLabel5);
            btnAsignarImagen.Controls.Add(this.pbVideo);
            btnAsignarImagen.FillColor = System.Drawing.Color.White;
            btnAsignarImagen.Location = new System.Drawing.Point(12, 210);
            btnAsignarImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAsignarImagen.Name = "btnAsignarImagen";
            btnAsignarImagen.Radius = 10;
            btnAsignarImagen.ShadowColor = System.Drawing.Color.Black;
            btnAsignarImagen.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            btnAsignarImagen.Size = new System.Drawing.Size(235, 340);
            btnAsignarImagen.TabIndex = 42;
            // 
            // btnAsignarVideo
            // 
            this.btnAsignarVideo.BorderRadius = 10;
            this.btnAsignarVideo.CheckedState.Parent = this.btnAsignarVideo;
            this.btnAsignarVideo.CustomImages.Parent = this.btnAsignarVideo;
            this.btnAsignarVideo.FillColor = System.Drawing.Color.Lime;
            this.btnAsignarVideo.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnAsignarVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAsignarVideo.HoverState.Parent = this.btnAsignarVideo;
            this.btnAsignarVideo.Location = new System.Drawing.Point(35, 134);
            this.btnAsignarVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarVideo.Name = "btnAsignarVideo";
            this.btnAsignarVideo.ShadowDecoration.Parent = this.btnAsignarVideo;
            this.btnAsignarVideo.Size = new System.Drawing.Size(165, 31);
            this.btnAsignarVideo.TabIndex = 17;
            this.btnAsignarVideo.Text = "Asignar Video";
            this.btnAsignarVideo.Click += new System.EventHandler(this.btnAsignarVideo_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbImagen.Location = new System.Drawing.Point(35, 186);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.ShadowDecoration.Parent = this.pbImagen;
            this.pbImagen.Size = new System.Drawing.Size(165, 98);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 16;
            this.pbImagen.TabStop = false;
            // 
            // btnAsignarFotografia
            // 
            this.btnAsignarFotografia.BorderRadius = 10;
            this.btnAsignarFotografia.CheckedState.Parent = this.btnAsignarFotografia;
            this.btnAsignarFotografia.CustomImages.Parent = this.btnAsignarFotografia;
            this.btnAsignarFotografia.FillColor = System.Drawing.Color.Lime;
            this.btnAsignarFotografia.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnAsignarFotografia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAsignarFotografia.HoverState.Parent = this.btnAsignarFotografia;
            this.btnAsignarFotografia.Location = new System.Drawing.Point(35, 290);
            this.btnAsignarFotografia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarFotografia.Name = "btnAsignarFotografia";
            this.btnAsignarFotografia.ShadowDecoration.Parent = this.btnAsignarFotografia;
            this.btnAsignarFotografia.Size = new System.Drawing.Size(165, 31);
            this.btnAsignarFotografia.TabIndex = 14;
            this.btnAsignarFotografia.Text = "Asignar Imagen";
            this.btnAsignarFotografia.Click += new System.EventHandler(this.btnAsignarFotografia_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(45, 9);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(0, 164);
            this.guna2HtmlLabel5.TabIndex = 15;
            this.guna2HtmlLabel5.Text = "Fotografía";
            // 
            // pbVideo
            // 
            this.pbVideo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbVideo.Location = new System.Drawing.Point(35, 30);
            this.pbVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.ShadowDecoration.Parent = this.pbVideo;
            this.pbVideo.Size = new System.Drawing.Size(165, 98);
            this.pbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVideo.TabIndex = 14;
            this.pbVideo.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.Lime;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Teal;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Image = global::GymPro.Capa.UI.Properties.Resources.Cancelar;
            this.btnCancelar.ImageSize = new System.Drawing.Size(24, 24);
            this.btnCancelar.Location = new System.Drawing.Point(660, 12);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(180, 46);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BorderRadius = 10;
            this.btnModificar.CheckedState.Parent = this.btnModificar;
            this.btnModificar.CustomImages.Parent = this.btnModificar;
            this.btnModificar.FillColor = System.Drawing.Color.Lime;
            this.btnModificar.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnModificar.ForeColor = System.Drawing.Color.Teal;
            this.btnModificar.HoverState.Parent = this.btnModificar;
            this.btnModificar.Image = global::GymPro.Capa.UI.Properties.Resources.Editar;
            this.btnModificar.ImageSize = new System.Drawing.Size(24, 24);
            this.btnModificar.Location = new System.Drawing.Point(228, 12);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(180, 46);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.Lime;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnEliminar.ForeColor = System.Drawing.Color.Teal;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Image = global::GymPro.Capa.UI.Properties.Resources.Eliminar;
            this.btnEliminar.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEliminar.Location = new System.Drawing.Point(444, 12);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(180, 46);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.FillColor = System.Drawing.Color.Lime;
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.Teal;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Image = global::GymPro.Capa.UI.Properties.Resources.Guardar;
            this.btnGuardar.ImageSize = new System.Drawing.Size(24, 24);
            this.btnGuardar.Location = new System.Drawing.Point(12, 12);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(180, 46);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 107);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(81, 23);
            this.guna2HtmlLabel2.TabIndex = 34;
            this.guna2HtmlLabel2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderRadius = 10;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.DisabledState.Parent = this.txtCodigo;
            this.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.FocusedState.Parent = this.txtCodigo;
            this.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.HoverState.Parent = this.txtCodigo;
            this.txtCodigo.Location = new System.Drawing.Point(12, 137);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.ShadowDecoration.Parent = this.txtCodigo;
            this.txtCodigo.Size = new System.Drawing.Size(81, 44);
            this.txtCodigo.TabIndex = 35;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderRadius = 10;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(141, 137);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(165, 44);
            this.txtNombre.TabIndex = 37;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(141, 107);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(81, 23);
            this.guna2HtmlLabel1.TabIndex = 36;
            this.guna2HtmlLabel1.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderRadius = 10;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.DisabledState.Parent = this.txtDescripcion;
            this.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.FocusedState.Parent = this.txtDescripcion;
            this.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.HoverState.Parent = this.txtDescripcion;
            this.txtDescripcion.Location = new System.Drawing.Point(356, 135);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.ShadowDecoration.Parent = this.txtDescripcion;
            this.txtDescripcion.Size = new System.Drawing.Size(235, 44);
            this.txtDescripcion.TabIndex = 39;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(356, 107);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(103, 23);
            this.guna2HtmlLabel3.TabIndex = 38;
            this.guna2HtmlLabel3.Text = "Descripción";
            // 
            // cmdTipoEjercicio
            // 
            this.cmdTipoEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.cmdTipoEjercicio.BorderRadius = 10;
            this.cmdTipoEjercicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmdTipoEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdTipoEjercicio.FocusedColor = System.Drawing.Color.Empty;
            this.cmdTipoEjercicio.FocusedState.Parent = this.cmdTipoEjercicio;
            this.cmdTipoEjercicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmdTipoEjercicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmdTipoEjercicio.FormattingEnabled = true;
            this.cmdTipoEjercicio.HoverState.Parent = this.cmdTipoEjercicio;
            this.cmdTipoEjercicio.ItemHeight = 30;
            this.cmdTipoEjercicio.ItemsAppearance.Parent = this.cmdTipoEjercicio;
            this.cmdTipoEjercicio.Location = new System.Drawing.Point(639, 137);
            this.cmdTipoEjercicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdTipoEjercicio.Name = "cmdTipoEjercicio";
            this.cmdTipoEjercicio.ShadowDecoration.Parent = this.cmdTipoEjercicio;
            this.cmdTipoEjercicio.Size = new System.Drawing.Size(180, 36);
            this.cmdTipoEjercicio.TabIndex = 40;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(639, 108);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(140, 23);
            this.guna2HtmlLabel4.TabIndex = 41;
            this.guna2HtmlLabel4.Text = "Tipo de Ejercicio";
            // 
            // dgvEjercicios
            // 
            this.dgvEjercicios.AllowUserToAddRows = false;
            this.dgvEjercicios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvEjercicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEjercicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEjercicios.BackgroundColor = System.Drawing.Color.White;
            this.dgvEjercicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEjercicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEjercicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjercicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEjercicios.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEjercicios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEjercicios.EnableHeadersVisualStyles = false;
            this.dgvEjercicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvEjercicios.Location = new System.Drawing.Point(267, 210);
            this.dgvEjercicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEjercicios.MultiSelect = false;
            this.dgvEjercicios.Name = "dgvEjercicios";
            this.dgvEjercicios.ReadOnly = true;
            this.dgvEjercicios.RowHeadersVisible = false;
            this.dgvEjercicios.RowHeadersWidth = 51;
            this.dgvEjercicios.RowTemplate.Height = 24;
            this.dgvEjercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEjercicios.Size = new System.Drawing.Size(575, 340);
            this.dgvEjercicios.TabIndex = 29;
            this.dgvEjercicios.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvEjercicios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvEjercicios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEjercicios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEjercicios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEjercicios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEjercicios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEjercicios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvEjercicios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvEjercicios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEjercicios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEjercicios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEjercicios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEjercicios.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvEjercicios.ThemeStyle.ReadOnly = true;
            this.dgvEjercicios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvEjercicios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEjercicios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEjercicios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEjercicios.ThemeStyle.RowsStyle.Height = 24;
            this.dgvEjercicios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvEjercicios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEjercicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEjercicios_CellContentClick);
            // 
            // Errores
            // 
            this.Errores.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Errores.ContainerControl = this;
            // 
            // ofdBuscadorImagenes
            // 
            this.ofdBuscadorImagenes.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            this.ofdBuscadorImagenes.InitialDirectory = "C:\\";
            // 
            // ofdBuscadorVideos
            // 
            this.ofdBuscadorVideos.FileName = "openFileDialog1";
            this.ofdBuscadorVideos.Filter = "Video Files(*.mp4; *.gif;)|*.mp4; *.gif;";
            this.ofdBuscadorVideos.InitialDirectory = "C:\\";
            // 
            // FrmMantenimientoEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 562);
            this.Controls.Add(this.dgvEjercicios);
            this.Controls.Add(btnAsignarImagen);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.cmdTipoEjercicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMantenimientoEjercicios";
            this.Text = "FrmMantenimientoEjercicios";
            this.Load += new System.EventHandler(this.FrmMantenimientoEjercicios_Load);
            btnAsignarImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cmdTipoEjercicio;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btnAsignarFotografia;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2PictureBox pbVideo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEjercicios;
        private Guna.UI2.WinForms.Guna2Button btnAsignarVideo;
        private Guna.UI2.WinForms.Guna2PictureBox pbImagen;
        private System.Windows.Forms.ErrorProvider Errores;
        private System.Windows.Forms.OpenFileDialog ofdBuscadorImagenes;
        private System.Windows.Forms.OpenFileDialog ofdBuscadorVideos;
    }
}