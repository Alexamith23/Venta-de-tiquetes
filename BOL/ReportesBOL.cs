using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using DAL;

namespace BOL
{
    public class ReportesBOL
    {
        /// <summary>
        ///  Allows to  generate a LIST of Unidades without permission to travel
        /// </summary>
        /// <returns>LIST of Unidades without permission to travel</returns>
        public List<Unidad> UnidadesSinPermiso()
        {
            List<Unidad> ze = new List<Unidad>();
            UnidadDAL x = new UnidadDAL();
            List<Unidad> z = x.cargarUnidades();
            foreach (Unidad a in z)
            {
                if (Convert.ToDateTime(a.GSFechaVigencia).Date < DateTime.Now.Date)
                {
                    ze.Add(a);
                }
            }
            return ze;

        }
        /// <summary>
        /// Allows to  generate a LIST of Unidades with permission to travel
        /// </summary>
        /// <returns>LIST of Unidades with permission to travel</returns>
        public List<Unidad> UnidadesConPermiso()
        {
            List<Unidad> ze = new List<Unidad>();
            UnidadDAL x = new UnidadDAL();
            List<Unidad> z = x.cargarUnidades();
            foreach (Unidad a in z)
            {
                if (Convert.ToDateTime(a.GSFechaVigencia).Date > DateTime.Now.Date)
                {
                    ze.Add(a);
                }
            }
            return ze;
        }


    }
}
