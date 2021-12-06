using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace capaPresentacion
{
    public partial class menuReservacion : Form
    {
        CN_reservacion CNR1 = new CN_reservacion();

        //objeto de la capa logica de inicio de sesion
        CPlogicaInicioSesion CLIS1 = new CPlogicaInicioSesion();

        //objetos para mover el formulario con un diseño = none
        Point start_point = new Point(0, 0);
        bool drag = false;

        //objeto del formulario principal
        Form1 FM1 = new Form1();

        public string datoReservante = null;

        public menuReservacion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void menuReservacion_Load(object sender, EventArgs e)
        {

            //mostrar las reservaciones
            mostrarReservaciones();

            //datos de los comboBox
            mostrarComboDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (comboChoferes.Text.Length > 0 && comboAutobuses.Text.Length > 0 && comboRuta.Text.Length > 0)
            {
                CNR1.InsertarReservacion(comboChoferes.Text, comboAutobuses.Text, comboRuta.Text);
                CNR1.EliminarDatos(comboChoferes.Text, comboAutobuses.Text, comboRuta.Text);
                //this.Close();
                //FM1.Show();
                MessageBox.Show("Reserva realizada con exito, vuelva a iniciar sesion para comprobar!");
            }
            else {
                MessageBox.Show("Por favor seleccione los valores correctamente antes de continuar");
            }
            
        }

        public void mostrarComboDatos() {

            //Mostrando los nombres  de los choferes en el comboBox
            comboChoferes.DataSource = CNR1.MostarNombresChoferes();
            comboChoferes.DisplayMember = "nombreChoferes";
            comboChoferes.ValueMember = "idChoferes";

            //mostrando las marcas de los autobuses en el combobox
            comboAutobuses.DataSource = CNR1.MostrarNombreAutobuses();
            comboAutobuses.DisplayMember = "marcaAutobus";
            comboAutobuses.ValueMember = "idAutobuses";


            //mostrando el nombre de las rutas en el comboBox
            comboRuta.DataSource = CNR1.MostrarNombreRutas();
            comboRuta.DisplayMember = "nombreRura";
            comboRuta.ValueMember = "idRuta";
        }

        public void mostrarReservaciones() {
            CN_reservacion CN2 = new CN_reservacion();
            dataGridView1.DataSource = CN2.MostrarReservaciones();
        }

        public void limpiarComboBox() {
            comboAutobuses.DisplayMember = "";
            comboChoferes.DisplayMember = "";
            comboRuta.DisplayMember = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FM1.Show();
        }

        private void menuReservacion_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void menuReservacion_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point P = PointToScreen(e.Location);
                this.Location = new Point(P.X - start_point.X, P.Y - start_point.Y);
            }
        }

        private void menuReservacion_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }
    }
}
