﻿using GymPro.Capa.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI.DashBoard.Procesos
{
    public partial class FrmMenuProcesos : Form
    {
        IUsuario _Usuario;

        public FrmMenuProcesos(IUsuario pUsuario)
        {
            InitializeComponent();
            _Usuario = pUsuario;
        }

        public void AbrirFormEnPanel(object formhija)
        {

            if (this.pnlDisplay.Controls.Count > 0)
                this.pnlDisplay.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlDisplay.Controls.Add(fh);
            this.pnlDisplay.Tag = fh;
            fh.Show();

        }

        private void btnControlIngresoEgreso_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new FrmProcesoControlIngresoEgreso(_Usuario));
            }
            catch(Exception er)
            {
                MessageBox.Show($"Ha ocurrido un error: {er.Message}");
            }
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {

        }
    }
}
