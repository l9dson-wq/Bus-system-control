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
    public partial class InsertarRutasADMIN : Form
    {
        //CREANDO OBJETO DE LA CLASE CN_ADMIN DE LA CAPA DE NEGOCIOS
        CN_ADMIN CA1 = new CN_ADMIN();

        //objetos para mover el formulario con un diseño = none
        Point start_point = new Point(0, 0);
        bool drag = false;

        public InsertarRutasADMIN()
        {
            InitializeComponent();
            mostrarRutas();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void mostrarRutas() {
            CN_ADMIN CA2 = new CN_ADMIN();
            dataGridView1.DataSource = CA2.mostrarRutas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0) {
                CA1.InsertarRuta(txtNombre.Text);
                MessageBox.Show("Nombre de la ruta ingresado correctamente");
                mostrarRutas();
                LimpiarCampos();
            } else {
                MessageBox.Show("Por favor no deje los campos vacios");
            }
        }

        public void LimpiarCampos() {
            txtNombre.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertarRutasADMIN_Load(object sender, EventArgs e)
        {

        }

        private void InsertarRutasADMIN_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void InsertarRutasADMIN_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point P = PointToScreen(e.Location);
                this.Location = new Point(P.X - start_point.X, P.Y - start_point.Y);
            }
        }

        private void InsertarRutasADMIN_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
