using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    class clsGrupoTiempoAire
    {
        public int TiempoAireGrupoID
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public List<clsGrupoTiempoAire> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsGrupoTiempoAire> GrupoTiempoAire = new List<clsGrupoTiempoAire>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                GrupoTiempoAire.Add(new clsGrupoTiempoAire()
                {
                    TiempoAireGrupoID = dr.Field<int>("TiempoAireGrupoID"),
                    Nombre = dr.Field<string>("Nombre")
                });

            }
            return GrupoTiempoAire;


        }
    }
}
