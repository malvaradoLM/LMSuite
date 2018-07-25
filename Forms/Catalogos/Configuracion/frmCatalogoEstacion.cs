using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RPSuite.Class;
using RemObjects.DataAbstract.Server;

namespace RPSuite.Forms.Catalogos.Configuracion
{
    public partial class frmCatalogoEstacion : RPSuite.Base.frmCatalogo
    {
        public frmCatalogoEstacion()
        {
            InitializeComponent();
            cdsCatalogo = spCatEstacionDS1;
            DataSource = spCatEstacionBindingSource;
            NombreDataSet = "spCatEstacion";

            getGasolinero();
            getGrupoTiempoAire();
            getRegimenFiscal();
            GlobalVar.CargarEstados();

            lueEstadoDomFiscal.Properties.ValueMember = lueEstadoDomFiscal.Properties.DisplayMember = "Column";           
            lueEstadoDomFiscal.Properties.DataSource = GlobalVar.Estados;

            lueEstadoExpedido.Properties.ValueMember = lueEstadoExpedido.Properties.DisplayMember = "Column";
            lueEstadoExpedido.Properties.DataSource = GlobalVar.Estados;

            Buscar("~`|`~");

        }

        private List<DataParameter> Params = new List<DataParameter>();

        #region Gasolinero
        public void getGasolinero()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            clsGasolinero objGasolinero = new clsGasolinero();
            List<clsGasolinero> lstGasolinero = new List<clsGasolinero>();


            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS1, "spCatGasolinero", Params.ToArray());

            dt = spCatEstacionDS1.Tables["spCatGasolinero"];
            lstGasolinero = objGasolinero.FillList(dt);
            bs.DataSource = lstGasolinero;
            lueGasolinero.Properties.DataSource = bs.List;
            lueGasolinero.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"));
            lueGasolinero.Properties.DisplayMember = "Descripcion";
            lueGasolinero.Properties.ValueMember = "GasolineroID";
            lueGasolinero.Properties.DropDownRows = lstGasolinero.Count;
        }
        #endregion

        #region RegimenFiscal
        public void getRegimenFiscal()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            clsRegimenFiscal objRegimenFiscal = new clsRegimenFiscal();
            List<clsRegimenFiscal> lstRegimenFiscal = new List<clsRegimenFiscal>();


            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS1, "spCatRegimenFiscal", Params.ToArray());

            dt = spCatEstacionDS1.Tables["spCatRegimenFiscal"];
            lstRegimenFiscal = objRegimenFiscal.FillList(dt);
            bs.DataSource = lstRegimenFiscal;
            lueRegimenFiscal.Properties.DataSource = bs.List;
            lueRegimenFiscal.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"));
            lueRegimenFiscal.Properties.DisplayMember = "Descripcion";
            lueRegimenFiscal.Properties.ValueMember = "RegimenFiscalID";
            lueRegimenFiscal.Properties.DropDownRows = lstRegimenFiscal.Count;
        }
        #endregion

        #region GrupoTiempoAire
        public void getGrupoTiempoAire()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            clsGrupoTiempoAire objGrupoTiempoAire = new clsGrupoTiempoAire();
            List<clsGrupoTiempoAire> lstGrupoTiempoAire = new List<clsGrupoTiempoAire>();


            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatEstacionDS1, "spCatGrupoTiempoAire", Params.ToArray());

            dt = spCatEstacionDS1.Tables["spCatGrupoTiempoAire"];
            lstGrupoTiempoAire = objGrupoTiempoAire.FillList(dt);
            bs.DataSource = lstGrupoTiempoAire;
            lueGpoTiempoAire.Properties.DataSource = bs.List;
            lueGpoTiempoAire.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre"));
            lueGpoTiempoAire.Properties.DisplayMember = "Nombre";
            lueGpoTiempoAire.Properties.ValueMember = "TiempoAireGrupoID";
            lueGpoTiempoAire.Properties.DropDownRows = lstGrupoTiempoAire.Count;
        }
        #endregion

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void textEdit12_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit11_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit10_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit9_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

        private void textEdit13_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCPDomFiscal_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl28_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
