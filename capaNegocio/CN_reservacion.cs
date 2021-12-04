using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using System.Data;
using System.Data.SqlClient;

namespace capaNegocio
{
    public class CN_reservacion
    {

        sqlListaReservaciones SLR1 = new sqlListaReservaciones();

        //PASANDO LOS NOMBRES DE LOS CHOFERES A LA CAPA DE PRESENTACION (USUARIO COMUN RESERVACION)
        public DataTable MostarNombresChoferes()
        {
            DataTable tabla = new DataTable();
            tabla = SLR1.mostrarChoferes();
            return tabla;
        }
        //RETORNANDO A LA CAPA DE PRESENTACION LOS VALORES DE MI SELECCION
        public DataTable MostrarNombreAutobuses()
        {
            DataTable tabla = new DataTable();
            tabla = SLR1.mostrarAutobuses();
            return tabla;
        }
        //RETORNANDO A LA CAPA DE PRESENTACION LOS VALORES DE MI SELECCION
        public DataTable MostrarNombreRutas()
        {
            DataTable tabla = new DataTable();
            tabla = SLR1.mostrarRutas();
            return tabla;
        }
        //RETORNANDO A LA CAPA DE PRESENTACION LOS VALORES DE MI SELECCION 
        public DataTable MostrarReservaciones() {
            DataTable tabla = new DataTable();
            tabla = SLR1.mostrarReservaciones();
            return tabla;
        }
    }
}
