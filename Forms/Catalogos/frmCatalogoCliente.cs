using RemObjects.DataAbstract.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RPSuite.Class;

namespace RPSuite.Forms.Catalogos
{
    public partial class frmCatalogoCliente : RPSuite.Base.frmCatalogo
    {
        DataRowView newRecordRowDireccion = null;
        DataRowView newRecordRowClienteINE = null;
        DataSet cdsDireccion { get; set; }
        DataSet cdsClienteINE { get; set; }
        System.Windows.Forms.BindingSource DataSourceDireccion { get; set; }
        System.Windows.Forms.BindingSource DataSourceClienteINE { get; set; }

        public frmCatalogoCliente()
        {
            InitializeComponent();
            cdsCatalogo = spCatClienteDS1;
            cdsDireccion = spCatDireccionDS1;
            cdsClienteINE = spCatClienteINEDS1;

            DataSource = spCatClienteBindingSource;
            DataSourceDireccion = spCatDireccionBindingSource;
            DataSourceClienteINE = spCatClienteINEBindingSource;

            NombreDataSet = "spCatCliente";
            Buscar("~`|`~");
            LlenarDireccion(0);

            lueEstado.Properties.ValueMember = lueEstado.Properties.DisplayMember = "Column";
            lueEntidadINE.Properties.ValueMember = lueEntidadINE.Properties.DisplayMember = "Column";
            lueStatus.Properties.ValueMember = lueStatus.Properties.DisplayMember = "Column";
            lueDiaPago.Properties.ValueMember = lueDiaPago.Properties.DisplayMember = "Column";
            lueDiaRevision.Properties.ValueMember = lueDiaRevision.Properties.DisplayMember = "Column";

            GlobalVar.CargarEstados();
            GlobalVar.CargarEstatus();
            GlobalVar.CargarDias();

            lueEstado.Properties.DataSource = GlobalVar.Estados;
            lueEntidadINE.Properties.DataSource = GlobalVar.Estados;
            lueStatus.Properties.DataSource = GlobalVar.Estatus;
            lueDiaPago.Properties.DataSource = GlobalVar.Dias;
            lueDiaRevision.Properties.DataSource = GlobalVar.Dias;

            getVendedor();
            getGasolinero();
            getGrupoCliente();
            getMetodoPago();
            getFacturaUso();
            getFormaPago();
            getFormaCompra();
            getGrupoFactura();
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
            Data.DataModule.FillDataSet(spCatClienteDS1, "spCatGasolinero", Params.ToArray());

            dt = spCatClienteDS1.Tables["spCatGasolinero"];
            lstGasolinero = objGasolinero.FillList(dt);
            bs.DataSource = lstGasolinero;
            lueGasolinero.Properties.DataSource = bs.List;
            lueGasolinero.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"));
            lueGasolinero.Properties.DisplayMember = "Descripcion";
            lueGasolinero.Properties.ValueMember = "GasolineroID";
            lueGasolinero.Properties.DropDownRows = lstGasolinero.Count;
        }
        #endregion

        #region Vendedor
        public void getVendedor()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            clsVendedor objVendedor = new clsVendedor();
            List<clsVendedor> lstVendedor = new List<clsVendedor>();


            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatClienteDS1, "spCatVendedor", Params.ToArray());

            dt = spCatClienteDS1.Tables["spCatVendedor"];
            lstVendedor = objVendedor.FillList(dt);
            bs.DataSource = lstVendedor;
            lueVendedor.Properties.DataSource = bs.List;
            lueVendedor.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"));
            lueVendedor.Properties.DisplayMember = "Descripcion";
            lueVendedor.Properties.ValueMember = "VendedorID";
            lueVendedor.Properties.DropDownRows = lstVendedor.Count;
        }
        #endregion

        #region GrupoCliente
        public void getGrupoCliente()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            clsGrupoCliente objGrupoCliente = new clsGrupoCliente();
            List<clsGrupoCliente> lstGrupoCliente = new List<clsGrupoCliente>();


            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatClienteDS1, "spCatGrupoCliente", Params.ToArray());

            dt = spCatClienteDS1.Tables["spCatGrupoCliente"];
            lstGrupoCliente = objGrupoCliente.FillList(dt);
            bs.DataSource = lstGrupoCliente;
            lueGrupoCliente.Properties.DataSource = bs.List;
            lueGrupoCliente.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"));
            lueGrupoCliente.Properties.DisplayMember = "Descripcion";
            lueGrupoCliente.Properties.ValueMember = "GrupoClienteID";
            lueGrupoCliente.Properties.DropDownRows = lstGrupoCliente.Count;
        }
        #endregion

        #region GrupoFactura
        public void getGrupoFactura()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            clsGrupoFactura objGrupoFactura = new clsGrupoFactura();
            List<clsGrupoFactura> lstGrupoFactura = new List<clsGrupoFactura>();


            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatClienteDS1, "spCatGrupoFactura", Params.ToArray());

            dt = spCatClienteDS1.Tables["spCatGrupoFactura"];
            lstGrupoFactura = objGrupoFactura.FillList(dt);
            bs.DataSource = lstGrupoFactura;
            lueGrupoFactura.Properties.DataSource = bs.List;
            lueGrupoFactura.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"));
            lueGrupoFactura.Properties.DisplayMember = "Descripcion";
            lueGrupoFactura.Properties.ValueMember = "GrupoFacturaID";
            lueGrupoFactura.Properties.DropDownRows = lstGrupoFactura.Count;
        }
        #endregion

        #region MetodoPago
        public void getMetodoPago()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            clsMetodoPago objMetodoPago = new clsMetodoPago();
            List<clsMetodoPago> lstMetodoPago = new List<clsMetodoPago>();


            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatDireccionDS1, "spCatMetodoPago", Params.ToArray());

            dt = spCatDireccionDS1.Tables["spCatMetodoPago"];
            lstMetodoPago = objMetodoPago.FillList(dt);
            bs.DataSource = lstMetodoPago;
            lueMetodoPago.Properties.DataSource = bs.List;
            lueMetodoPago.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"));
            lueMetodoPago.Properties.DisplayMember = "Descripcion";
            lueMetodoPago.Properties.ValueMember = "MetodoPagoID";
            lueMetodoPago.Properties.DropDownRows = lstMetodoPago.Count;
        }
        #endregion

        #region FacturaUso
        public void getFacturaUso()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            clsFacturaUso objFacturaUso = new clsFacturaUso();
            List<clsFacturaUso> lstFacturaUso = new List<clsFacturaUso>();


            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatDireccionDS1, "spCatFacturaUso", Params.ToArray());

            dt = spCatDireccionDS1.Tables["spCatFacturaUso"];
            lstFacturaUso = objFacturaUso.FillList(dt);
            bs.DataSource = lstFacturaUso;
            lueFacturaUso.Properties.DataSource = bs.List;
            lueFacturaUso.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre"));
            lueFacturaUso.Properties.DisplayMember = "Nombre";
            lueFacturaUso.Properties.ValueMember = "FacturaUsoID";
            lueFacturaUso.Properties.DropDownRows = lstFacturaUso.Count;
        }
        #endregion

        #region FormaPago
        public void getFormaPago()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            clsFormaPago objFormaPago = new clsFormaPago();
            List<clsFormaPago> lstFormaPago = new List<clsFormaPago>();


            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatDireccionDS1, "spCatFormaPago", Params.ToArray());

            dt = spCatDireccionDS1.Tables["spCatFormaPago"];
            lstFormaPago = objFormaPago.FillList(dt);
            bs.DataSource = lstFormaPago;
            lueFormaPago.Properties.DataSource = bs.List;
            lueFormaPago.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion"));
            lueFormaPago.Properties.DisplayMember = "Descripcion";
            lueFormaPago.Properties.ValueMember = "FormaPagoID";
            lueFormaPago.Properties.DropDownRows = lstFormaPago.Count;
        }
        #endregion

        #region FormaCompra
        public void getFormaCompra()
        {

            //Variables 

            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            clsFormaCompra objFormaCompra = new clsFormaCompra();
            List<clsFormaCompra> lstFormaCompra = new List<clsFormaCompra>();


            //Lenamos el DS de Categorias

            Params.Clear();

            Data.DataModule.ParamByName(Params, "Datos", "");
            Data.DataModule.FillDataSet(spCatDireccionDS1, "spCatFormaCompra", Params.ToArray());

            dt = spCatDireccionDS1.Tables["spCatFormaCompra"];
            lstFormaCompra = objFormaCompra.FillList(dt);
            bs.DataSource = lstFormaCompra;
            lueFormaCompra.Properties.DataSource = bs.List;
            lueFormaCompra.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre"));
            lueFormaCompra.Properties.DisplayMember = "Nombre";
            lueFormaCompra.Properties.ValueMember = "FormaCompraID";
            lueFormaCompra.Properties.DropDownRows = lstFormaCompra.Count;
        }
        #endregion

        public override void DoGuardar(object key, object sender, EventArgs e)
        {
            try
            {
                onBeforePost();
                DataSource.EndEdit();
                if (Data.DataModule.ApplyUpdates(cdsCatalogo))
                {
                    DataSourceDireccion.EndEdit();
                    if (Data.DataModule.ApplyUpdates(cdsDireccion))
                    {
                        DataSourceClienteINE.EndEdit();
                        if(Data.DataModule.ApplyUpdates(cdsClienteINE))
                        {
                            State = RPSuite.Base.stEstado.Browse;
                            newRecordRow = null;
                        }
                    }   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void onNewRecord()
        {
            DataSourceDireccion.AddNew();
            newRecordRowDireccion = (DataRowView)DataSourceDireccion.Current;

            DataSourceClienteINE.AddNew();           
            newRecordRowClienteINE = (DataRowView)DataSourceClienteINE.Current;
        }

        public override void onBeforePost()
        {
            if (newRecordRow != null)
            {
                newRecordRowDireccion["DireccionID"] = Data.DataModule.DataService.Folio("DireccionID", "");
                newRecordRowDireccion["ClienteID"] = txtClienteID.Text;
                newRecordRowDireccion["UsuarioID"] = Data.DataModule.Seguridad.UserID;
                

                newRecordRowClienteINE["ClienteINEID"] = Data.DataModule.DataService.Folio("ClienteINEID", "");
                newRecordRowClienteINE["ClienteID"] = txtClienteID.Text;
                
            }
        }


        private void LlenarDireccion(int ClienteID)
        {
            try
            {
                DataSet cdsDatos = spCatDireccionDS1;
                BindingSource cbsDataSource = spCatDireccionBindingSource;
                string cDataSetDatos = "spCatDireccion";
                cdsDatos.Clear();

                //Lenamos el DS de Categorias

                Params.Clear();

                RPSuite.Data.DataModule.ParamByName(Params, "ClienteID", ClienteID);
                RPSuite.Data.DataModule.ParamByName(Params, "ClienteINEID", 0);
                RPSuite.Data.DataModule.FillDataSet(cdsDatos, cDataSetDatos, Params.ToArray());
                gvDireccion.BestFitColumns(true);
                //if (gvDireccion.DataRowCount > 0)
                //{
                //    IEnumerable<DataRow> query = from dts in detallePedidoDS1.Tables["spDetallePedido"].AsEnumerable() select dts;
                //    foreach (DataRow dr in query)
                //    {
                //        CalcularTotales(dr.Field<int>("ProductoID"));
                //    }
                //    gvDetallePedido.UpdateTotalSummary();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCatalogoCliente_Load(object sender, EventArgs e)
        {

        }

        private void dgcCatalogo_Click(object sender, EventArgs e)
        {

        }

        private void gvCatalogo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int ClienteID = Int32.Parse(gvCatalogo.GetRowCellValue(gvCatalogo.FocusedRowHandle, "ClienteID").ToString());
                LlenarDireccion(ClienteID);
            }
            catch (Exception ex)
            {

            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
