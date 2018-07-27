using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            Buscar.frmBuscar frmBuscar = new Buscar.frmBuscar(spConsumoDS1,spConsumoBindingSource,"spCatCliente","Cliente");
            frmBuscar.ShowDialog();
        }
    }
}
