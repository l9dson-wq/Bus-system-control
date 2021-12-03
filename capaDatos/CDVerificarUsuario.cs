using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class CDVerificarUsuario
    {
        private sqlConnection conexion = new sqlConnection();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();

        public DataTable buscarUsuario(string nombreUsuario, string claveUsuario) {
            //TRANSACT SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM usuarios where nombreUsuario = '" + nombreUsuario + "' and claveUsuario = '" + claveUsuario + "' ";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
