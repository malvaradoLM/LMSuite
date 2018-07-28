using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Puntos
{
    public partial class frmCatalogoPremios : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoPremios()
        {
            InitializeComponent();
            cdsCatalogo = spCatPremioDS;
            DataSource = spCatPremioBindingSource;
            NombreDataSet = "spCatPremio";
            Buscar("~`|`~");
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRow["PuntosPremioID"] = Data.DataModule.DataService.Folio("PremioID", "");
                // Nota prueba
            }
        }

    }
}
