﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RPSuite.Base;
using RPSuite.Class;

namespace RPSuite.Forms.Consumo
{
    public partial class frmConsumo : RPSuite.Base.frmEstructura
    {
        RPSuiteServer.TConsumo Consumo;
        public frmConsumo()
        {
            InitializeComponent();
            
        }

        public override void DoNuevo(object key, object sender, EventArgs e)
        {
            GlobalVar._BtnNuevo = false;
            UpdateActions();
            Consumo = new RPSuiteServer.TConsumo();
        }

        private void bedCliente_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bedCliente_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Buscar.frmBuscar frmBuscar = new Buscar.frmBuscar(spConsumoDS1, spConsumoBindingSource, "spCatCliente", "Cliente",this);
            frmBuscar.ShowDialog();
            // ModuleInfoCollection.MakeCurrentModule(this);
            if (Misc._ID != null)
            {
                bedCliente.Text = Misc._ID.ToString();
                Consumo.ClienteID = (Int32)Misc._ID;
            }
        }

        private void bedVehiculo_Click(object sender, EventArgs e)
        {
            Buscar.frmBuscar frmBuscar = new Buscar.frmBuscar(spConsumoDS1, spConsumoBindingSource, "spCatVehiculo", "Vehiculo", this);
            frmBuscar.ShowDialog();
            if (Misc._ID != null)
            {
                bedVehiculo.Text = Misc._ID.ToString();
                Consumo.VehiculoID = (Int32)Misc._ID;
            }
        }

        private void bedProducto_Click(object sender, EventArgs e)
        {
            Buscar.frmBuscar frmBuscar = new Buscar.frmBuscar(spConsumoDS1, spConsumoBindingSource, "spCatProducto", "Producto", this);
            frmBuscar.ShowDialog();
            if (Misc._ID != null)
            {
                Consumo.ProductoID = (Int32)Misc._ID;
                bedProducto.Text = Misc._Nombre.ToString();
            }
        }

        private void bedEstacion_Click(object sender, EventArgs e)
        {

            Buscar.frmBuscar frmBuscar = new Buscar.frmBuscar(spConsumoDS1, spConsumoBindingSource, "spCatEstacion", "Estacion", this);
            frmBuscar.ShowDialog();
            if (Misc._ID != null)
            {
                Consumo.EstacionID = (Int32)Misc._ID;
                bedEstacion.Text = Misc._Nombre.ToString();
            }
        }

        public override void DoGuardar(object key, object sender, EventArgs e)
        {
            Actions[ActionKeys.actNuevo].Enabled = true;
            UpdateActions();
            try
            {
                LlenarEstructuraConsumo();
                bool Res = Data.DataModule.DataService.GenerarConsumo(Consumo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         private void LlenarEstructuraConsumo()
        {
            
            Consumo.Tarjeta = bedCliente.Text + bedVehiculo.Text + txtGasolinero.Text + txtTipo.Text;
            Consumo.SecuenciaVenta = Convert.ToInt32(txtNumTicket.Text);
            Consumo.FechaMovimiento = dateFecha.DateTime.Date;
            Consumo.FechaCarga = dateFechaCarga.DateTime;
            Consumo.Precio = Convert.ToDouble(txtPrecio.Text);
            Consumo.Cantidad = Convert.ToDouble(txtCantidad.Text);
            Consumo.Importe = Convert.ToDouble(txtImporte.Text);
            Consumo.Turno = Convert.ToInt32(txtTurno.Text);
            Consumo.PosicionCarga = Convert.ToInt32(txtBomba.Text);
            Consumo.Kilometraje = Convert.ToInt32(txtKilometros.Text);
            Consumo.IEPS = Convert.ToDouble(txtIEPS.Text);
            Consumo.FechaCaptura = System.DateTime.Today;
        }
    }
}
