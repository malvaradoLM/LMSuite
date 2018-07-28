namespace RPSuite.Forms.Catalogos
{
    partial class frmCatalogoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogoCliente));
            this.spCatClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatClienteDS1 = new RPSuite.Datasets.Catalogos.spCatClienteDS();
            this.colClienteID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlazoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaBaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLimiteCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeposito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCambioCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCambioCreditoAnterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUltimoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarjetaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClasificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAfectaHistorico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaRevisionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaPagoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutorizaCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTicketBoucher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutorizaValeCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturayLiquidacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendedorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupoFacturarID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupoClienteID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGasolineroID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbAgregarClientes = new DevExpress.XtraTab.XtraTabControl();
            this.tbDatosGenerales = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lueFormaCompra = new DevExpress.XtraEditors.LookUpEdit();
            this.spCatDireccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatDireccionDS1 = new RPSuite.Datasets.Catalogos.spCatDireccionDS();
            this.lueFormaPago = new DevExpress.XtraEditors.LookUpEdit();
            this.lueFacturaUso = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl43 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl42 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl40 = new DevExpress.XtraEditors.LabelControl();
            this.lueMetodoPago = new DevExpress.XtraEditors.LookUpEdit();
            this.lueEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtMunicipio = new DevExpress.XtraEditors.TextEdit();
            this.txtCiudad = new DevExpress.XtraEditors.TextEdit();
            this.txtColonia = new DevExpress.XtraEditors.TextEdit();
            this.txtCP = new DevExpress.XtraEditors.TextEdit();
            this.txtNoInterior = new DevExpress.XtraEditors.TextEdit();
            this.txtNoExterior = new DevExpress.XtraEditors.TextEdit();
            this.txtCalle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl38 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gvDireccion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDireccionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomicilio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoExterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoInterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturaExpress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoEnPuntos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoPaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClienteID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMetodoPagoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClienteINEID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuntosCategoriaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacturaUsoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaPagoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaCompraID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtRazonSocial = new DevExpress.XtraEditors.TextEdit();
            this.lueGasolinero = new DevExpress.XtraEditors.LookUpEdit();
            this.lueVendedor = new DevExpress.XtraEditors.LookUpEdit();
            this.lueGrupoCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.lueStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRFC = new DevExpress.XtraEditors.TextEdit();
            this.chkClienteActivo = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtClienteID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tpCredito = new DevExpress.XtraTab.XtraTabPage();
            this.lueDiaPago = new DevExpress.XtraEditors.LookUpEdit();
            this.lueDiaRevision = new DevExpress.XtraEditors.LookUpEdit();
            this.chkAutorizaValeCredito = new DevExpress.XtraEditors.CheckEdit();
            this.chkAutorizaCheque = new DevExpress.XtraEditors.CheckEdit();
            this.chkAfectaHistorico = new DevExpress.XtraEditors.CheckEdit();
            this.txtFacturaLiquidacion = new DevExpress.XtraEditors.TextEdit();
            this.txtTicketBoucher = new DevExpress.XtraEditors.TextEdit();
            this.lueGrupoFactura = new DevExpress.XtraEditors.LookUpEdit();
            this.txtClasificacion = new DevExpress.XtraEditors.TextEdit();
            this.txtTarjeta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dateEdit3 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateFechaIngreso = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dateFechaBaja = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtLimiteCredito = new DevExpress.XtraEditors.TextEdit();
            this.txtDeposito = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNIP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tpDatosINE = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spCatClienteINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCatClienteINEDS1 = new RPSuite.Datasets.Catalogos.spCatClienteINEDS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClienteINEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINETipoProceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoComite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINEIDContabilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINEClaveEntidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINEEntidadAmbito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINEEntidadContabilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClienteID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit17 = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit4 = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit16 = new DevExpress.XtraEditors.TextEdit();
            this.lueEntidadINE = new DevExpress.XtraEditors.LookUpEdit();
            this.lueTipoComite = new DevExpress.XtraEditors.LookUpEdit();
            this.lueTipoProceso = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.chkDatosINE = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tcCatalogo)).BeginInit();
            this.tcCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).BeginInit();
            this.gcBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).BeginInit();
            this.tpBuscar.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatClienteDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAgregarClientes)).BeginInit();
            this.tbAgregarClientes.SuspendLayout();
            this.tbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueFormaCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatDireccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatDireccionDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFormaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFacturaUso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMetodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoInterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoExterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGasolinero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupoCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkClienteActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteID.Properties)).BeginInit();
            this.tpCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDiaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDiaRevision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutorizaValeCredito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutorizaCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAfectaHistorico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacturaLiquidacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTicketBoucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupoFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClasificacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarjeta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaIngreso.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaBaja.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaBaja.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteCredito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNIP.Properties)).BeginInit();
            this.tpDatosINE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatClienteINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatClienteINEDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit17.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit16.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEntidadINE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipoComite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipoProceso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDatosINE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.Size = new System.Drawing.Size(808, 419);
            // 
            // gcBusqueda
            // 
            this.gcBusqueda.Size = new System.Drawing.Size(806, 100);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.ImageIndex = 0;
            // 
            // txtDatosBusqueda
            // 
            // 
            // tpBuscar
            // 
            this.tpBuscar.Size = new System.Drawing.Size(806, 394);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.tbAgregarClientes);
            this.tpDatos.Size = new System.Drawing.Size(806, 394);
            // 
            // dgcCatalogo
            // 
            this.dgcCatalogo.DataSource = this.spCatClienteBindingSource;
            this.dgcCatalogo.Size = new System.Drawing.Size(806, 294);
            this.dgcCatalogo.Click += new System.EventHandler(this.dgcCatalogo_Click);
            // 
            // gvCatalogo
            // 
            this.gvCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClienteID,
            this.colNombre,
            this.colRazonSocial,
            this.colRFC,
            this.colPlazoPago,
            this.colEstatus,
            this.colFechaIngreso,
            this.colNIP,
            this.colFechaBaja,
            this.colLimiteCredito,
            this.colDeposito,
            this.colCambioCredito,
            this.colCambioCreditoAnterior,
            this.colUltimoPago,
            this.colTarjetaID,
            this.colClasificacion,
            this.colAfectaHistorico,
            this.colDiaRevisionID,
            this.colDiaPagoID,
            this.colAutorizaCheque,
            this.colTicketBoucher,
            this.colAutorizaValeCredito,
            this.colFacturayLiquidacion,
            this.colVendedorID,
            this.colGrupoFacturarID,
            this.colGrupoClienteID,
            this.colGasolineroID});
            this.gvCatalogo.OptionsBehavior.Editable = false;
            this.gvCatalogo.OptionsFind.AlwaysVisible = true;
            this.gvCatalogo.OptionsFind.SearchInPreview = true;
            this.gvCatalogo.OptionsFind.ShowClearButton = false;
            this.gvCatalogo.OptionsFind.ShowCloseButton = false;
            this.gvCatalogo.OptionsFind.ShowFindButton = false;
            this.gvCatalogo.OptionsSelection.MultiSelect = true;
            this.gvCatalogo.OptionsView.ColumnAutoWidth = false;
            this.gvCatalogo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCatalogo_FocusedRowChanged);
            // 
            // spCatClienteBindingSource
            // 
            this.spCatClienteBindingSource.DataMember = "spCatCliente";
            this.spCatClienteBindingSource.DataSource = this.spCatClienteDS1;
            this.spCatClienteBindingSource.Sort = "";
            // 
            // spCatClienteDS1
            // 
            this.spCatClienteDS1.DataSetName = "spCatClienteDS";
            this.spCatClienteDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colClienteID
            // 
            this.colClienteID.FieldName = "ClienteID";
            this.colClienteID.Name = "colClienteID";
            this.colClienteID.Visible = true;
            this.colClienteID.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 2;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 3;
            // 
            // colPlazoPago
            // 
            this.colPlazoPago.FieldName = "PlazoPago";
            this.colPlazoPago.Name = "colPlazoPago";
            this.colPlazoPago.Visible = true;
            this.colPlazoPago.VisibleIndex = 4;
            // 
            // colEstatus
            // 
            this.colEstatus.FieldName = "Estatus";
            this.colEstatus.Name = "colEstatus";
            this.colEstatus.Visible = true;
            this.colEstatus.VisibleIndex = 5;
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.FieldName = "FechaIngreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.Visible = true;
            this.colFechaIngreso.VisibleIndex = 6;
            // 
            // colNIP
            // 
            this.colNIP.FieldName = "NIP";
            this.colNIP.Name = "colNIP";
            this.colNIP.Visible = true;
            this.colNIP.VisibleIndex = 7;
            // 
            // colFechaBaja
            // 
            this.colFechaBaja.FieldName = "FechaBaja";
            this.colFechaBaja.Name = "colFechaBaja";
            this.colFechaBaja.Visible = true;
            this.colFechaBaja.VisibleIndex = 8;
            // 
            // colLimiteCredito
            // 
            this.colLimiteCredito.FieldName = "LimiteCredito";
            this.colLimiteCredito.Name = "colLimiteCredito";
            this.colLimiteCredito.Visible = true;
            this.colLimiteCredito.VisibleIndex = 9;
            // 
            // colDeposito
            // 
            this.colDeposito.FieldName = "Deposito";
            this.colDeposito.Name = "colDeposito";
            this.colDeposito.Visible = true;
            this.colDeposito.VisibleIndex = 10;
            // 
            // colCambioCredito
            // 
            this.colCambioCredito.FieldName = "CambioCredito";
            this.colCambioCredito.Name = "colCambioCredito";
            this.colCambioCredito.Visible = true;
            this.colCambioCredito.VisibleIndex = 11;
            // 
            // colCambioCreditoAnterior
            // 
            this.colCambioCreditoAnterior.FieldName = "CambioCreditoAnterior";
            this.colCambioCreditoAnterior.Name = "colCambioCreditoAnterior";
            this.colCambioCreditoAnterior.Visible = true;
            this.colCambioCreditoAnterior.VisibleIndex = 12;
            // 
            // colUltimoPago
            // 
            this.colUltimoPago.FieldName = "UltimoPago";
            this.colUltimoPago.Name = "colUltimoPago";
            this.colUltimoPago.Visible = true;
            this.colUltimoPago.VisibleIndex = 13;
            // 
            // colTarjetaID
            // 
            this.colTarjetaID.FieldName = "TarjetaID";
            this.colTarjetaID.Name = "colTarjetaID";
            this.colTarjetaID.Visible = true;
            this.colTarjetaID.VisibleIndex = 14;
            // 
            // colClasificacion
            // 
            this.colClasificacion.FieldName = "Clasificacion";
            this.colClasificacion.Name = "colClasificacion";
            this.colClasificacion.Visible = true;
            this.colClasificacion.VisibleIndex = 15;
            // 
            // colAfectaHistorico
            // 
            this.colAfectaHistorico.FieldName = "AfectaHistorico";
            this.colAfectaHistorico.Name = "colAfectaHistorico";
            this.colAfectaHistorico.Visible = true;
            this.colAfectaHistorico.VisibleIndex = 16;
            // 
            // colDiaRevisionID
            // 
            this.colDiaRevisionID.FieldName = "DiaRevisionID";
            this.colDiaRevisionID.Name = "colDiaRevisionID";
            this.colDiaRevisionID.Visible = true;
            this.colDiaRevisionID.VisibleIndex = 17;
            // 
            // colDiaPagoID
            // 
            this.colDiaPagoID.FieldName = "DiaPagoID";
            this.colDiaPagoID.Name = "colDiaPagoID";
            this.colDiaPagoID.Visible = true;
            this.colDiaPagoID.VisibleIndex = 18;
            // 
            // colAutorizaCheque
            // 
            this.colAutorizaCheque.FieldName = "AutorizaCheque";
            this.colAutorizaCheque.Name = "colAutorizaCheque";
            this.colAutorizaCheque.Visible = true;
            this.colAutorizaCheque.VisibleIndex = 19;
            // 
            // colTicketBoucher
            // 
            this.colTicketBoucher.FieldName = "TicketBoucher";
            this.colTicketBoucher.Name = "colTicketBoucher";
            this.colTicketBoucher.Visible = true;
            this.colTicketBoucher.VisibleIndex = 20;
            // 
            // colAutorizaValeCredito
            // 
            this.colAutorizaValeCredito.FieldName = "AutorizaValeCredito";
            this.colAutorizaValeCredito.Name = "colAutorizaValeCredito";
            this.colAutorizaValeCredito.Visible = true;
            this.colAutorizaValeCredito.VisibleIndex = 21;
            // 
            // colFacturayLiquidacion
            // 
            this.colFacturayLiquidacion.FieldName = "FacturayLiquidacion";
            this.colFacturayLiquidacion.Name = "colFacturayLiquidacion";
            this.colFacturayLiquidacion.Visible = true;
            this.colFacturayLiquidacion.VisibleIndex = 22;
            // 
            // colVendedorID
            // 
            this.colVendedorID.FieldName = "VendedorID";
            this.colVendedorID.Name = "colVendedorID";
            this.colVendedorID.Visible = true;
            this.colVendedorID.VisibleIndex = 23;
            // 
            // colGrupoFacturarID
            // 
            this.colGrupoFacturarID.FieldName = "GrupoFacturarID";
            this.colGrupoFacturarID.Name = "colGrupoFacturarID";
            this.colGrupoFacturarID.Visible = true;
            this.colGrupoFacturarID.VisibleIndex = 24;
            // 
            // colGrupoClienteID
            // 
            this.colGrupoClienteID.FieldName = "GrupoClienteID";
            this.colGrupoClienteID.Name = "colGrupoClienteID";
            this.colGrupoClienteID.Visible = true;
            this.colGrupoClienteID.VisibleIndex = 25;
            // 
            // colGasolineroID
            // 
            this.colGasolineroID.FieldName = "GasolineroID";
            this.colGasolineroID.Name = "colGasolineroID";
            this.colGasolineroID.Visible = true;
            this.colGasolineroID.VisibleIndex = 26;
            // 
            // tbAgregarClientes
            // 
            this.tbAgregarClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAgregarClientes.Location = new System.Drawing.Point(0, 0);
            this.tbAgregarClientes.Name = "tbAgregarClientes";
            this.tbAgregarClientes.SelectedTabPage = this.tbDatosGenerales;
            this.tbAgregarClientes.Size = new System.Drawing.Size(806, 394);
            this.tbAgregarClientes.TabIndex = 1;
            this.tbAgregarClientes.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tbDatosGenerales,
            this.tpCredito,
            this.tpDatosINE});
            // 
            // tbDatosGenerales
            // 
            this.tbDatosGenerales.Controls.Add(this.groupControl3);
            this.tbDatosGenerales.Controls.Add(this.txtRazonSocial);
            this.tbDatosGenerales.Controls.Add(this.lueGasolinero);
            this.tbDatosGenerales.Controls.Add(this.lueVendedor);
            this.tbDatosGenerales.Controls.Add(this.lueGrupoCliente);
            this.tbDatosGenerales.Controls.Add(this.lueStatus);
            this.tbDatosGenerales.Controls.Add(this.labelControl33);
            this.tbDatosGenerales.Controls.Add(this.labelControl32);
            this.tbDatosGenerales.Controls.Add(this.labelControl30);
            this.tbDatosGenerales.Controls.Add(this.labelControl5);
            this.tbDatosGenerales.Controls.Add(this.labelControl3);
            this.tbDatosGenerales.Controls.Add(this.txtRFC);
            this.tbDatosGenerales.Controls.Add(this.chkClienteActivo);
            this.tbDatosGenerales.Controls.Add(this.labelControl12);
            this.tbDatosGenerales.Controls.Add(this.txtNombre);
            this.tbDatosGenerales.Controls.Add(this.txtClienteID);
            this.tbDatosGenerales.Controls.Add(this.labelControl2);
            this.tbDatosGenerales.Controls.Add(this.labelControl1);
            this.tbDatosGenerales.Name = "tbDatosGenerales";
            this.tbDatosGenerales.Size = new System.Drawing.Size(804, 369);
            this.tbDatosGenerales.Text = "Agregar Cliente";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lueFormaCompra);
            this.groupControl3.Controls.Add(this.lueFormaPago);
            this.groupControl3.Controls.Add(this.lueFacturaUso);
            this.groupControl3.Controls.Add(this.labelControl43);
            this.groupControl3.Controls.Add(this.labelControl42);
            this.groupControl3.Controls.Add(this.labelControl41);
            this.groupControl3.Controls.Add(this.labelControl40);
            this.groupControl3.Controls.Add(this.lueMetodoPago);
            this.groupControl3.Controls.Add(this.lueEstado);
            this.groupControl3.Controls.Add(this.txtTelefono);
            this.groupControl3.Controls.Add(this.txtMunicipio);
            this.groupControl3.Controls.Add(this.txtCiudad);
            this.groupControl3.Controls.Add(this.txtColonia);
            this.groupControl3.Controls.Add(this.txtCP);
            this.groupControl3.Controls.Add(this.txtNoInterior);
            this.groupControl3.Controls.Add(this.txtNoExterior);
            this.groupControl3.Controls.Add(this.txtCalle);
            this.groupControl3.Controls.Add(this.labelControl39);
            this.groupControl3.Controls.Add(this.labelControl38);
            this.groupControl3.Controls.Add(this.labelControl37);
            this.groupControl3.Controls.Add(this.labelControl36);
            this.groupControl3.Controls.Add(this.labelControl35);
            this.groupControl3.Controls.Add(this.labelControl34);
            this.groupControl3.Controls.Add(this.labelControl28);
            this.groupControl3.Controls.Add(this.labelControl26);
            this.groupControl3.Controls.Add(this.labelControl23);
            this.groupControl3.Controls.Add(this.gridControl2);
            this.groupControl3.Location = new System.Drawing.Point(21, 165);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(781, 201);
            this.groupControl3.TabIndex = 79;
            this.groupControl3.Text = "Direcciones";
            // 
            // lueFormaCompra
            // 
            this.lueFormaCompra.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "FormaCompraID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueFormaCompra.Location = new System.Drawing.Point(478, 163);
            this.lueFormaCompra.Name = "lueFormaCompra";
            this.lueFormaCompra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueFormaCompra.Size = new System.Drawing.Size(112, 20);
            this.lueFormaCompra.TabIndex = 26;
            // 
            // spCatDireccionBindingSource
            // 
            this.spCatDireccionBindingSource.DataMember = "spCatDireccion";
            this.spCatDireccionBindingSource.DataSource = this.spCatDireccionDS1;
            this.spCatDireccionBindingSource.Sort = "";
            // 
            // spCatDireccionDS1
            // 
            this.spCatDireccionDS1.DataSetName = "spCatDireccionDS";
            this.spCatDireccionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lueFormaPago
            // 
            this.lueFormaPago.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "FormaPagoID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueFormaPago.Location = new System.Drawing.Point(276, 163);
            this.lueFormaPago.Name = "lueFormaPago";
            this.lueFormaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueFormaPago.Size = new System.Drawing.Size(115, 20);
            this.lueFormaPago.TabIndex = 25;
            // 
            // lueFacturaUso
            // 
            this.lueFacturaUso.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "FacturaUsoID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueFacturaUso.Location = new System.Drawing.Point(661, 132);
            this.lueFacturaUso.Name = "lueFacturaUso";
            this.lueFacturaUso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueFacturaUso.Size = new System.Drawing.Size(112, 20);
            this.lueFacturaUso.TabIndex = 24;
            // 
            // labelControl43
            // 
            this.labelControl43.Location = new System.Drawing.Point(403, 166);
            this.labelControl43.Name = "labelControl43";
            this.labelControl43.Size = new System.Drawing.Size(70, 13);
            this.labelControl43.TabIndex = 23;
            this.labelControl43.Text = "Forma Compra";
            // 
            // labelControl42
            // 
            this.labelControl42.Location = new System.Drawing.Point(212, 166);
            this.labelControl42.Name = "labelControl42";
            this.labelControl42.Size = new System.Drawing.Size(57, 13);
            this.labelControl42.TabIndex = 22;
            this.labelControl42.Text = "Forma Pago";
            // 
            // labelControl41
            // 
            this.labelControl41.Location = new System.Drawing.Point(596, 135);
            this.labelControl41.Name = "labelControl41";
            this.labelControl41.Size = new System.Drawing.Size(58, 13);
            this.labelControl41.TabIndex = 21;
            this.labelControl41.Text = "Factura Uso";
            // 
            // labelControl40
            // 
            this.labelControl40.Location = new System.Drawing.Point(403, 135);
            this.labelControl40.Name = "labelControl40";
            this.labelControl40.Size = new System.Drawing.Size(63, 13);
            this.labelControl40.TabIndex = 20;
            this.labelControl40.Text = "Metodo Pago";
            // 
            // lueMetodoPago
            // 
            this.lueMetodoPago.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "MetodoPagoID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueMetodoPago.Location = new System.Drawing.Point(478, 132);
            this.lueMetodoPago.Name = "lueMetodoPago";
            this.lueMetodoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMetodoPago.Size = new System.Drawing.Size(112, 20);
            this.lueMetodoPago.TabIndex = 19;
            // 
            // lueEstado
            // 
            this.lueEstado.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "Estado", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueEstado.Location = new System.Drawing.Point(661, 99);
            this.lueEstado.Name = "lueEstado";
            this.lueEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEstado.Size = new System.Drawing.Size(112, 20);
            this.lueEstado.TabIndex = 18;
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "Telefono", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTelefono.Location = new System.Drawing.Point(276, 132);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(115, 20);
            this.txtTelefono.TabIndex = 17;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "Municipio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMunicipio.Location = new System.Drawing.Point(478, 99);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(112, 20);
            this.txtMunicipio.TabIndex = 16;
            // 
            // txtCiudad
            // 
            this.txtCiudad.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "Ciudad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCiudad.Location = new System.Drawing.Point(276, 99);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(115, 20);
            this.txtCiudad.TabIndex = 15;
            // 
            // txtColonia
            // 
            this.txtColonia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "Colonia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtColonia.Location = new System.Drawing.Point(661, 35);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(112, 20);
            this.txtColonia.TabIndex = 14;
            // 
            // txtCP
            // 
            this.txtCP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "CP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCP.Location = new System.Drawing.Point(661, 67);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(112, 20);
            this.txtCP.TabIndex = 13;
            // 
            // txtNoInterior
            // 
            this.txtNoInterior.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "NoInterior", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNoInterior.Location = new System.Drawing.Point(478, 67);
            this.txtNoInterior.Name = "txtNoInterior";
            this.txtNoInterior.Size = new System.Drawing.Size(112, 20);
            this.txtNoInterior.TabIndex = 12;
            // 
            // txtNoExterior
            // 
            this.txtNoExterior.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "NoExterior", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNoExterior.Location = new System.Drawing.Point(276, 67);
            this.txtNoExterior.Name = "txtNoExterior";
            this.txtNoExterior.Size = new System.Drawing.Size(115, 20);
            this.txtNoExterior.TabIndex = 11;
            // 
            // txtCalle
            // 
            this.txtCalle.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatDireccionBindingSource, "Domicilio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCalle.Location = new System.Drawing.Point(276, 35);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(323, 20);
            this.txtCalle.TabIndex = 10;
            // 
            // labelControl39
            // 
            this.labelControl39.Location = new System.Drawing.Point(212, 135);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(42, 13);
            this.labelControl39.TabIndex = 9;
            this.labelControl39.Text = "Telefono";
            // 
            // labelControl38
            // 
            this.labelControl38.Location = new System.Drawing.Point(596, 102);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(33, 13);
            this.labelControl38.TabIndex = 8;
            this.labelControl38.Text = "Estado";
            // 
            // labelControl37
            // 
            this.labelControl37.Location = new System.Drawing.Point(403, 102);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(43, 13);
            this.labelControl37.TabIndex = 7;
            this.labelControl37.Text = "Municipio";
            // 
            // labelControl36
            // 
            this.labelControl36.Location = new System.Drawing.Point(212, 102);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Size = new System.Drawing.Size(33, 13);
            this.labelControl36.TabIndex = 6;
            this.labelControl36.Text = "Ciudad";
            // 
            // labelControl35
            // 
            this.labelControl35.Location = new System.Drawing.Point(605, 38);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(35, 13);
            this.labelControl35.TabIndex = 5;
            this.labelControl35.Text = "Colonia";
            // 
            // labelControl34
            // 
            this.labelControl34.Location = new System.Drawing.Point(596, 70);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(21, 13);
            this.labelControl34.TabIndex = 4;
            this.labelControl34.Text = "C.P.";
            // 
            // labelControl28
            // 
            this.labelControl28.Location = new System.Drawing.Point(403, 70);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(56, 13);
            this.labelControl28.TabIndex = 3;
            this.labelControl28.Text = "No. Interior";
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(212, 70);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(58, 13);
            this.labelControl26.TabIndex = 2;
            this.labelControl26.Text = "No. Exterior";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(212, 38);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(23, 13);
            this.labelControl23.TabIndex = 1;
            this.labelControl23.Text = "Calle";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.spCatDireccionBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(5, 24);
            this.gridControl2.MainView = this.gvDireccion;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(201, 172);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDireccion});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gvDireccion
            // 
            this.gvDireccion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDireccionID,
            this.colDomicilio,
            this.colNoExterior,
            this.colNoInterior,
            this.colColonia,
            this.colCP,
            this.colCiudad,
            this.colMunicipio,
            this.colEstado,
            this.colTelefono,
            this.colFacturaExpress,
            this.colSaldoEnPuntos,
            this.colApellidoPaterno,
            this.colApellidoMaterno,
            this.colNombres,
            this.colNacimiento,
            this.colSexo,
            this.colClienteID2,
            this.colMetodoPagoID,
            this.colClienteINEID1,
            this.colPuntosCategoriaID,
            this.colFacturaUsoID,
            this.colFormaPagoID,
            this.colUsuarioID,
            this.colFormaCompraID});
            this.gvDireccion.GridControl = this.gridControl2;
            this.gvDireccion.Name = "gvDireccion";
            // 
            // colDireccionID
            // 
            this.colDireccionID.FieldName = "DireccionID";
            this.colDireccionID.Name = "colDireccionID";
            this.colDireccionID.Visible = true;
            this.colDireccionID.VisibleIndex = 0;
            // 
            // colDomicilio
            // 
            this.colDomicilio.FieldName = "Domicilio";
            this.colDomicilio.Name = "colDomicilio";
            this.colDomicilio.Visible = true;
            this.colDomicilio.VisibleIndex = 1;
            // 
            // colNoExterior
            // 
            this.colNoExterior.FieldName = "NoExterior";
            this.colNoExterior.Name = "colNoExterior";
            this.colNoExterior.Visible = true;
            this.colNoExterior.VisibleIndex = 2;
            // 
            // colNoInterior
            // 
            this.colNoInterior.FieldName = "NoInterior";
            this.colNoInterior.Name = "colNoInterior";
            this.colNoInterior.Visible = true;
            this.colNoInterior.VisibleIndex = 3;
            // 
            // colColonia
            // 
            this.colColonia.FieldName = "Colonia";
            this.colColonia.Name = "colColonia";
            this.colColonia.Visible = true;
            this.colColonia.VisibleIndex = 4;
            // 
            // colCP
            // 
            this.colCP.FieldName = "CP";
            this.colCP.Name = "colCP";
            this.colCP.Visible = true;
            this.colCP.VisibleIndex = 5;
            // 
            // colCiudad
            // 
            this.colCiudad.FieldName = "Ciudad";
            this.colCiudad.Name = "colCiudad";
            this.colCiudad.Visible = true;
            this.colCiudad.VisibleIndex = 6;
            // 
            // colMunicipio
            // 
            this.colMunicipio.FieldName = "Municipio";
            this.colMunicipio.Name = "colMunicipio";
            this.colMunicipio.Visible = true;
            this.colMunicipio.VisibleIndex = 7;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 9;
            // 
            // colFacturaExpress
            // 
            this.colFacturaExpress.FieldName = "FacturaExpress";
            this.colFacturaExpress.Name = "colFacturaExpress";
            this.colFacturaExpress.Visible = true;
            this.colFacturaExpress.VisibleIndex = 10;
            // 
            // colSaldoEnPuntos
            // 
            this.colSaldoEnPuntos.FieldName = "SaldoEnPuntos";
            this.colSaldoEnPuntos.Name = "colSaldoEnPuntos";
            this.colSaldoEnPuntos.Visible = true;
            this.colSaldoEnPuntos.VisibleIndex = 11;
            // 
            // colApellidoPaterno
            // 
            this.colApellidoPaterno.FieldName = "ApellidoPaterno";
            this.colApellidoPaterno.Name = "colApellidoPaterno";
            this.colApellidoPaterno.Visible = true;
            this.colApellidoPaterno.VisibleIndex = 12;
            // 
            // colApellidoMaterno
            // 
            this.colApellidoMaterno.FieldName = "ApellidoMaterno";
            this.colApellidoMaterno.Name = "colApellidoMaterno";
            this.colApellidoMaterno.Visible = true;
            this.colApellidoMaterno.VisibleIndex = 13;
            // 
            // colNombres
            // 
            this.colNombres.FieldName = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.Visible = true;
            this.colNombres.VisibleIndex = 14;
            // 
            // colNacimiento
            // 
            this.colNacimiento.FieldName = "Nacimiento";
            this.colNacimiento.Name = "colNacimiento";
            this.colNacimiento.Visible = true;
            this.colNacimiento.VisibleIndex = 15;
            // 
            // colSexo
            // 
            this.colSexo.FieldName = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.Visible = true;
            this.colSexo.VisibleIndex = 16;
            // 
            // colClienteID2
            // 
            this.colClienteID2.FieldName = "ClienteID";
            this.colClienteID2.Name = "colClienteID2";
            this.colClienteID2.Visible = true;
            this.colClienteID2.VisibleIndex = 17;
            // 
            // colMetodoPagoID
            // 
            this.colMetodoPagoID.FieldName = "MetodoPagoID";
            this.colMetodoPagoID.Name = "colMetodoPagoID";
            this.colMetodoPagoID.Visible = true;
            this.colMetodoPagoID.VisibleIndex = 18;
            // 
            // colClienteINEID1
            // 
            this.colClienteINEID1.FieldName = "ClienteINEID";
            this.colClienteINEID1.Name = "colClienteINEID1";
            this.colClienteINEID1.Visible = true;
            this.colClienteINEID1.VisibleIndex = 19;
            // 
            // colPuntosCategoriaID
            // 
            this.colPuntosCategoriaID.FieldName = "PuntosCategoriaID";
            this.colPuntosCategoriaID.Name = "colPuntosCategoriaID";
            this.colPuntosCategoriaID.Visible = true;
            this.colPuntosCategoriaID.VisibleIndex = 20;
            // 
            // colFacturaUsoID
            // 
            this.colFacturaUsoID.FieldName = "FacturaUsoID";
            this.colFacturaUsoID.Name = "colFacturaUsoID";
            this.colFacturaUsoID.Visible = true;
            this.colFacturaUsoID.VisibleIndex = 21;
            // 
            // colFormaPagoID
            // 
            this.colFormaPagoID.FieldName = "FormaPagoID";
            this.colFormaPagoID.Name = "colFormaPagoID";
            this.colFormaPagoID.Visible = true;
            this.colFormaPagoID.VisibleIndex = 22;
            // 
            // colUsuarioID
            // 
            this.colUsuarioID.FieldName = "UsuarioID";
            this.colUsuarioID.Name = "colUsuarioID";
            this.colUsuarioID.Visible = true;
            this.colUsuarioID.VisibleIndex = 23;
            // 
            // colFormaCompraID
            // 
            this.colFormaCompraID.FieldName = "FormaCompraID";
            this.colFormaCompraID.Name = "colFormaCompraID";
            this.colFormaCompraID.Visible = true;
            this.colFormaCompraID.VisibleIndex = 24;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "RazonSocial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRazonSocial.Location = new System.Drawing.Point(128, 46);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(325, 20);
            this.txtRazonSocial.TabIndex = 78;
            // 
            // lueGasolinero
            // 
            this.lueGasolinero.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "GasolineroID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueGasolinero.Location = new System.Drawing.Point(574, 72);
            this.lueGasolinero.Name = "lueGasolinero";
            this.lueGasolinero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGasolinero.Size = new System.Drawing.Size(100, 20);
            this.lueGasolinero.TabIndex = 70;
            // 
            // lueVendedor
            // 
            this.lueVendedor.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "VendedorID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueVendedor.Location = new System.Drawing.Point(574, 46);
            this.lueVendedor.Name = "lueVendedor";
            this.lueVendedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueVendedor.Size = new System.Drawing.Size(100, 20);
            this.lueVendedor.TabIndex = 69;
            // 
            // lueGrupoCliente
            // 
            this.lueGrupoCliente.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "GrupoClienteID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueGrupoCliente.Location = new System.Drawing.Point(128, 98);
            this.lueGrupoCliente.Name = "lueGrupoCliente";
            this.lueGrupoCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGrupoCliente.Size = new System.Drawing.Size(325, 20);
            this.lueGrupoCliente.TabIndex = 67;
            // 
            // lueStatus
            // 
            this.lueStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "Estatus", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueStatus.Location = new System.Drawing.Point(574, 100);
            this.lueStatus.Name = "lueStatus";
            this.lueStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStatus.Size = new System.Drawing.Size(100, 20);
            this.lueStatus.TabIndex = 54;
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(505, 75);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(50, 13);
            this.labelControl33.TabIndex = 53;
            this.labelControl33.Text = "Gasolinero";
            // 
            // labelControl32
            // 
            this.labelControl32.Location = new System.Drawing.Point(21, 103);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(65, 13);
            this.labelControl32.TabIndex = 52;
            this.labelControl32.Text = "Grupo Cliente";
            // 
            // labelControl30
            // 
            this.labelControl30.Location = new System.Drawing.Point(505, 49);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(46, 13);
            this.labelControl30.TabIndex = 50;
            this.labelControl30.Text = "Vendedor";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(505, 103);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 13);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "Estatus";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Razon Social";
            // 
            // txtRFC
            // 
            this.txtRFC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "RFC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRFC.EditValue = "";
            this.txtRFC.Location = new System.Drawing.Point(128, 124);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Properties.MaxLength = 15;
            this.txtRFC.Size = new System.Drawing.Size(325, 20);
            this.txtRFC.TabIndex = 28;
            // 
            // chkClienteActivo
            // 
            this.chkClienteActivo.EditValue = true;
            this.chkClienteActivo.Enabled = false;
            this.chkClienteActivo.Location = new System.Drawing.Point(505, 126);
            this.chkClienteActivo.Name = "chkClienteActivo";
            this.chkClienteActivo.Properties.Caption = "Cliente Activo";
            this.chkClienteActivo.Size = new System.Drawing.Size(115, 19);
            this.chkClienteActivo.TabIndex = 24;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(21, 127);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(32, 13);
            this.labelControl12.TabIndex = 22;
            this.labelControl12.Text = "R.F.C.";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNombre.EditValue = "";
            this.txtNombre.Location = new System.Drawing.Point(128, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Properties.MaxLength = 80;
            this.txtNombre.Size = new System.Drawing.Size(325, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtClienteID
            // 
            this.txtClienteID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "ClienteID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtClienteID.Location = new System.Drawing.Point(128, 20);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(66, 20);
            this.txtClienteID.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nombre";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cliente";
            // 
            // tpCredito
            // 
            this.tpCredito.Controls.Add(this.lueDiaPago);
            this.tpCredito.Controls.Add(this.lueDiaRevision);
            this.tpCredito.Controls.Add(this.chkAutorizaValeCredito);
            this.tpCredito.Controls.Add(this.chkAutorizaCheque);
            this.tpCredito.Controls.Add(this.chkAfectaHistorico);
            this.tpCredito.Controls.Add(this.txtFacturaLiquidacion);
            this.tpCredito.Controls.Add(this.txtTicketBoucher);
            this.tpCredito.Controls.Add(this.lueGrupoFactura);
            this.tpCredito.Controls.Add(this.txtClasificacion);
            this.tpCredito.Controls.Add(this.txtTarjeta);
            this.tpCredito.Controls.Add(this.labelControl31);
            this.tpCredito.Controls.Add(this.labelControl29);
            this.tpCredito.Controls.Add(this.labelControl27);
            this.tpCredito.Controls.Add(this.labelControl25);
            this.tpCredito.Controls.Add(this.labelControl24);
            this.tpCredito.Controls.Add(this.labelControl16);
            this.tpCredito.Controls.Add(this.labelControl15);
            this.tpCredito.Controls.Add(this.groupControl2);
            this.tpCredito.Controls.Add(this.groupControl1);
            this.tpCredito.Name = "tpCredito";
            this.tpCredito.Size = new System.Drawing.Size(676, 257);
            this.tpCredito.Text = "Credito";
            // 
            // lueDiaPago
            // 
            this.lueDiaPago.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "DiaPagoID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueDiaPago.Location = new System.Drawing.Point(130, 218);
            this.lueDiaPago.Name = "lueDiaPago";
            this.lueDiaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDiaPago.Size = new System.Drawing.Size(100, 20);
            this.lueDiaPago.TabIndex = 103;
            // 
            // lueDiaRevision
            // 
            this.lueDiaRevision.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "DiaRevisionID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueDiaRevision.Location = new System.Drawing.Point(130, 192);
            this.lueDiaRevision.Name = "lueDiaRevision";
            this.lueDiaRevision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDiaRevision.Size = new System.Drawing.Size(100, 20);
            this.lueDiaRevision.TabIndex = 102;
            // 
            // chkAutorizaValeCredito
            // 
            this.chkAutorizaValeCredito.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "AutorizaValeCredito", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutorizaValeCredito.Location = new System.Drawing.Point(270, 282);
            this.chkAutorizaValeCredito.Name = "chkAutorizaValeCredito";
            this.chkAutorizaValeCredito.Properties.Caption = "Autoriza Vale Credito";
            this.chkAutorizaValeCredito.Size = new System.Drawing.Size(136, 19);
            this.chkAutorizaValeCredito.TabIndex = 101;
            // 
            // chkAutorizaCheque
            // 
            this.chkAutorizaCheque.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "AutorizaCheque", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutorizaCheque.Location = new System.Drawing.Point(270, 256);
            this.chkAutorizaCheque.Name = "chkAutorizaCheque";
            this.chkAutorizaCheque.Properties.Caption = "Autoriza Cheque";
            this.chkAutorizaCheque.Size = new System.Drawing.Size(100, 19);
            this.chkAutorizaCheque.TabIndex = 100;
            // 
            // chkAfectaHistorico
            // 
            this.chkAfectaHistorico.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "AfectaHistorico", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAfectaHistorico.Location = new System.Drawing.Point(270, 230);
            this.chkAfectaHistorico.Name = "chkAfectaHistorico";
            this.chkAfectaHistorico.Properties.Caption = "Afecta Historico";
            this.chkAfectaHistorico.Size = new System.Drawing.Size(100, 19);
            this.chkAfectaHistorico.TabIndex = 99;
            // 
            // txtFacturaLiquidacion
            // 
            this.txtFacturaLiquidacion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "FacturayLiquidacion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFacturaLiquidacion.Location = new System.Drawing.Point(130, 295);
            this.txtFacturaLiquidacion.Name = "txtFacturaLiquidacion";
            this.txtFacturaLiquidacion.Size = new System.Drawing.Size(100, 20);
            this.txtFacturaLiquidacion.TabIndex = 98;
            // 
            // txtTicketBoucher
            // 
            this.txtTicketBoucher.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "TicketBoucher", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTicketBoucher.Location = new System.Drawing.Point(130, 270);
            this.txtTicketBoucher.Name = "txtTicketBoucher";
            this.txtTicketBoucher.Size = new System.Drawing.Size(100, 20);
            this.txtTicketBoucher.TabIndex = 97;
            // 
            // lueGrupoFactura
            // 
            this.lueGrupoFactura.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "GrupoFacturarID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lueGrupoFactura.Location = new System.Drawing.Point(130, 166);
            this.lueGrupoFactura.Name = "lueGrupoFactura";
            this.lueGrupoFactura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGrupoFactura.Size = new System.Drawing.Size(161, 20);
            this.lueGrupoFactura.TabIndex = 96;
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "Clasificacion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtClasificacion.Location = new System.Drawing.Point(130, 244);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(100, 20);
            this.txtClasificacion.TabIndex = 95;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "TarjetaID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTarjeta.Location = new System.Drawing.Point(130, 321);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtTarjeta.TabIndex = 94;
            // 
            // labelControl31
            // 
            this.labelControl31.Location = new System.Drawing.Point(23, 169);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(69, 13);
            this.labelControl31.TabIndex = 93;
            this.labelControl31.Text = "Grupo Factura";
            // 
            // labelControl29
            // 
            this.labelControl29.Location = new System.Drawing.Point(23, 299);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(101, 13);
            this.labelControl29.TabIndex = 92;
            this.labelControl29.Text = "Factura y Liquidacion";
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(23, 273);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(70, 13);
            this.labelControl27.TabIndex = 91;
            this.labelControl27.Text = "Ticket Boucher";
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(23, 221);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(42, 13);
            this.labelControl25.TabIndex = 90;
            this.labelControl25.Text = "Dia Pago";
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(23, 195);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(58, 13);
            this.labelControl24.TabIndex = 89;
            this.labelControl24.Text = "Dia Revision";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(23, 247);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(58, 13);
            this.labelControl16.TabIndex = 88;
            this.labelControl16.Text = "Clasificacion";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(23, 324);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(35, 13);
            this.labelControl15.TabIndex = 87;
            this.labelControl15.Text = "Tarjeta";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dateEdit3);
            this.groupControl2.Controls.Add(this.dateEdit2);
            this.groupControl2.Controls.Add(this.dateEdit1);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.dateFechaIngreso);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.dateFechaBaja);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Location = new System.Drawing.Point(335, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(273, 158);
            this.groupControl2.TabIndex = 86;
            this.groupControl2.Text = "Fechas";
            // 
            // dateEdit3
            // 
            this.dateEdit3.EditValue = null;
            this.dateEdit3.Location = new System.Drawing.Point(148, 127);
            this.dateEdit3.Name = "dateEdit3";
            this.dateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit3.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit3.Size = new System.Drawing.Size(100, 20);
            this.dateEdit3.TabIndex = 59;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(148, 101);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 58;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(148, 75);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 57;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 24);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 13);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "Fecha Ingreso";
            // 
            // dateFechaIngreso
            // 
            this.dateFechaIngreso.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "FechaIngreso", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateFechaIngreso.EditValue = null;
            this.dateFechaIngreso.Location = new System.Drawing.Point(148, 23);
            this.dateFechaIngreso.Name = "dateFechaIngreso";
            this.dateFechaIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaIngreso.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.dateFechaIngreso.TabIndex = 55;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(5, 52);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(53, 13);
            this.labelControl8.TabIndex = 35;
            this.labelControl8.Text = "Fecha Baja";
            // 
            // dateFechaBaja
            // 
            this.dateFechaBaja.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "FechaBaja", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateFechaBaja.EditValue = null;
            this.dateFechaBaja.Location = new System.Drawing.Point(148, 49);
            this.dateFechaBaja.Name = "dateFechaBaja";
            this.dateFechaBaja.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaBaja.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaBaja.Size = new System.Drawing.Size(100, 20);
            this.dateFechaBaja.TabIndex = 56;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(5, 78);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(67, 13);
            this.labelControl11.TabIndex = 38;
            this.labelControl11.Text = "Ultimo Cambio";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(5, 102);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(77, 13);
            this.labelControl13.TabIndex = 39;
            this.labelControl13.Text = "Cambio Anterior";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(5, 128);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(56, 13);
            this.labelControl14.TabIndex = 40;
            this.labelControl14.Text = "Ultimo Pago";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.txtLimiteCredito);
            this.groupControl1.Controls.Add(this.txtDeposito);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtNIP);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Location = new System.Drawing.Point(23, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(273, 142);
            this.groupControl1.TabIndex = 85;
            this.groupControl1.Text = "Credito";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(5, 24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 13);
            this.labelControl9.TabIndex = 36;
            this.labelControl9.Text = "Limite Credito";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(5, 96);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 82;
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "LimiteCredito", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLimiteCredito.Location = new System.Drawing.Point(5, 43);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Properties.MaxLength = 15;
            this.txtLimiteCredito.Size = new System.Drawing.Size(100, 20);
            this.txtLimiteCredito.TabIndex = 58;
            // 
            // txtDeposito
            // 
            this.txtDeposito.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "Deposito", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDeposito.Location = new System.Drawing.Point(148, 43);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Properties.MaxLength = 15;
            this.txtDeposito.Size = new System.Drawing.Size(100, 20);
            this.txtDeposito.TabIndex = 59;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(148, 24);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(42, 13);
            this.labelControl10.TabIndex = 37;
            this.labelControl10.Text = "Deposito";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Plazo Pago";
            // 
            // txtNIP
            // 
            this.txtNIP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spCatClienteBindingSource, "NIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNIP.Location = new System.Drawing.Point(148, 96);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Properties.MaxLength = 15;
            this.txtNIP.Size = new System.Drawing.Size(100, 20);
            this.txtNIP.TabIndex = 57;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(148, 77);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(17, 13);
            this.labelControl7.TabIndex = 34;
            this.labelControl7.Text = "NIP";
            // 
            // tpDatosINE
            // 
            this.tpDatosINE.Controls.Add(this.gridControl1);
            this.tpDatosINE.Controls.Add(this.textEdit17);
            this.tpDatosINE.Controls.Add(this.lookUpEdit4);
            this.tpDatosINE.Controls.Add(this.textEdit16);
            this.tpDatosINE.Controls.Add(this.lueEntidadINE);
            this.tpDatosINE.Controls.Add(this.lueTipoComite);
            this.tpDatosINE.Controls.Add(this.lueTipoProceso);
            this.tpDatosINE.Controls.Add(this.labelControl22);
            this.tpDatosINE.Controls.Add(this.labelControl21);
            this.tpDatosINE.Controls.Add(this.labelControl20);
            this.tpDatosINE.Controls.Add(this.labelControl19);
            this.tpDatosINE.Controls.Add(this.labelControl18);
            this.tpDatosINE.Controls.Add(this.labelControl17);
            this.tpDatosINE.Controls.Add(this.chkDatosINE);
            this.tpDatosINE.Name = "tpDatosINE";
            this.tpDatosINE.Size = new System.Drawing.Size(676, 257);
            this.tpDatosINE.Text = "Datos INE";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spCatClienteINEBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(362, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(341, 200);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // spCatClienteINEBindingSource
            // 
            this.spCatClienteINEBindingSource.DataMember = "spCatClienteINE";
            this.spCatClienteINEBindingSource.DataSource = this.spCatClienteINEDS1;
            this.spCatClienteINEBindingSource.Sort = "";
            // 
            // spCatClienteINEDS1
            // 
            this.spCatClienteINEDS1.DataSetName = "spCatClienteINEDS";
            this.spCatClienteINEDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClienteINEID,
            this.colINETipoProceso,
            this.colTipoComite,
            this.colINEIDContabilidad,
            this.colINEClaveEntidad,
            this.colINEEntidadAmbito,
            this.colINEEntidadContabilidad,
            this.colClienteID1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colClienteINEID
            // 
            this.colClienteINEID.FieldName = "ClienteINEID";
            this.colClienteINEID.Name = "colClienteINEID";
            this.colClienteINEID.Visible = true;
            this.colClienteINEID.VisibleIndex = 0;
            // 
            // colINETipoProceso
            // 
            this.colINETipoProceso.FieldName = "INETipoProceso";
            this.colINETipoProceso.Name = "colINETipoProceso";
            this.colINETipoProceso.Visible = true;
            this.colINETipoProceso.VisibleIndex = 1;
            // 
            // colTipoComite
            // 
            this.colTipoComite.FieldName = "TipoComite";
            this.colTipoComite.Name = "colTipoComite";
            this.colTipoComite.Visible = true;
            this.colTipoComite.VisibleIndex = 2;
            // 
            // colINEIDContabilidad
            // 
            this.colINEIDContabilidad.FieldName = "INEIDContabilidad";
            this.colINEIDContabilidad.Name = "colINEIDContabilidad";
            this.colINEIDContabilidad.Visible = true;
            this.colINEIDContabilidad.VisibleIndex = 3;
            // 
            // colINEClaveEntidad
            // 
            this.colINEClaveEntidad.FieldName = "INEClaveEntidad";
            this.colINEClaveEntidad.Name = "colINEClaveEntidad";
            this.colINEClaveEntidad.Visible = true;
            this.colINEClaveEntidad.VisibleIndex = 4;
            // 
            // colINEEntidadAmbito
            // 
            this.colINEEntidadAmbito.FieldName = "INEEntidadAmbito";
            this.colINEEntidadAmbito.Name = "colINEEntidadAmbito";
            this.colINEEntidadAmbito.Visible = true;
            this.colINEEntidadAmbito.VisibleIndex = 5;
            // 
            // colINEEntidadContabilidad
            // 
            this.colINEEntidadContabilidad.FieldName = "INEEntidadContabilidad";
            this.colINEEntidadContabilidad.Name = "colINEEntidadContabilidad";
            this.colINEEntidadContabilidad.Visible = true;
            this.colINEEntidadContabilidad.VisibleIndex = 6;
            // 
            // colClienteID1
            // 
            this.colClienteID1.FieldName = "ClienteID";
            this.colClienteID1.Name = "colClienteID1";
            this.colClienteID1.Visible = true;
            this.colClienteID1.VisibleIndex = 7;
            // 
            // textEdit17
            // 
            this.textEdit17.Location = new System.Drawing.Point(126, 187);
            this.textEdit17.Name = "textEdit17";
            this.textEdit17.Size = new System.Drawing.Size(214, 20);
            this.textEdit17.TabIndex = 12;
            // 
            // lookUpEdit4
            // 
            this.lookUpEdit4.Location = new System.Drawing.Point(126, 161);
            this.lookUpEdit4.Name = "lookUpEdit4";
            this.lookUpEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOCAL", "lOCAL"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FEDERAL", "FEDERAL")});
            this.lookUpEdit4.Properties.NullText = "";
            this.lookUpEdit4.Size = new System.Drawing.Size(214, 20);
            this.lookUpEdit4.TabIndex = 11;
            // 
            // textEdit16
            // 
            this.textEdit16.Location = new System.Drawing.Point(126, 109);
            this.textEdit16.Name = "textEdit16";
            this.textEdit16.Size = new System.Drawing.Size(214, 20);
            this.textEdit16.TabIndex = 10;
            // 
            // lueEntidadINE
            // 
            this.lueEntidadINE.Location = new System.Drawing.Point(126, 135);
            this.lueEntidadINE.Name = "lueEntidadINE";
            this.lueEntidadINE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEntidadINE.Properties.NullText = "";
            this.lueEntidadINE.Size = new System.Drawing.Size(214, 20);
            this.lueEntidadINE.TabIndex = 9;
            // 
            // lueTipoComite
            // 
            this.lueTipoComite.Location = new System.Drawing.Point(126, 83);
            this.lueTipoComite.Name = "lueTipoComite";
            this.lueTipoComite.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTipoComite.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EJECUTIVO NACIONAL", "EJECUTIVO NACIONAL"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EJECUTIVO ESTATAL", "EJECUTIVO ESTATAL")});
            this.lueTipoComite.Properties.NullText = "";
            this.lueTipoComite.Size = new System.Drawing.Size(214, 20);
            this.lueTipoComite.TabIndex = 8;
            // 
            // lueTipoProceso
            // 
            this.lueTipoProceso.Location = new System.Drawing.Point(126, 57);
            this.lueTipoProceso.Name = "lueTipoProceso";
            this.lueTipoProceso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTipoProceso.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ORDINARIO", "ORDINARIO"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CAMPAÑA", "CAMPAÑA"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRECAMPAÑA", "PRECAMPAÑA")});
            this.lueTipoProceso.Properties.NullText = "";
            this.lueTipoProceso.Size = new System.Drawing.Size(214, 20);
            this.lueTipoProceso.TabIndex = 7;
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(28, 194);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(90, 13);
            this.labelControl22.TabIndex = 6;
            this.labelControl22.Text = "ID. Conta. Entidad";
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(28, 168);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(33, 13);
            this.labelControl21.TabIndex = 5;
            this.labelControl21.Text = "Ambito";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(28, 142);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(36, 13);
            this.labelControl20.TabIndex = 4;
            this.labelControl20.Text = "Entidad";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(28, 116);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(73, 13);
            this.labelControl19.TabIndex = 3;
            this.labelControl19.Text = "ID Contabilidad";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(28, 92);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(71, 13);
            this.labelControl18.TabIndex = 2;
            this.labelControl18.Text = "Tipo de Comite";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(28, 64);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(76, 13);
            this.labelControl17.TabIndex = 1;
            this.labelControl17.Text = "Tipo de Proceso";
            // 
            // chkDatosINE
            // 
            this.chkDatosINE.Location = new System.Drawing.Point(28, 24);
            this.chkDatosINE.Name = "chkDatosINE";
            this.chkDatosINE.Properties.Caption = "Agregar Datos INE";
            this.chkDatosINE.Size = new System.Drawing.Size(160, 19);
            this.chkDatosINE.TabIndex = 0;
            // 
            // frmCatalogoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(808, 419);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatalogoCliente";
            this.Text = "Catálogo Clientes";
            this.Load += new System.EventHandler(this.frmCatalogoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcCatalogo)).EndInit();
            this.tcCatalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).EndInit();
            this.gcBusqueda.ResumeLayout(false);
            this.gcBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).EndInit();
            this.tpBuscar.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatClienteDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAgregarClientes)).EndInit();
            this.tbAgregarClientes.ResumeLayout(false);
            this.tbDatosGenerales.ResumeLayout(false);
            this.tbDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueFormaCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatDireccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatDireccionDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFormaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueFacturaUso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMetodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoInterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoExterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGasolinero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkClienteActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteID.Properties)).EndInit();
            this.tpCredito.ResumeLayout(false);
            this.tpCredito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDiaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDiaRevision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutorizaValeCredito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutorizaCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAfectaHistorico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacturaLiquidacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTicketBoucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupoFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClasificacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarjeta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaIngreso.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaBaja.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaBaja.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteCredito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNIP.Properties)).EndInit();
            this.tpDatosINE.ResumeLayout(false);
            this.tpDatosINE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatClienteINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatClienteINEDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit17.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit16.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEntidadINE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipoComite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipoProceso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDatosINE.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spCatClienteBindingSource;
        private Datasets.Catalogos.spCatClienteDS spCatClienteDS1;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteID;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colPlazoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colNIP;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaBaja;
        private DevExpress.XtraGrid.Columns.GridColumn colLimiteCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colDeposito;
        private DevExpress.XtraGrid.Columns.GridColumn colCambioCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colCambioCreditoAnterior;
        private DevExpress.XtraGrid.Columns.GridColumn colUltimoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colTarjetaID;
        private DevExpress.XtraGrid.Columns.GridColumn colClasificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colAfectaHistorico;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaRevisionID;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaPagoID;
        private DevExpress.XtraGrid.Columns.GridColumn colAutorizaCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colTicketBoucher;
        private DevExpress.XtraGrid.Columns.GridColumn colAutorizaValeCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturayLiquidacion;
        private DevExpress.XtraGrid.Columns.GridColumn colVendedorID;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoFacturarID;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoClienteID;
        private DevExpress.XtraGrid.Columns.GridColumn colGasolineroID;
        private DevExpress.XtraTab.XtraTabControl tbAgregarClientes;
        private DevExpress.XtraTab.XtraTabPage tpDatosINE;
        private DevExpress.XtraEditors.TextEdit textEdit17;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit16;
        private DevExpress.XtraEditors.LookUpEdit lueEntidadINE;
        private DevExpress.XtraEditors.LookUpEdit lueTipoComite;
        private DevExpress.XtraEditors.LookUpEdit lueTipoProceso;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.CheckEdit chkDatosINE;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spCatClienteINEBindingSource;
        private Datasets.Catalogos.spCatClienteINEDS spCatClienteINEDS1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteINEID;
        private DevExpress.XtraGrid.Columns.GridColumn colINETipoProceso;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoComite;
        private DevExpress.XtraGrid.Columns.GridColumn colINEIDContabilidad;
        private DevExpress.XtraGrid.Columns.GridColumn colINEClaveEntidad;
        private DevExpress.XtraGrid.Columns.GridColumn colINEEntidadAmbito;
        private DevExpress.XtraGrid.Columns.GridColumn colINEEntidadContabilidad;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteID1;
        private DevExpress.XtraTab.XtraTabPage tpCredito;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.DateEdit dateEdit3;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateFechaIngreso;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit dateFechaBaja;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit txtLimiteCredito;
        private DevExpress.XtraEditors.TextEdit txtDeposito;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNIP;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraTab.XtraTabPage tbDatosGenerales;
        private DevExpress.XtraEditors.TextEdit txtRazonSocial;
        private DevExpress.XtraEditors.LookUpEdit lueGasolinero;
        private DevExpress.XtraEditors.LookUpEdit lueVendedor;
        private DevExpress.XtraEditors.LookUpEdit lueGrupoCliente;
        private DevExpress.XtraEditors.LookUpEdit lueStatus;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtRFC;
        private DevExpress.XtraEditors.CheckEdit chkClienteActivo;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtClienteID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueDiaPago;
        private DevExpress.XtraEditors.LookUpEdit lueDiaRevision;
        private DevExpress.XtraEditors.CheckEdit chkAutorizaValeCredito;
        private DevExpress.XtraEditors.CheckEdit chkAutorizaCheque;
        private DevExpress.XtraEditors.CheckEdit chkAfectaHistorico;
        private DevExpress.XtraEditors.TextEdit txtFacturaLiquidacion;
        private DevExpress.XtraEditors.TextEdit txtTicketBoucher;
        private DevExpress.XtraEditors.LookUpEdit lueGrupoFactura;
        private DevExpress.XtraEditors.TextEdit txtClasificacion;
        private DevExpress.XtraEditors.TextEdit txtTarjeta;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private System.Windows.Forms.BindingSource spCatDireccionBindingSource;
        private Datasets.Catalogos.spCatDireccionDS spCatDireccionDS1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccionID;
        private DevExpress.XtraGrid.Columns.GridColumn colDomicilio;
        private DevExpress.XtraGrid.Columns.GridColumn colNoExterior;
        private DevExpress.XtraGrid.Columns.GridColumn colNoInterior;
        private DevExpress.XtraGrid.Columns.GridColumn colColonia;
        private DevExpress.XtraGrid.Columns.GridColumn colCP;
        private DevExpress.XtraGrid.Columns.GridColumn colCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaExpress;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoEnPuntos;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoPaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoMaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colNacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colSexo;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteID2;
        private DevExpress.XtraGrid.Columns.GridColumn colMetodoPagoID;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteINEID1;
        private DevExpress.XtraGrid.Columns.GridColumn colPuntosCategoriaID;
        private DevExpress.XtraGrid.Columns.GridColumn colFacturaUsoID;
        private DevExpress.XtraGrid.Columns.GridColumn colFormaPagoID;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioID;
        private DevExpress.XtraGrid.Columns.GridColumn colFormaCompraID;
        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.LabelControl labelControl38;
        private DevExpress.XtraEditors.LabelControl labelControl37;
        private DevExpress.XtraEditors.LabelControl labelControl36;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LookUpEdit lueEstado;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtMunicipio;
        private DevExpress.XtraEditors.TextEdit txtCiudad;
        private DevExpress.XtraEditors.TextEdit txtColonia;
        private DevExpress.XtraEditors.TextEdit txtCP;
        private DevExpress.XtraEditors.TextEdit txtNoInterior;
        private DevExpress.XtraEditors.TextEdit txtNoExterior;
        private DevExpress.XtraEditors.TextEdit txtCalle;
        private DevExpress.XtraEditors.LabelControl labelControl40;
        private DevExpress.XtraEditors.LookUpEdit lueMetodoPago;
        private DevExpress.XtraEditors.LookUpEdit lueFormaCompra;
        private DevExpress.XtraEditors.LookUpEdit lueFormaPago;
        private DevExpress.XtraEditors.LookUpEdit lueFacturaUso;
        private DevExpress.XtraEditors.LabelControl labelControl43;
        private DevExpress.XtraEditors.LabelControl labelControl42;
        private DevExpress.XtraEditors.LabelControl labelControl41;
    }
}
