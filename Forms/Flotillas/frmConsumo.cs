using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RPSuite.Class;

namespace RPSuite.Forms.Consumo
{
    public partial class frmConsumo : RPSuite.Base.frmEstructura
    {
        public frmConsumo()
        {
            InitializeComponent();
        }

        private void bedCliente_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bedCliente_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Buscar.frmBuscar frmBuscar = new Buscar.frmBuscar(spConsumoDS1,spConsumoBindingSource,"spCatCliente","Cliente");
            //frmBuscar.ShowDialog();
            if (Misc._ID != null)
                bedCliente.Text = Misc._ID.ToString();
        }

        private void bedVehiculo_Click(object sender, EventArgs e)
        {
            //Buscar.frmBuscar frmBuscar = new Buscar.frmBuscar(spConsumoDS1, spConsumoBindingSource, "spCatVehiculo", "Vehiculo");
            //frmBuscar.ShowDialog();
            if (Misc._ID != null)
                bedVehiculo.Text = Misc._ID.ToString();
        }

        private void bedProducto_Click(object sender, EventArgs e)
        {
            //Buscar.frmBuscar frmBuscar = new Buscar.frmBuscar(spConsumoDS1, spConsumoBindingSource, "spCatProducto", "Producto");
            //frmBuscar.ShowDialog();
            if (Misc._ID != null)
                bedProducto.Text = Misc._ID.ToString();
        }

        private void bedEstacion_Click(object sender, EventArgs e)
        {
            //Buscar.frmBuscar frmBuscar = new Buscar.frmBuscar(spConsumoDS1, spConsumoBindingSource, "spCatEstacion", "Estacion");
            //frmBuscar.ShowDialog();
            if (Misc._ID != null)
                bedEstacion.Text = Misc._ID.ToString();
        }
    }
}
