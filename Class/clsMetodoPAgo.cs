using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    class clsMetodoPago
    {
        public int MetodoPagoID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public List<clsMetodoPago> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsMetodoPago> MetodoPago = new List<clsMetodoPago>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                MetodoPago.Add(new clsMetodoPago()
                {
                    MetodoPagoID = dr.Field<int>("MetodoPagoID"),
                    Descripcion = dr.Field<string>("Descripcion")
                });

            }
            return MetodoPago;


        }
    }
}
