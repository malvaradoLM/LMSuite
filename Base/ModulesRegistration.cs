using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPSuite.Forms.Catalogos;
using RPSuite.Forms;
using RPSuite.Forms.Catalogos.Configuracion;
using RPSuite.Forms.Liquidacion;
using RPSuite.Forms.Inventario;
using RPSuite.Forms.Consumo;
using RPSuite.Forms.Puntos;
using RPSuite.Forms.Buscar;
using RPSuite.Forms.Volumetrico;
using RPSuite.Forms.Flotillas.Recibo;
using RPSuite.Forms.Flotillas.Cupones;

namespace RPSuite.Base
{
        // Clase global de modulos registrados
        public class ModulesRegistration

        {
            // Regitrar aqui todos los modulos 
            static public void Register()
            {
                //ModuleInfoCollection.Add("Module1", typeof(frmCatalogoEstacion));
                ModuleInfoCollection.Add("Module2", typeof(Form2));
                ModuleInfoCollection.Add("CatalogoCliente", typeof(frmCatalogoCliente));
                ModuleInfoCollection.Add("CatalogoBanco", typeof(frmCatalogoBanco));
                ModuleInfoCollection.Add("CatalogoReportes", typeof(frmCatalogoReportes));
                ModuleInfoCollection.Add("CatalogoCategoria", typeof(frmCatalogoCategoria));
                ModuleInfoCollection.Add("CatalogoProducto", typeof(frmCatalogoProducto));
                ModuleInfoCollection.Add("CatalogoCuentaBancaria", typeof(frmCatalogoCuentaBancaria));
                ModuleInfoCollection.Add("CatalogoProveedor", typeof(frmCatalogoProveedor));
                ModuleInfoCollection.Add("CatalogoFormadePago", typeof(frmCatalogoFormadePago));
                ModuleInfoCollection.Add("CatalogoEstacion", typeof(frmCatalogoEstacion));
                ModuleInfoCollection.Add("CatalogoGrupoNomina", typeof(frmCatalogoGrupoNomina));
                ModuleInfoCollection.Add("CatalogoEmpleado", typeof(frmCatalogoEmpleadocs));
                ModuleInfoCollection.Add("CatalogoTipoDocumento", typeof(frmCatalogoTipoDocumento));
                ModuleInfoCollection.Add("CatalogoDiaFestivo", typeof(frmCatalogoDiaFestivo));
                ModuleInfoCollection.Add("CatalogoTerminalBiometrica", typeof(frmCatalogoTerminalBiometrica));
                ModuleInfoCollection.Add("CatalogoVendedor", typeof(frmCatalogoVendedor));
                ModuleInfoCollection.Add("CatalogoGasolinero", typeof(frmCatalogoGasolinero));
                ModuleInfoCollection.Add("CatalogoFormaCompra", typeof(frmCatalogoFormaCompra));
                ModuleInfoCollection.Add("CatalogoGrupoFactura", typeof(frmCatalogoGrupoFactura));
                ModuleInfoCollection.Add("CatalogoUsuario", typeof(frmCatalogoUsuario));
                ModuleInfoCollection.Add("CatalogoVehiculo", typeof(frmCatVehiculo));

            // Facturacion
            ModuleInfoCollection.Add("FacturacionContado", typeof(frmFacturaContado));


            //Almacen
            ModuleInfoCollection.Add("Almacen", typeof(frmAlmacen));

            //Liquidacion
                ModuleInfoCollection.Add("liquidacion", typeof(frmLiquidacion));
                ModuleInfoCollection.Add("Depositos", typeof(frmDeposito));
            ModuleInfoCollection.Add("CierreMensual", typeof(frmCierreMensual));
            ModuleInfoCollection.Add("Conciliacion", typeof(frmConciliacion));
            ModuleInfoCollection.Add("ConsumoFlotillas", typeof(frmConsumoFlotillas));

            //Flotillas
            ModuleInfoCollection.Add("Consumo", typeof(frmConsumo));

            //Cartera
            ModuleInfoCollection.Add("ReciboCredito", typeof(frmReciboCredito));
            ModuleInfoCollection.Add("ReciboDebito", typeof(frmReciboDebito));
            ModuleInfoCollection.Add("EliminaRecibo", typeof(frmEliminaRecibo));
            ModuleInfoCollection.Add("ConciliacionRecibos", typeof(frmConciliacionRecibos));
            ModuleInfoCollection.Add("ImprimirCupon", typeof(frmCupon));
            ModuleInfoCollection.Add("CancelarCupones", typeof(frmCancelarCupon));
            ModuleInfoCollection.Add("EstadoCupon", typeof(frmEstadoCupon));


            //Puntos
            ModuleInfoCollection.Add("EntregarPremio", typeof(frmEntregarPremio));
            ModuleInfoCollection.Add("CatalogoPremio", typeof(frmCatalogoPremio));
            ModuleInfoCollection.Add("CategoriaPuntos", typeof(frmCategoriaPuntos));

            ModuleInfoCollection.Add("CategoriaPuntos", typeof(frmBuscar));

            //Volumetrico
            ModuleInfoCollection.Add("Consola", typeof(frmConsola));
            ModuleInfoCollection.Add("Cortes", typeof(frmCorte));
            ModuleInfoCollection.Add("CambioPrecios", typeof(frmCambioPrecios));
            ModuleInfoCollection.Add("Tanques", typeof(frmTanques));


        }
    }    
}
