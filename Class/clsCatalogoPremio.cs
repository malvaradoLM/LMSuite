using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSuite.Class
{
    class clsCatalogoPremio
    {
        public int PuntosPremioID { get; set; }

        public string Descripcion { get; set; }

        public List<clsCatalogoPremio> FillList(DataTable dt)
        {
            //Creamos una lista de Premios 
            List<clsCatalogoPremio> CatPremio = new List<clsCatalogoPremio>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                CatPremio.Add(new clsCatalogoPremio() { PuntosPremioID = dr.Field<int>("PuntosPremioID"), Descripcion = dr.Field<string>("Descripcion") });

            }
            return CatPremio;
            
        }




    }
}
