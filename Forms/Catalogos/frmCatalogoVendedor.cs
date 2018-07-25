using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoVendedor : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoVendedor()
        {
            InitializeComponent();
            cdsCatalogo = spCatVendedorDS1;
            DataSource = spCatVendedorBindingSource;
            NombreDataSet = "spCatVendedor";
            Buscar("~`|`~");
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
