using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class sqlRegistrar
    {
        private sqlConnection conexion = new sqlConnection();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();

        //INSERTAR LOS DATOS
        public void registrarUsuario(string nombreUsuario, string claveUsuario, string tipoUsuario)
        {
            //TRANSACT SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO usuarios VALUES ('"+nombreUsuario+"', '"+claveUsuario+"','"+tipoUsuario+"') ";
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //EL DATATABLE PARA HACER EL LLAMADO DE LOS DATOS DESDE LA BASE DE DATOS PARA LUEGO COMPARARLOS EN LA CAPA DE NEGOCIO.
        public DataTable buscarUsuarioRegistro(string nombreUsuario)
        {
            //TRANSACT SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM usuarios where nombreUsuario = '" + nombreUsuario + "' ";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

    }
}
