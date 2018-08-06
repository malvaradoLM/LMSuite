using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatVehiculo : RPSuite.Base.frmCatalogo
    {
        string ProdAut="";
        public frmCatVehiculo()
        {
            InitializeComponent();
            cdsCatalogo = spCatVehiculoDS1;
            DataSource = spCatVehiculoBindingSource;
            NombreDataSet = "spCatVehiculo";
            Buscar("~`|`~");
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ProdAut = "";
            if (chkMagna.Checked)
                ProdAut += "1";
            if (chkPremium.Checked)
                ProdAut += "2";
            if (chkDiesel.Checked)
                ProdAut += "3";
            if (chkOtros.Checked)
                ProdAut += "4";
            txtProdBinding.Text = ProdAut;
        }
    }
}
