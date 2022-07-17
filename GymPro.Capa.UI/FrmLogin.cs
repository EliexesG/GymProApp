using GymPro.Capa.Util;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro.Capa.UI
{
    public partial class FrmLogin : MaterialForm
    {

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public FrmLogin()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.Orange700, MaterialSkin.Primary.Orange300, MaterialSkin.Accent.Orange100, MaterialSkin.TextShade.BLACK);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Utilitarios.CultureInfo();
        }
    }
}
