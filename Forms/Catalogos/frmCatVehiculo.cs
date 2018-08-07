using RPSuite.Base;
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

        public override void onNewRecord()
        {
            txtTarjeta.Text = Data.DataModule.DataService.Folio("VehiculoID", "").ToString();
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                
                newRecordRow["VehiculoID"] = Convert.ToUInt32( txtTarjeta.Text);
                // Nota prueba 12345
            }
        }

        public override void DoGuardar(object key, object sender, EventArgs e)
        {
            try
            {
                ConcatenarChecks();
                onBeforePost();
                DataSource.EndEdit();
                if (Data.DataModule.ApplyUpdates(cdsCatalogo))
                {
                    State = stEstado.Browse;
                    newRecordRow = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void ConcatenarChecks()
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

        private void AsignarChecks()
        {
            for (int i = 0; i < txtProdBinding.Text.Length; i++)
            {
                switch (txtProdBinding.Text[i])
                {
                    case '1':
                        chkMagna.Checked = true;
                        break;
                    case '2':
                        chkPremium.Checked = true;
                        break;
                    case '3':
                        chkDiesel.Checked = true;
                        break;
                    case '4':
                        chkOtros.Checked = true;
                        break;
                }
            }
        }
    }
}
