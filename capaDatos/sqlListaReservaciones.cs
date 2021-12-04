﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class sqlListaReservaciones
    {

        private sqlConnection conexion = new sqlConnection();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();

        //CARGANDO TODOS LOS NOMBRE DE LOS CHOFERES.
        public DataTable mostrarChoferes() {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * FROM choferes";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //CARGANDO TODAS LAS MARCAS DE LOS AUTOBUSES.
        public DataTable mostrarAutobuses() {
            DataTable newTabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * FROM autobuses";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            newTabla.Load(leer);
            conexion.CerrarConexion();
            return newTabla;
        }

        //CARGANDO TODAS LAS RUTAS.
        public DataTable mostrarRutas()
        {
            DataTable newTabla2 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM ruta";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            newTabla2.Load(leer);
            conexion.CerrarConexion();
            return newTabla2;
        }

        //CARGANDO LA TABLA PARA LAS RESERVACIONES
        public DataTable mostrarReservaciones() {
            DataTable newTabla3 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM reservaciones";
            comando.CommandType = CommanTyoe.Text;
            leer = comando.ExecuteReader();
            newTabla3.Load(leer);
            conexion.CerrarConexion();
            return newTabla3; 
        }
    }
}
