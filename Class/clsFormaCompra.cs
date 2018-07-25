using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    class clsFormaCompra
    {
        public int FormaCompraID
        {
            get;
            set;

        }

        public string Nombre
        {
            get;
            set;
        }

        public List<clsFormaCompra> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsFormaCompra> FormaCompra = new List<clsFormaCompra>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                FormaCompra.Add(new clsFormaCompra()
                {
                    FormaCompraID = dr.Field<int>("FormaCompraID"),
                    Nombre = dr.Field<string>("Nombre")
                });

            }
            return FormaCompra;


        }
    }
}
