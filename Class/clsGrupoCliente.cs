using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    public class clsGrupoCliente
    {
        public int GrupoClienteID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public List<clsGrupoCliente> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsGrupoCliente> GrupoCliente = new List<clsGrupoCliente>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                GrupoCliente.Add(new clsGrupoCliente()
                {
                    GrupoClienteID = dr.Field<int>("GrupoClienteID"),
                    Descripcion = dr.Field<string>("Descripcion")
                });

            }
            return GrupoCliente;


        }
    }
}
