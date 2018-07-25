using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Catalogos.Configuracion
{
    public partial class frmCatalogoUsuario : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoUsuario()
        {
            InitializeComponent();
            cdsCatalogo = spCatUsuarioDS1;
            DataSource = spCatUsuarioBindingSource;
            NombreDataSet = "spCatUsuario";
            Buscar("~`|`~");
        }
    }
}
