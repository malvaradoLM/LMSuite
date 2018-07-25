using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoGrupoFactura : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoGrupoFactura()
        {
            InitializeComponent();
            cdsCatalogo = spCatGrupoFacturaDS1;
            DataSource = spCatGrupoFacturaBindingSource;
            NombreDataSet = "spCatGrupoFactura";
            Buscar("~`|`~");
        }
    }
}
