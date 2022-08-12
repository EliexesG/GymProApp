
namespace GymPro.Capa.UI.DashBoard.Procesos
{
    partial class FrmProcesoEjercicioEnEntrenamiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbTipoEjercicio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbEjercicio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNombreEntrenamiento = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRepeticiones = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSeries = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTiempo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPeso = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvEjercicioEnEntrenamiento = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Errores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicioEnEntrenamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(564, 11);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(180, 46);
            this.btnCancelar.TabIndex = 125;
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
            this.btnModificar.Location = new System.Drawing.Point(196, 11);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(180, 46);
            this.btnModificar.TabIndex = 124;
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
            this.btnEliminar.Location = new System.Drawing.Point(380, 11);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(180, 46);
            this.btnEliminar.TabIndex = 123;
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
            this.btnGuardar.Location = new System.Drawing.Point(12, 11);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(180, 46);
            this.btnGuardar.TabIndex = 122;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BorderRadius = 10;
            this.btnCerrar.CheckedState.Parent = this.btnCerrar;
            this.btnCerrar.CustomImages.Parent = this.btnCerrar;
            this.btnCerrar.FillColor = System.Drawing.Color.Lime;
            this.btnCerrar.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnCerrar.ForeColor = System.Drawing.Color.Teal;
            this.btnCerrar.HoverState.Parent = this.btnCerrar;
            this.btnCerrar.Image = global::GymPro.Capa.UI.Properties.Resources.Cancelar;
            this.btnCerrar.ImageSize = new System.Drawing.Size(24, 24);
            this.btnCerrar.Location = new System.Drawing.Point(748, 11);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Parent = this.btnCerrar;
            this.btnCerrar.Size = new System.Drawing.Size(165, 46);
            this.btnCerrar.TabIndex = 126;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.cmbTipoEjercicio.Location = new System.Drawing.Point(391, 119);
            this.cmbTipoEjercicio.Name = "cmbTipoEjercicio";
            this.cmbTipoEjercicio.ShadowDecoration.Parent = this.cmbTipoEjercicio;
            this.cmbTipoEjercicio.Size = new System.Drawing.Size(188, 36);
            this.cmbTipoEjercicio.TabIndex = 127;
            this.cmbTipoEjercicio.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEjercicio_SelectedIndexChanged);
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.cmbEjercicio.BorderRadius = 10;
            this.cmbEjercicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEjercicio.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEjercicio.FocusedState.Parent = this.cmbEjercicio;
            this.cmbEjercicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEjercicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.HoverState.Parent = this.cmbEjercicio;
            this.cmbEjercicio.ItemHeight = 30;
            this.cmbEjercicio.ItemsAppearance.Parent = this.cmbEjercicio;
            this.cmbEjercicio.Location = new System.Drawing.Point(612, 119);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.ShadowDecoration.Parent = this.cmbEjercicio;
            this.cmbEjercicio.Size = new System.Drawing.Size(301, 36);
            this.cmbEjercicio.TabIndex = 128;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(391, 86);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(188, 23);
            this.guna2HtmlLabel8.TabIndex = 129;
            this.guna2HtmlLabel8.Text = "Tipo de Ejercicio";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(612, 86);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(188, 23);
            this.guna2HtmlLabel1.TabIndex = 130;
            this.guna2HtmlLabel1.Text = "Ejercicio";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(14, 86);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(188, 23);
            this.guna2HtmlLabel2.TabIndex = 132;
            this.guna2HtmlLabel2.Text = "Entrenamiento";
            // 
            // txtNombreEntrenamiento
            // 
            this.txtNombreEntrenamiento.BorderRadius = 10;
            this.txtNombreEntrenamiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreEntrenamiento.DefaultText = "";
            this.txtNombreEntrenamiento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreEntrenamiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreEntrenamiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreEntrenamiento.DisabledState.Parent = this.txtNombreEntrenamiento;
            this.txtNombreEntrenamiento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreEntrenamiento.Enabled = false;
            this.txtNombreEntrenamiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreEntrenamiento.FocusedState.Parent = this.txtNombreEntrenamiento;
            this.txtNombreEntrenamiento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreEntrenamiento.HoverState.Parent = this.txtNombreEntrenamiento;
            this.txtNombreEntrenamiento.Location = new System.Drawing.Point(12, 115);
            this.txtNombreEntrenamiento.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreEntrenamiento.Name = "txtNombreEntrenamiento";
            this.txtNombreEntrenamiento.PasswordChar = '\0';
            this.txtNombreEntrenamiento.PlaceholderText = "";
            this.txtNombreEntrenamiento.SelectedText = "";
            this.txtNombreEntrenamiento.ShadowDecoration.Parent = this.txtNombreEntrenamiento;
            this.txtNombreEntrenamiento.Size = new System.Drawing.Size(339, 44);
            this.txtNombreEntrenamiento.TabIndex = 133;
            // 
            // txtRepeticiones
            // 
            this.txtRepeticiones.BorderRadius = 10;
            this.txtRepeticiones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepeticiones.DefaultText = "";
            this.txtRepeticiones.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRepeticiones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRepeticiones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepeticiones.DisabledState.Parent = this.txtRepeticiones;
            this.txtRepeticiones.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepeticiones.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRepeticiones.FocusedState.Parent = this.txtRepeticiones;
            this.txtRepeticiones.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRepeticiones.HoverState.Parent = this.txtRepeticiones;
            this.txtRepeticiones.Location = new System.Drawing.Point(147, 218);
            this.txtRepeticiones.Margin = new System.Windows.Forms.Padding(5);
            this.txtRepeticiones.Name = "txtRepeticiones";
            this.txtRepeticiones.PasswordChar = '\0';
            this.txtRepeticiones.PlaceholderText = "";
            this.txtRepeticiones.SelectedText = "";
            this.txtRepeticiones.ShadowDecoration.Parent = this.txtRepeticiones;
            this.txtRepeticiones.Size = new System.Drawing.Size(130, 44);
            this.txtRepeticiones.TabIndex = 135;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(149, 189);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(188, 23);
            this.guna2HtmlLabel3.TabIndex = 134;
            this.guna2HtmlLabel3.Text = "Repeticiones";
            // 
            // txtSeries
            // 
            this.txtSeries.BorderRadius = 10;
            this.txtSeries.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeries.DefaultText = "";
            this.txtSeries.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeries.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeries.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeries.DisabledState.Parent = this.txtSeries;
            this.txtSeries.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeries.FocusedState.Parent = this.txtSeries;
            this.txtSeries.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeries.HoverState.Parent = this.txtSeries;
            this.txtSeries.Location = new System.Drawing.Point(303, 218);
            this.txtSeries.Margin = new System.Windows.Forms.Padding(5);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.PasswordChar = '\0';
            this.txtSeries.PlaceholderText = "";
            this.txtSeries.SelectedText = "";
            this.txtSeries.ShadowDecoration.Parent = this.txtSeries;
            this.txtSeries.Size = new System.Drawing.Size(130, 44);
            this.txtSeries.TabIndex = 137;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(303, 189);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(188, 23);
            this.guna2HtmlLabel4.TabIndex = 136;
            this.guna2HtmlLabel4.Text = "Series";
            // 
            // txtTiempo
            // 
            this.txtTiempo.BorderRadius = 10;
            this.txtTiempo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTiempo.DefaultText = "";
            this.txtTiempo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTiempo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTiempo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTiempo.DisabledState.Parent = this.txtTiempo;
            this.txtTiempo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTiempo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTiempo.FocusedState.Parent = this.txtTiempo;
            this.txtTiempo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTiempo.HoverState.Parent = this.txtTiempo;
            this.txtTiempo.Location = new System.Drawing.Point(615, 218);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(5);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.PasswordChar = '\0';
            this.txtTiempo.PlaceholderText = "";
            this.txtTiempo.SelectedText = "";
            this.txtTiempo.ShadowDecoration.Parent = this.txtTiempo;
            this.txtTiempo.Size = new System.Drawing.Size(130, 44);
            this.txtTiempo.TabIndex = 139;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(618, 189);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(188, 23);
            this.guna2HtmlLabel5.TabIndex = 138;
            this.guna2HtmlLabel5.Text = "Tiempo (Min)";
            // 
            // txtPeso
            // 
            this.txtPeso.BorderRadius = 10;
            this.txtPeso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPeso.DefaultText = "";
            this.txtPeso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPeso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPeso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPeso.DisabledState.Parent = this.txtPeso;
            this.txtPeso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPeso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPeso.FocusedState.Parent = this.txtPeso;
            this.txtPeso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPeso.HoverState.Parent = this.txtPeso;
            this.txtPeso.Location = new System.Drawing.Point(459, 218);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(5);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PasswordChar = '\0';
            this.txtPeso.PlaceholderText = "";
            this.txtPeso.SelectedText = "";
            this.txtPeso.ShadowDecoration.Parent = this.txtPeso;
            this.txtPeso.Size = new System.Drawing.Size(130, 44);
            this.txtPeso.TabIndex = 141;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(459, 189);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(147, 23);
            this.guna2HtmlLabel6.TabIndex = 140;
            this.guna2HtmlLabel6.Text = "Peso";
            // 
            // dgvEjercicioEnEntrenamiento
            // 
            this.dgvEjercicioEnEntrenamiento.AllowUserToAddRows = false;
            this.dgvEjercicioEnEntrenamiento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvEjercicioEnEntrenamiento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEjercicioEnEntrenamiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEjercicioEnEntrenamiento.BackgroundColor = System.Drawing.Color.White;
            this.dgvEjercicioEnEntrenamiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEjercicioEnEntrenamiento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEjercicioEnEntrenamiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjercicioEnEntrenamiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEjercicioEnEntrenamiento.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEjercicioEnEntrenamiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEjercicioEnEntrenamiento.EnableHeadersVisualStyles = false;
            this.dgvEjercicioEnEntrenamiento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvEjercicioEnEntrenamiento.Location = new System.Drawing.Point(12, 295);
            this.dgvEjercicioEnEntrenamiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEjercicioEnEntrenamiento.MultiSelect = false;
            this.dgvEjercicioEnEntrenamiento.Name = "dgvEjercicioEnEntrenamiento";
            this.dgvEjercicioEnEntrenamiento.ReadOnly = true;
            this.dgvEjercicioEnEntrenamiento.RowHeadersVisible = false;
            this.dgvEjercicioEnEntrenamiento.RowHeadersWidth = 51;
            this.dgvEjercicioEnEntrenamiento.RowTemplate.Height = 24;
            this.dgvEjercicioEnEntrenamiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEjercicioEnEntrenamiento.Size = new System.Drawing.Size(899, 257);
            this.dgvEjercicioEnEntrenamiento.TabIndex = 142;
            this.dgvEjercicioEnEntrenamiento.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.ReadOnly = true;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.RowsStyle.Height = 24;
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvEjercicioEnEntrenamiento.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEjercicioEnEntrenamiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEjercicioEnEntrenamiento_CellContentClick);
            // 
            // Errores
            // 
            this.Errores.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Errores.ContainerControl = this;
            // 
            // FrmProcesoEjercicioEnEntrenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 563);
            this.Controls.Add(this.dgvEjercicioEnEntrenamiento);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtRepeticiones);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtNombreEntrenamiento);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.cmbEjercicio);
            this.Controls.Add(this.cmbTipoEjercicio);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProcesoEjercicioEnEntrenamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProcesoEjercicioEnEntrenamiento";
            this.Load += new System.EventHandler(this.FrmProcesoEjercicioEnEntrenamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicioEnEntrenamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoEjercicio;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEjercicio;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreEntrenamiento;
        private Guna.UI2.WinForms.Guna2TextBox txtRepeticiones;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtSeries;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtTiempo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtPeso;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEjercicioEnEntrenamiento;
        private System.Windows.Forms.ErrorProvider Errores;
    }
}