using RemObjects.DataAbstract.Server;
using RPSuite.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPSuite.Forms.Buscar
{
    public partial class frmBuscar : RPSuite.Base.frmEstructura
    {
        private List<DataParameter> Params = new List<DataParameter>();
        public DataSet cdsBusqueda { get; set; }
        public string NombreDataSet { get; set; }
        public frmBuscar()
        {
            InitializeComponent();
        }

        public frmBuscar(DataSet BusquedaDS, BindingSource BindingSource,string DataMember,string NombreForm)
        {
            InitializeComponent();

            //BindingSource
            DataSource = BindingSource;
            DataSource.DataMember = DataMember;
            

            

            cdsBusqueda = BusquedaDS;
            
            NombreDataSet = DataMember;

            this.Text = "Buscar " + NombreForm;     
            Buscar("");
            DataSource.DataSource = BusquedaDS.Tables[NombreDataSet];
            dgcBusqueda.DataSource = DataSource;
        }

        private void Buscar(string Datos)
        {
            try
            {
                State = stEstado.Close;
                cdsBusqueda.Clear();

                Params.Clear();
                Data.DataModule.ParamByName(Params, "Datos", Datos);
                Data.DataModule.FillDataSet(cdsBusqueda, NombreDataSet, Params.ToArray());
                
                gvBuscar.BestFitColumns(true);
                State = stEstado.Browse;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateActions();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtDatosBusqueda.Text);
        }
    }
}
