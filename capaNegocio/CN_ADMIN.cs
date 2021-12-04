using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaDatos;

namespace capaNegocio
{
    public class CN_ADMIN
    {

        private sqlADMIN SA = new sqlADMIN();

        //-----------------CHOFERES--------------------------------------
        //MOSTRAR LOS DATOS DE LOS CHOFERES.
        public DataTable MostarChoferes() {
            DataTable tabla = new DataTable();
            tabla = SA.Mostrar();
            return tabla;
        }

        //INSERTAR DATOS DE LOS CHOFERES.
        public void InsertarChoferes(string nombre, string apellido, string fecha, string cedula)
        {
            SA.Insertar(nombre,apellido,fecha,cedula);
        }

        //-------------------AUTBOUSES-----------------------------------
        //MOSTRAR LOS DATOS DE LOS AUTOBUSES
        public DataTable mostrarAutobuses() {
            DataTable tabla = new DataTable();
            tabla = SA.MostrarAutobuses();
            return tabla;
        }

        //INSERTAR DATOS DE LOS AUTOBUSES.
        public void InsertarAutobuses(string marca, string modelo, string placa, string color, string year) {
            SA.InsertarAutobuses(marca,modelo,placa,color,year);
        }

        //-------------------RUTAS-----------------------------------
        //MOSRTRAR LOS DATOS DE LAS RUTAS
        public DataTable mostrarRutas() {
            DataTable tabla = new DataTable();
            tabla = SA.MostrarRutas();
            return tabla;
        }

        //INSERTAR LOS DATOS DE LAS RUTAS.
        public void InsertarRuta(string nombre) {
            SA.InsertarRutas(nombre);
        }
    }
}
