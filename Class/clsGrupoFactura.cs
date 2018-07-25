using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    class clsGrupoFactura
    {
        public int GrupoFacturaID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public List<clsGrupoFactura> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsGrupoFactura> GrupoFactura = new List<clsGrupoFactura>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                GrupoFactura.Add(new clsGrupoFactura()
                {
                    GrupoFacturaID = dr.Field<int>("GrupoFacturarID"),
                    Descripcion = dr.Field<string>("Descripcion")
                });

            }
            return GrupoFactura;


        }
    }
}
