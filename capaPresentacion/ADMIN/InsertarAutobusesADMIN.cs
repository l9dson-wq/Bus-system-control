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
    public partial class InsertarAutobusesADMIN : Form
    {
        CN_ADMIN CA1 = new CN_ADMIN();

        //objetos para mover el formulario con un diseño = none
        Point start_point = new Point(0, 0);
        bool drag = false;

        public InsertarAutobusesADMIN()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InsertarAutobusesADMIN_Load(object sender, EventArgs e)
        {
            MAutobuses();
        }

        //HACIENDO UNA FUNCION PARA MOSTRAR LOS AUTOBUSES EN EL RECUADRO.
        private void MAutobuses()
        {
            CN_ADMIN CA2 = new CN_ADMIN();
            dataGridView1.DataSource = CA2.mostrarAutobuses();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //COLOCANDO EL CODIGO PARA ENVIAR LOS DATOS A LA CAPA DE NEGOCIO.
            if (txtMarca.Text.Length > 0 && txtModelo.Text.Length > 0 && txtPlaca.Text.Length > 0 && txtColor.Text.Length > 0 && txtYear.Text.Length > 0)
            {
                CA1.InsertarAutobuses(txtMarca.Text, txtModelo.Text, txtPlaca.Text, txtColor.Text, txtYear.Text);
                MessageBox.Show("El autobus se ha ingresado correctamente");
                MAutobuses();
                LimpiarText();
            }
            else {
                MessageBox.Show("Por favor no dejar los campos vacios");
            }
        }

        //FUNCION PARA LIMPIAR LOS CAMPOS.
        public void LimpiarText()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
            txtColor.Clear();
            txtYear.Clear();
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void InsertarAutobusesADMIN_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void InsertarAutobusesADMIN_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point P = PointToScreen(e.Location);
                this.Location = new Point(P.X - start_point.X, P.Y - start_point.Y);
            }
        }

        private void InsertarAutobusesADMIN_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
