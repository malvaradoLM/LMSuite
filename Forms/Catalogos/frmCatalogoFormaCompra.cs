using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoFormaCompra : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoFormaCompra()
        {
            InitializeComponent();
            cdsCatalogo = spCatFormaCompraDS1;
            DataSource = spCatFormaCompraBindingSource;
            NombreDataSet = "spCatFormaCompra";
            Buscar("~`|`~");
        }
    }
}
