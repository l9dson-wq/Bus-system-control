using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    class sqlConnection
    {
        private SqlConnection Conexion = new SqlConnection("SERVER= ; DATABASE= ; INTEGRATED SECURITY=true");
    }
}
