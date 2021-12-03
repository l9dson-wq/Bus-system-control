using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class sqlConnection
    {
        private SqlConnection Conexion = new SqlConnection("SERVER=ANDELSON; DATABASE=sistemaAutobus; INTEGRATED SECURITY=true");

        public SqlConnection AbrirConexion() {
            if (Conexion.State == ConnectionState.Closed) {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection CerrarConexion() {
            if (Conexion.State == ConnectionState.Closed) {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
