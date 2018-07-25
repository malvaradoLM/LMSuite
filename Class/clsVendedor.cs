using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    public class clsVendedor
    {
        public int VendedorID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public List<clsVendedor> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsVendedor> Vendedor = new List<clsVendedor>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Vendedor.Add(new clsVendedor()
                {
                    VendedorID = dr.Field<int>("VendedorID"),
                    Descripcion = dr.Field<string>("Descripcion")
                });

            }
            return Vendedor;


        }
    }
}
