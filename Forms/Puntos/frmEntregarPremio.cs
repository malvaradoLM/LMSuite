using RemObjects.DataAbstract.Server;
using RPSuite.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Puntos
{
    public partial class frmEntregarPremio : RPSuite.Base.frmEstructuraBase
    {
        public frmEntregarPremio()
        {
            InitializeComponent();

            getPremios();
        }

        //Para agregar al combo los premios

        private List<DataParameter> Params = new List<DataParameter>();

        #region Premios
        public void getPremios()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();

            List<clsCatalogoPremio> Premio = new List<clsCatalogoPremio>();
            clsCatalogoPremio c = new clsCatalogoPremio();

            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatPremioDS, "spCatPremio", Params.ToArray());

            dt = spCatPremioDS.Tables["spCatPremio"];
            Premio = c.FillList(dt);
            bs.DataSource = Premio;

            this.luePremio.Properties.DataSource = bs.List;
            this.luePremio.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PuntosPremioID", "ID"));
            this.luePremio.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Premio"));
            this.luePremio.Properties.DisplayMember = "Descripcion";
            this.luePremio.Properties.ValueMember = "PuntosPremioID";

            this.luePremio.Properties.DropDownRows = Premio.Count;

        }
        #endregion

    }
}
