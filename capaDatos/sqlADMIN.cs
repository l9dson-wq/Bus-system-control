using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class sqlADMIN
    {
        sqlConnection conexion = new sqlConnection();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        //MANIPULACION DE LOS DATOS DE LA TABLA DE CHOFERES.
            //MOSTRAR LOS DATOS DE LOS CHOFERES EN UNA TABLA.
        public DataTable Mostrar() {
            //TRANSACT SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM choferes";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //INSERTAR LOS DATOS DE LOS CHOFERES
        public void Insertar(string nombre, string apellido, string fecha, string cedula) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO choferes VALUES ('"+nombre+"','"+apellido+"','"+fecha+"','"+cedula+"'); ";
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //MANIPULACION DE LOS DATOS DE LA TABLA DE AUTOBUSES.
        //MOSTRAR LOS DATOS DE LOS AUTOBUSES
        public DataTable MostrarAutobuses() {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM autobuses";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //INSERTAR LOS DATOS DE LOS AUTOBUSES.
        public void InsertarAutobuses(string marca, string modelo, string placa, string color, string year) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO autobuses VALUES('"+marca+"','"+modelo+"','"+placa+"','"+color+"','"+year+"') ";
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //MANIPULACION DE LOS DATOS DE LAS RUTAS .
        //MOSTRAR LOS DATO S DE LAS RUTAS.
        public DataTable MostrarRutas() {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM ruta";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //INSERTAR LOS DATOS DE LAS RUTAS
        public void InsertarRutas(string nombre) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO ruta VALUES ('"+nombre+"')";
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
