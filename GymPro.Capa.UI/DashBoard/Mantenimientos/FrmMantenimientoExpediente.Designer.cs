
namespace GymPro.Capa.UI.DashBoard.Mantenimientos
{
    partial class FrmMantenimientoExpediente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpFechaExpediente = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtAltura = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPeso = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtIdentificacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvExpediente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbFotografia = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnBuscarUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsertar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.pbFotografia);
            this.guna2ShadowPanel1.Controls.Add(this.btnBuscarUsuario);
            this.guna2ShadowPanel1.Controls.Add(this.btnCancelar);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2ShadowPanel1.Controls.Add(this.dtpFechaExpediente);
            this.guna2ShadowPanel1.Controls.Add(this.txtAltura);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2ShadowPanel1.Controls.Add(this.txtPeso);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2ShadowPanel1.Controls.Add(this.txtIdentificacion);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2ShadowPanel1.Controls.Add(this.btnEliminar);
            this.guna2ShadowPanel1.Controls.Add(this.dgvExpediente);
            this.guna2ShadowPanel1.Controls.Add(this.btnInsertar);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(12, 12);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(824, 547);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(96, 198);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(158, 23);
            this.guna2HtmlLabel4.TabIndex = 84;
            this.guna2HtmlLabel4.Text = "Fecha";
            // 
            // dtpFechaExpediente
            // 
            this.dtpFechaExpediente.BorderRadius = 10;
            this.dtpFechaExpediente.CheckedState.Parent = this.dtpFechaExpediente;
            this.dtpFechaExpediente.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaExpediente.HoverState.Parent = this.dtpFechaExpediente;
            this.dtpFechaExpediente.Location = new System.Drawing.Point(89, 226);
            this.dtpFechaExpediente.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaExpediente.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaExpediente.Name = "dtpFechaExpediente";
            this.dtpFechaExpediente.ShadowDecoration.Parent = this.dtpFechaExpediente;
            this.dtpFechaExpediente.Size = new System.Drawing.Size(200, 36);
            this.dtpFechaExpediente.TabIndex = 83;
            this.dtpFechaExpediente.Value = new System.DateTime(2022, 7, 31, 17, 42, 10, 169);
            // 
            // txtAltura
            // 
            this.txtAltura.BorderRadius = 10;
            this.txtAltura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAltura.DefaultText = "";
            this.txtAltura.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAltura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAltura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAltura.DisabledState.Parent = this.txtAltura;
            this.txtAltura.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAltura.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAltura.FocusedState.Parent = this.txtAltura;
            this.txtAltura.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAltura.HoverState.Parent = this.txtAltura;
            this.txtAltura.Location = new System.Drawing.Point(547, 228);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(5);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.PasswordChar = '\0';
            this.txtAltura.PlaceholderText = "160";
            this.txtAltura.SelectedText = "";
            this.txtAltura.ShadowDecoration.Parent = this.txtAltura;
            this.txtAltura.Size = new System.Drawing.Size(202, 34);
            this.txtAltura.TabIndex = 82;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(554, 198);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(124, 23);
            this.guna2HtmlLabel2.TabIndex = 81;
            this.guna2HtmlLabel2.Text = "Altura (CM)";
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
            this.txtPeso.Location = new System.Drawing.Point(327, 228);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(5);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PasswordChar = '\0';
            this.txtPeso.PlaceholderText = "80";
            this.txtPeso.SelectedText = "";
            this.txtPeso.ShadowDecoration.Parent = this.txtPeso;
            this.txtPeso.Size = new System.Drawing.Size(202, 34);
            this.txtPeso.TabIndex = 80;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(334, 198);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(124, 23);
            this.guna2HtmlLabel1.TabIndex = 79;
            this.guna2HtmlLabel1.Text = "Peso (KG)";
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
            this.txtIdentificacion.Location = new System.Drawing.Point(89, 128);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.PasswordChar = '\0';
            this.txtIdentificacion.PlaceholderText = "000000000";
            this.txtIdentificacion.SelectedText = "";
            this.txtIdentificacion.ShadowDecoration.Parent = this.txtIdentificacion;
            this.txtIdentificacion.Size = new System.Drawing.Size(202, 34);
            this.txtIdentificacion.TabIndex = 78;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(96, 98);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(124, 23);
            this.guna2HtmlLabel3.TabIndex = 77;
            this.guna2HtmlLabel3.Text = "Identificación";
            // 
            // dgvExpediente
            // 
            this.dgvExpediente.AllowUserToAddRows = false;
            this.dgvExpediente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvExpediente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpediente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpediente.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpediente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExpediente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpediente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExpediente.ColumnHeadersHeight = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpediente.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExpediente.EnableHeadersVisualStyles = false;
            this.dgvExpediente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvExpediente.Location = new System.Drawing.Point(14, 278);
            this.dgvExpediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExpediente.MultiSelect = false;
            this.dgvExpediente.Name = "dgvExpediente";
            this.dgvExpediente.ReadOnly = true;
            this.dgvExpediente.RowHeadersVisible = false;
            this.dgvExpediente.RowHeadersWidth = 51;
            this.dgvExpediente.RowTemplate.Height = 24;
            this.dgvExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpediente.Size = new System.Drawing.Size(796, 245);
            this.dgvExpediente.TabIndex = 74;
            this.dgvExpediente.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvExpediente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvExpediente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvExpediente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvExpediente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvExpediente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvExpediente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvExpediente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvExpediente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvExpediente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExpediente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvExpediente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExpediente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvExpediente.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvExpediente.ThemeStyle.ReadOnly = true;
            this.dgvExpediente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvExpediente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExpediente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvExpediente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvExpediente.ThemeStyle.RowsStyle.Height = 24;
            this.dgvExpediente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvExpediente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Errores
            // 
            this.Errores.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Errores.ContainerControl = this;
            // 
            // pbFotografia
            // 
            this.pbFotografia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFotografia.BackColor = System.Drawing.Color.Transparent;
            this.pbFotografia.BackgroundImage = global::GymPro.Capa.UI.Properties.Resources._1;
            this.pbFotografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFotografia.Location = new System.Drawing.Point(663, 109);
            this.pbFotografia.Name = "pbFotografia";
            this.pbFotografia.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbFotografia.ShadowDecoration.Parent = this.pbFotografia;
            this.pbFotografia.Size = new System.Drawing.Size(85, 73);
            this.pbFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotografia.TabIndex = 84;
            this.pbFotografia.TabStop = false;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarUsuario.BorderRadius = 10;
            this.btnBuscarUsuario.CheckedState.Parent = this.btnBuscarUsuario;
            this.btnBuscarUsuario.CustomImages.Parent = this.btnBuscarUsuario;
            this.btnBuscarUsuario.FillColor = System.Drawing.Color.Lime;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.Teal;
            this.btnBuscarUsuario.HoverState.Parent = this.btnBuscarUsuario;
            this.btnBuscarUsuario.Image = global::GymPro.Capa.UI.Properties.Resources.Consultar;
            this.btnBuscarUsuario.ImageSize = new System.Drawing.Size(24, 24);
            this.btnBuscarUsuario.Location = new System.Drawing.Point(387, 122);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.ShadowDecoration.Parent = this.btnBuscarUsuario;
            this.btnBuscarUsuario.Size = new System.Drawing.Size(156, 46);
            this.btnBuscarUsuario.TabIndex = 86;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(654, 19);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(156, 46);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(334, 19);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(202, 46);
            this.btnEliminar.TabIndex = 76;
            this.btnEliminar.Text = "Eliminar Expediente";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertar.BorderRadius = 10;
            this.btnInsertar.CheckedState.Parent = this.btnInsertar;
            this.btnInsertar.CustomImages.Parent = this.btnInsertar;
            this.btnInsertar.FillColor = System.Drawing.Color.Lime;
            this.btnInsertar.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnInsertar.ForeColor = System.Drawing.Color.Teal;
            this.btnInsertar.HoverState.Parent = this.btnInsertar;
            this.btnInsertar.Image = global::GymPro.Capa.UI.Properties.Resources.Guardar;
            this.btnInsertar.ImageSize = new System.Drawing.Size(24, 24);
            this.btnInsertar.Location = new System.Drawing.Point(14, 19);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.ShadowDecoration.Parent = this.btnInsertar;
            this.btnInsertar.Size = new System.Drawing.Size(202, 46);
            this.btnInsertar.TabIndex = 31;
            this.btnInsertar.Text = "Insertar Expediente";
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // FrmMantenimientoExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 571);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMantenimientoExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMantenimientoExpediente";
            this.Load += new System.EventHandler(this.FrmMantenimientoExpediente_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvExpediente;
        private Guna.UI2.WinForms.Guna2Button btnInsertar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2TextBox txtIdentificacion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtAltura;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtPeso;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ErrorProvider Errores;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaExpediente;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnBuscarUsuario;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbFotografia;
    }
}