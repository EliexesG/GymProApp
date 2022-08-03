
namespace GymPro.Capa.UI.DashBoard.Procesos
{
    partial class FrmProcesoControlIngresoEgreso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegistrarIngreso = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrarEgreso = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblContador = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtIdentificacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFecha = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHoraIngreso = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHoraEgreso = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvControlIngresoEgreso = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlIngresoEgreso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarIngreso
            // 
            this.btnRegistrarIngreso.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarIngreso.BorderRadius = 10;
            this.btnRegistrarIngreso.CheckedState.Parent = this.btnRegistrarIngreso;
            this.btnRegistrarIngreso.CustomImages.Parent = this.btnRegistrarIngreso;
            this.btnRegistrarIngreso.FillColor = System.Drawing.Color.Lime;
            this.btnRegistrarIngreso.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnRegistrarIngreso.ForeColor = System.Drawing.Color.Teal;
            this.btnRegistrarIngreso.HoverState.Parent = this.btnRegistrarIngreso;
            this.btnRegistrarIngreso.Image = global::GymPro.Capa.UI.Properties.Resources.Guardar;
            this.btnRegistrarIngreso.ImageSize = new System.Drawing.Size(24, 24);
            this.btnRegistrarIngreso.Location = new System.Drawing.Point(12, 12);
            this.btnRegistrarIngreso.Name = "btnRegistrarIngreso";
            this.btnRegistrarIngreso.ShadowDecoration.Parent = this.btnRegistrarIngreso;
            this.btnRegistrarIngreso.Size = new System.Drawing.Size(252, 45);
            this.btnRegistrarIngreso.TabIndex = 16;
            this.btnRegistrarIngreso.Text = "Registrar Ingreso";
            this.btnRegistrarIngreso.Click += new System.EventHandler(this.btnRegistrarIngreso_Click);
            // 
            // btnRegistrarEgreso
            // 
            this.btnRegistrarEgreso.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarEgreso.BorderRadius = 10;
            this.btnRegistrarEgreso.CheckedState.Parent = this.btnRegistrarEgreso;
            this.btnRegistrarEgreso.CustomImages.Parent = this.btnRegistrarEgreso;
            this.btnRegistrarEgreso.FillColor = System.Drawing.Color.Lime;
            this.btnRegistrarEgreso.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.btnRegistrarEgreso.ForeColor = System.Drawing.Color.Teal;
            this.btnRegistrarEgreso.HoverState.Parent = this.btnRegistrarEgreso;
            this.btnRegistrarEgreso.Image = global::GymPro.Capa.UI.Properties.Resources.Guardar;
            this.btnRegistrarEgreso.ImageSize = new System.Drawing.Size(24, 24);
            this.btnRegistrarEgreso.Location = new System.Drawing.Point(590, 12);
            this.btnRegistrarEgreso.Name = "btnRegistrarEgreso";
            this.btnRegistrarEgreso.ShadowDecoration.Parent = this.btnRegistrarEgreso;
            this.btnRegistrarEgreso.Size = new System.Drawing.Size(252, 45);
            this.btnRegistrarEgreso.TabIndex = 17;
            this.btnRegistrarEgreso.Text = "Registrar Egreso";
            this.btnRegistrarEgreso.Click += new System.EventHandler(this.btnRegistrarEgreso_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(270, 29);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(76, 10);
            this.guna2Separator1.TabIndex = 18;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(508, 29);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(76, 10);
            this.guna2Separator2.TabIndex = 19;
            // 
            // lblContador
            // 
            this.lblContador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContador.AutoSize = false;
            this.lblContador.BackColor = System.Drawing.Color.Transparent;
            this.lblContador.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(352, 12);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(150, 42);
            this.lblContador.TabIndex = 20;
            this.lblContador.Text = "Contador";
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
            this.txtIdentificacion.Enabled = false;
            this.txtIdentificacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentificacion.FocusedState.Parent = this.txtIdentificacion;
            this.txtIdentificacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentificacion.HoverState.Parent = this.txtIdentificacion;
            this.txtIdentificacion.Location = new System.Drawing.Point(12, 119);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.PasswordChar = '\0';
            this.txtIdentificacion.PlaceholderText = "000000000";
            this.txtIdentificacion.SelectedText = "";
            this.txtIdentificacion.ShadowDecoration.Parent = this.txtIdentificacion;
            this.txtIdentificacion.Size = new System.Drawing.Size(202, 34);
            this.txtIdentificacion.TabIndex = 80;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(19, 89);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(124, 23);
            this.guna2HtmlLabel3.TabIndex = 79;
            this.guna2HtmlLabel3.Text = "Identificación";
            // 
            // txtFecha
            // 
            this.txtFecha.BorderRadius = 10;
            this.txtFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFecha.DefaultText = "";
            this.txtFecha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFecha.DisabledState.Parent = this.txtFecha;
            this.txtFecha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFecha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFecha.FocusedState.Parent = this.txtFecha;
            this.txtFecha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFecha.HoverState.Parent = this.txtFecha;
            this.txtFecha.Location = new System.Drawing.Point(254, 119);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(5);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.PasswordChar = '\0';
            this.txtFecha.PlaceholderText = "00/00/0000";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.SelectedText = "";
            this.txtFecha.ShadowDecoration.Parent = this.txtFecha;
            this.txtFecha.Size = new System.Drawing.Size(168, 34);
            this.txtFecha.TabIndex = 82;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(270, 89);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(124, 23);
            this.guna2HtmlLabel2.TabIndex = 81;
            this.guna2HtmlLabel2.Text = "Fecha";
            // 
            // txtHoraIngreso
            // 
            this.txtHoraIngreso.BorderRadius = 10;
            this.txtHoraIngreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoraIngreso.DefaultText = "";
            this.txtHoraIngreso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoraIngreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoraIngreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoraIngreso.DisabledState.Parent = this.txtHoraIngreso;
            this.txtHoraIngreso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoraIngreso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoraIngreso.FocusedState.Parent = this.txtHoraIngreso;
            this.txtHoraIngreso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoraIngreso.HoverState.Parent = this.txtHoraIngreso;
            this.txtHoraIngreso.Location = new System.Drawing.Point(462, 119);
            this.txtHoraIngreso.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoraIngreso.Name = "txtHoraIngreso";
            this.txtHoraIngreso.PasswordChar = '\0';
            this.txtHoraIngreso.PlaceholderText = "00:00";
            this.txtHoraIngreso.ReadOnly = true;
            this.txtHoraIngreso.SelectedText = "";
            this.txtHoraIngreso.ShadowDecoration.Parent = this.txtHoraIngreso;
            this.txtHoraIngreso.Size = new System.Drawing.Size(168, 34);
            this.txtHoraIngreso.TabIndex = 84;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(471, 89);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(124, 23);
            this.guna2HtmlLabel4.TabIndex = 83;
            this.guna2HtmlLabel4.Text = "Hora Ingreso";
            // 
            // txtHoraEgreso
            // 
            this.txtHoraEgreso.BorderRadius = 10;
            this.txtHoraEgreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoraEgreso.DefaultText = "";
            this.txtHoraEgreso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoraEgreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoraEgreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoraEgreso.DisabledState.Parent = this.txtHoraEgreso;
            this.txtHoraEgreso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoraEgreso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoraEgreso.FocusedState.Parent = this.txtHoraEgreso;
            this.txtHoraEgreso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoraEgreso.HoverState.Parent = this.txtHoraEgreso;
            this.txtHoraEgreso.Location = new System.Drawing.Point(670, 119);
            this.txtHoraEgreso.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoraEgreso.Name = "txtHoraEgreso";
            this.txtHoraEgreso.PasswordChar = '\0';
            this.txtHoraEgreso.PlaceholderText = "00:00";
            this.txtHoraEgreso.ReadOnly = true;
            this.txtHoraEgreso.SelectedText = "";
            this.txtHoraEgreso.ShadowDecoration.Parent = this.txtHoraEgreso;
            this.txtHoraEgreso.Size = new System.Drawing.Size(168, 34);
            this.txtHoraEgreso.TabIndex = 86;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(679, 89);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(124, 23);
            this.guna2HtmlLabel5.TabIndex = 85;
            this.guna2HtmlLabel5.Text = "Hora Egreso";
            // 
            // dgvControlIngresoEgreso
            // 
            this.dgvControlIngresoEgreso.AllowUserToAddRows = false;
            this.dgvControlIngresoEgreso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvControlIngresoEgreso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvControlIngresoEgreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvControlIngresoEgreso.BackgroundColor = System.Drawing.Color.White;
            this.dgvControlIngresoEgreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvControlIngresoEgreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvControlIngresoEgreso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvControlIngresoEgreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvControlIngresoEgreso.ColumnHeadersHeight = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvControlIngresoEgreso.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvControlIngresoEgreso.EnableHeadersVisualStyles = false;
            this.dgvControlIngresoEgreso.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvControlIngresoEgreso.Location = new System.Drawing.Point(12, 207);
            this.dgvControlIngresoEgreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvControlIngresoEgreso.MultiSelect = false;
            this.dgvControlIngresoEgreso.Name = "dgvControlIngresoEgreso";
            this.dgvControlIngresoEgreso.ReadOnly = true;
            this.dgvControlIngresoEgreso.RowHeadersVisible = false;
            this.dgvControlIngresoEgreso.RowHeadersWidth = 51;
            this.dgvControlIngresoEgreso.RowTemplate.Height = 24;
            this.dgvControlIngresoEgreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvControlIngresoEgreso.Size = new System.Drawing.Size(826, 345);
            this.dgvControlIngresoEgreso.TabIndex = 87;
            this.dgvControlIngresoEgreso.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvControlIngresoEgreso.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvControlIngresoEgreso.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvControlIngresoEgreso.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvControlIngresoEgreso.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvControlIngresoEgreso.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvControlIngresoEgreso.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvControlIngresoEgreso.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvControlIngresoEgreso.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvControlIngresoEgreso.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvControlIngresoEgreso.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvControlIngresoEgreso.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvControlIngresoEgreso.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvControlIngresoEgreso.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvControlIngresoEgreso.ThemeStyle.ReadOnly = true;
            this.dgvControlIngresoEgreso.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvControlIngresoEgreso.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvControlIngresoEgreso.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvControlIngresoEgreso.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvControlIngresoEgreso.ThemeStyle.RowsStyle.Height = 24;
            this.dgvControlIngresoEgreso.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvControlIngresoEgreso.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // FrmProcesoControlIngresoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.dgvControlIngresoEgreso);
            this.Controls.Add(this.txtHoraEgreso);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.txtHoraIngreso);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnRegistrarEgreso);
            this.Controls.Add(this.btnRegistrarIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProcesoControlIngresoEgreso";
            this.Text = "FrmProcesoControlIngresoEgreso";
            this.Load += new System.EventHandler(this.FrmProcesoControlIngresoEgreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlIngresoEgreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRegistrarIngreso;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarEgreso;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContador;
        private Guna.UI2.WinForms.Guna2TextBox txtIdentificacion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtFecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtHoraIngreso;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtHoraEgreso;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvControlIngresoEgreso;
    }
}