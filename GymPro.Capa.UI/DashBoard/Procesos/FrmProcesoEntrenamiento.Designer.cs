
namespace GymPro.Capa.UI.DashBoard.Procesos
{
    partial class FrmProcesoEntrenamiento
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbTipoBusqueda = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbInstructor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnEliminarDia = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAgregarDia = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbDiasDisponibles = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbDiasAgregados = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvEntrenamientos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEnviarCorreo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEjercicios = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.pbFotografia = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.cmbTipoBusqueda);
            this.guna2GroupBox1.Controls.Add(this.btnBuscar);
            this.guna2GroupBox1.Controls.Add(this.txtBusqueda);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(662, 135);
            this.guna2GroupBox1.TabIndex = 83;
            this.guna2GroupBox1.Text = "Buscar Usuario";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(26, 51);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(180, 23);
            this.guna2HtmlLabel1.TabIndex = 89;
            this.guna2HtmlLabel1.Text = "Tipo Busqueda";
            // 
            // cmbTipoBusqueda
            // 
            this.cmbTipoBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoBusqueda.BorderRadius = 10;
            this.cmbTipoBusqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBusqueda.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipoBusqueda.FocusedState.Parent = this.cmbTipoBusqueda;
            this.cmbTipoBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipoBusqueda.FormattingEnabled = true;
            this.cmbTipoBusqueda.HoverState.Parent = this.cmbTipoBusqueda;
            this.cmbTipoBusqueda.ItemHeight = 30;
            this.cmbTipoBusqueda.ItemsAppearance.Parent = this.cmbTipoBusqueda;
            this.cmbTipoBusqueda.Location = new System.Drawing.Point(15, 78);
            this.cmbTipoBusqueda.Name = "cmbTipoBusqueda";
            this.cmbTipoBusqueda.ShadowDecoration.Parent = this.cmbTipoBusqueda;
            this.cmbTipoBusqueda.Size = new System.Drawing.Size(191, 36);
            this.cmbTipoBusqueda.TabIndex = 88;
            this.cmbTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbTipoBusqueda_SelectedIndexChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.txtBusqueda.BorderRadius = 10;
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusqueda.DefaultText = "";
            this.txtBusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.DisabledState.Parent = this.txtBusqueda;
            this.txtBusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.FocusedState.Parent = this.txtBusqueda;
            this.txtBusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.HoverState.Parent = this.txtBusqueda;
            this.txtBusqueda.Location = new System.Drawing.Point(257, 75);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.PlaceholderText = "ejemplo@gmail.com";
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.ShadowDecoration.Parent = this.txtBusqueda;
            this.txtBusqueda.Size = new System.Drawing.Size(202, 42);
            this.txtBusqueda.TabIndex = 85;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = false;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(162, 38);
            this.lblNombre.TabIndex = 88;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Errores
            // 
            this.Errores.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Errores.ContainerControl = this;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblNombre);
            this.guna2ShadowPanel1.Controls.Add(this.pbFotografia);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(680, 12);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(162, 135);
            this.guna2ShadowPanel1.TabIndex = 89;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 153);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(830, 16);
            this.guna2Separator1.TabIndex = 90;
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
            this.txtNombre.Location = new System.Drawing.Point(137, 273);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(165, 44);
            this.txtNombre.TabIndex = 96;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(137, 243);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(81, 23);
            this.guna2HtmlLabel3.TabIndex = 95;
            this.guna2HtmlLabel3.Text = "Nombre";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(337, 243);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(188, 23);
            this.guna2HtmlLabel8.TabIndex = 113;
            this.guna2HtmlLabel8.Text = "Instructores";
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.BackColor = System.Drawing.Color.Transparent;
            this.cmbInstructor.BorderRadius = 10;
            this.cmbInstructor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstructor.FocusedColor = System.Drawing.Color.Empty;
            this.cmbInstructor.FocusedState.Parent = this.cmbInstructor;
            this.cmbInstructor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbInstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.HoverState.Parent = this.cmbInstructor;
            this.cmbInstructor.ItemHeight = 30;
            this.cmbInstructor.ItemsAppearance.Parent = this.cmbInstructor;
            this.cmbInstructor.Location = new System.Drawing.Point(337, 277);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.ShadowDecoration.Parent = this.cmbInstructor;
            this.cmbInstructor.Size = new System.Drawing.Size(157, 36);
            this.cmbInstructor.TabIndex = 112;
            // 
            // btnEliminarDia
            // 
            this.btnEliminarDia.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarDia.CheckedState.Parent = this.btnEliminarDia;
            this.btnEliminarDia.CustomImages.Parent = this.btnEliminarDia;
            this.btnEliminarDia.FillColor = System.Drawing.Color.GreenYellow;
            this.btnEliminarDia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDia.ForeColor = System.Drawing.Color.Maroon;
            this.btnEliminarDia.HoverState.Parent = this.btnEliminarDia;
            this.btnEliminarDia.Location = new System.Drawing.Point(676, 301);
            this.btnEliminarDia.Name = "btnEliminarDia";
            this.btnEliminarDia.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEliminarDia.ShadowDecoration.Parent = this.btnEliminarDia;
            this.btnEliminarDia.Size = new System.Drawing.Size(24, 24);
            this.btnEliminarDia.TabIndex = 117;
            this.btnEliminarDia.Text = "<";
            this.btnEliminarDia.Click += new System.EventHandler(this.btnEliminarDia_Click);
            // 
            // btnAgregarDia
            // 
            this.btnAgregarDia.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDia.CheckedState.Parent = this.btnAgregarDia;
            this.btnAgregarDia.CustomImages.Parent = this.btnAgregarDia;
            this.btnAgregarDia.FillColor = System.Drawing.Color.GreenYellow;
            this.btnAgregarDia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDia.ForeColor = System.Drawing.Color.Maroon;
            this.btnAgregarDia.HoverState.Parent = this.btnAgregarDia;
            this.btnAgregarDia.Location = new System.Drawing.Point(676, 271);
            this.btnAgregarDia.Name = "btnAgregarDia";
            this.btnAgregarDia.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAgregarDia.ShadowDecoration.Parent = this.btnAgregarDia;
            this.btnAgregarDia.Size = new System.Drawing.Size(24, 24);
            this.btnAgregarDia.TabIndex = 116;
            this.btnAgregarDia.Text = ">";
            this.btnAgregarDia.Click += new System.EventHandler(this.btnAgregarDia_Click);
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
            this.txtCodigo.Location = new System.Drawing.Point(14, 273);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.ShadowDecoration.Parent = this.txtCodigo;
            this.txtCodigo.Size = new System.Drawing.Size(81, 44);
            this.txtCodigo.TabIndex = 123;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(14, 243);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(81, 23);
            this.guna2HtmlLabel2.TabIndex = 122;
            this.guna2HtmlLabel2.Text = "Codigo";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(531, 243);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(164, 23);
            this.guna2HtmlLabel4.TabIndex = 125;
            this.guna2HtmlLabel4.Text = "Dias Disponible";
            // 
            // cmbDiasDisponibles
            // 
            this.cmbDiasDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.cmbDiasDisponibles.BorderRadius = 10;
            this.cmbDiasDisponibles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDiasDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiasDisponibles.FocusedColor = System.Drawing.Color.Empty;
            this.cmbDiasDisponibles.FocusedState.Parent = this.cmbDiasDisponibles;
            this.cmbDiasDisponibles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDiasDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDiasDisponibles.FormattingEnabled = true;
            this.cmbDiasDisponibles.HoverState.Parent = this.cmbDiasDisponibles;
            this.cmbDiasDisponibles.ItemHeight = 30;
            this.cmbDiasDisponibles.ItemsAppearance.Parent = this.cmbDiasDisponibles;
            this.cmbDiasDisponibles.Location = new System.Drawing.Point(531, 277);
            this.cmbDiasDisponibles.Name = "cmbDiasDisponibles";
            this.cmbDiasDisponibles.ShadowDecoration.Parent = this.cmbDiasDisponibles;
            this.cmbDiasDisponibles.Size = new System.Drawing.Size(126, 36);
            this.cmbDiasDisponibles.TabIndex = 124;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(720, 243);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(164, 23);
            this.guna2HtmlLabel5.TabIndex = 127;
            this.guna2HtmlLabel5.Text = "Dias Agregados";
            // 
            // cmbDiasAgregados
            // 
            this.cmbDiasAgregados.BackColor = System.Drawing.Color.Transparent;
            this.cmbDiasAgregados.BorderRadius = 10;
            this.cmbDiasAgregados.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDiasAgregados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiasAgregados.FocusedColor = System.Drawing.Color.Empty;
            this.cmbDiasAgregados.FocusedState.Parent = this.cmbDiasAgregados;
            this.cmbDiasAgregados.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDiasAgregados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDiasAgregados.FormattingEnabled = true;
            this.cmbDiasAgregados.HoverState.Parent = this.cmbDiasAgregados;
            this.cmbDiasAgregados.ItemHeight = 30;
            this.cmbDiasAgregados.ItemsAppearance.Parent = this.cmbDiasAgregados;
            this.cmbDiasAgregados.Location = new System.Drawing.Point(719, 277);
            this.cmbDiasAgregados.Name = "cmbDiasAgregados";
            this.cmbDiasAgregados.ShadowDecoration.Parent = this.cmbDiasAgregados;
            this.cmbDiasAgregados.Size = new System.Drawing.Size(126, 36);
            this.cmbDiasAgregados.TabIndex = 126;
            // 
            // dgvEntrenamientos
            // 
            this.dgvEntrenamientos.AllowUserToAddRows = false;
            this.dgvEntrenamientos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvEntrenamientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntrenamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntrenamientos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntrenamientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntrenamientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEntrenamientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntrenamientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntrenamientos.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntrenamientos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEntrenamientos.EnableHeadersVisualStyles = false;
            this.dgvEntrenamientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvEntrenamientos.Location = new System.Drawing.Point(12, 340);
            this.dgvEntrenamientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEntrenamientos.MultiSelect = false;
            this.dgvEntrenamientos.Name = "dgvEntrenamientos";
            this.dgvEntrenamientos.ReadOnly = true;
            this.dgvEntrenamientos.RowHeadersVisible = false;
            this.dgvEntrenamientos.RowHeadersWidth = 51;
            this.dgvEntrenamientos.RowTemplate.Height = 24;
            this.dgvEntrenamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrenamientos.Size = new System.Drawing.Size(645, 212);
            this.dgvEntrenamientos.TabIndex = 128;
            this.dgvEntrenamientos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvEntrenamientos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvEntrenamientos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEntrenamientos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEntrenamientos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEntrenamientos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEntrenamientos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEntrenamientos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvEntrenamientos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvEntrenamientos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEntrenamientos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEntrenamientos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEntrenamientos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEntrenamientos.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvEntrenamientos.ThemeStyle.ReadOnly = true;
            this.dgvEntrenamientos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvEntrenamientos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEntrenamientos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEntrenamientos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEntrenamientos.ThemeStyle.RowsStyle.Height = 24;
            this.dgvEntrenamientos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvEntrenamientos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEntrenamientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntrenamientos_CellContentClick);
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
            this.btnEnviarCorreo.Location = new System.Drawing.Point(665, 449);
            this.btnEnviarCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.ShadowDecoration.Parent = this.btnEnviarCorreo;
            this.btnEnviarCorreo.Size = new System.Drawing.Size(180, 46);
            this.btnEnviarCorreo.TabIndex = 130;
            this.btnEnviarCorreo.Text = "Enviar Correo";
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
            this.btnEjercicios.Image = global::GymPro.Capa.UI.Properties.Resources.Consultar;
            this.btnEjercicios.ImageSize = new System.Drawing.Size(24, 24);
            this.btnEjercicios.Location = new System.Drawing.Point(665, 380);
            this.btnEjercicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEjercicios.Name = "btnEjercicios";
            this.btnEjercicios.ShadowDecoration.Parent = this.btnEjercicios;
            this.btnEjercicios.Size = new System.Drawing.Size(180, 46);
            this.btnEjercicios.TabIndex = 129;
            this.btnEjercicios.Text = "Ejercicios";
            this.btnEjercicios.Click += new System.EventHandler(this.btnEjercicios_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(662, 174);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(180, 46);
            this.btnCancelar.TabIndex = 121;
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
            this.btnModificar.Location = new System.Drawing.Point(230, 174);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(180, 46);
            this.btnModificar.TabIndex = 120;
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
            this.btnEliminar.Location = new System.Drawing.Point(446, 174);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(180, 46);
            this.btnEliminar.TabIndex = 119;
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
            this.btnGuardar.Location = new System.Drawing.Point(14, 174);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(180, 46);
            this.btnGuardar.TabIndex = 118;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pbFotografia
            // 
            this.pbFotografia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFotografia.BackColor = System.Drawing.Color.Transparent;
            this.pbFotografia.BackgroundImage = global::GymPro.Capa.UI.Properties.Resources._1;
            this.pbFotografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFotografia.Location = new System.Drawing.Point(40, 43);
            this.pbFotografia.Name = "pbFotografia";
            this.pbFotografia.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbFotografia.ShadowDecoration.Parent = this.pbFotografia;
            this.pbFotografia.Size = new System.Drawing.Size(85, 73);
            this.pbFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotografia.TabIndex = 84;
            this.pbFotografia.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BorderRadius = 10;
            this.btnBuscar.CheckedState.Parent = this.btnBuscar;
            this.btnBuscar.CustomImages.Parent = this.btnBuscar;
            this.btnBuscar.FillColor = System.Drawing.Color.Lime;
            this.btnBuscar.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Teal;
            this.btnBuscar.HoverState.Parent = this.btnBuscar;
            this.btnBuscar.Image = global::GymPro.Capa.UI.Properties.Resources.Consultar;
            this.btnBuscar.ImageSize = new System.Drawing.Size(24, 24);
            this.btnBuscar.Location = new System.Drawing.Point(507, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Parent = this.btnBuscar;
            this.btnBuscar.Size = new System.Drawing.Size(138, 45);
            this.btnBuscar.TabIndex = 87;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmProcesoEntrenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.btnEnviarCorreo);
            this.Controls.Add(this.btnEjercicios);
            this.Controls.Add(this.dgvEntrenamientos);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.cmbDiasAgregados);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.cmbDiasDisponibles);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminarDia);
            this.Controls.Add(this.btnAgregarDia);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.cmbInstructor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProcesoEntrenamiento";
            this.Text = "FrmProcesoEntrenamiento";
            this.Load += new System.EventHandler(this.FrmProcesoEntrenamiento_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtBusqueda;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbFotografia;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombre;
        private System.Windows.Forms.ErrorProvider Errores;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoBusqueda;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2ComboBox cmbInstructor;
        private Guna.UI2.WinForms.Guna2CircleButton btnEliminarDia;
        private Guna.UI2.WinForms.Guna2CircleButton btnAgregarDia;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDiasDisponibles;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDiasAgregados;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEntrenamientos;
        private Guna.UI2.WinForms.Guna2Button btnEnviarCorreo;
        private Guna.UI2.WinForms.Guna2Button btnEjercicios;
    }
}