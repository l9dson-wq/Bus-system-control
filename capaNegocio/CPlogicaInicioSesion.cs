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
    public class CPlogicaInicioSesion
    {

        CDVerificarUsuario CDV1 = new CDVerificarUsuario();
        sqlRegistrar SR1 = new sqlRegistrar();

        //variable publica para el tipo de usuario
        public string datoTipoUsuario = null;

        //variable public para saber el nombre del reservador en el apartado de las reservas.
        public string nombreReservante = null;

        public bool buscarUsuario(string nombreUsuario, string claveUsuario) {
            //creo un objeto de tipo table para almacenar los valores de los usuarios (nombre y clave)
            DataTable tabla = new DataTable();

            string datos = null; // creo una variable de tipo string para comparabar cadenas.

            bool bandera = false; //creo una variable bandera para verificar que los datos estan

            tabla = CDV1.buscarUsuario(nombreUsuario, claveUsuario); //aqui recivo los datos desde la capa de presentacion

            //recorro la tabla para saber si tiene datos, de lo contrario bandera seguira false esto significa que el usuario no existe.
            foreach (DataRow dato in tabla.Rows) {
                datos= dato["nombreUsuario"].ToString();
                datoTipoUsuario = dato["tipoUsuario"].ToString();
                nombreReservante = dato["nombreUsuario"].ToString();
                if (datos == nombreUsuario)
                {
                    bandera = true;
                }
            }

            //retorno la bandera para segurarme en la capa de presentacion de que mis condiciones se hayan cumplido.
            return bandera;
        }

        //LOGICA PARA INSERTAR UN USUARIO Y SI EL USUARIO EXISTE ENTONCES LE DIRA QUE EL USUARIO EXISTE.
        public void insertarUsuarioRegistro(string nombreUsuario, string claveUsuario, string tipoUSuario) {
            SR1.registrarUsuario(nombreUsuario, claveUsuario, tipoUSuario);
        }

        //COMENZADO ANALIZANDO LA CADENA QUE ME DEVULEVA LA CAPA DE DATOS Y VERIFICAR CON LOS DATOS QUE ME DIO EL USUARIO QUE ESTO NO SEAN IGUALES A LOS QUE ME DEVUELVE LA TABLA.
        public bool compararUsuarioRegistro(string nombreUsuario) {

            DataTable tabla = new DataTable();
            string datos = null;
            bool bandera = false;

            tabla = SR1.buscarUsuarioRegistro(nombreUsuario); 

            foreach (DataRow dato in tabla.Rows)
            {
                datos = dato["nombreUsuario"].ToString();
                if (datos == nombreUsuario)
                {
                    bandera = true;
                }
            }

            return bandera;
        }
    }
}
