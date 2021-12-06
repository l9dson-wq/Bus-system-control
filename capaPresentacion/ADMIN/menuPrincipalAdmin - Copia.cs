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
    public partial class menuPrincipalAdmin : Form
    {
        CPlogicaInicioSesion CPL1 = new CPlogicaInicioSesion();
        CN_ADMIN ca1 = new CN_ADMIN();
        Form1 Fo1 = new Form1();
        public string estadoUsuario = null;

        //objetos para mover el formulario con un diseño = none
        Point start_point = new Point(0, 0);
        bool drag = false;

        public menuPrincipalAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void menuPrincipalAdmin_Load(object sender, EventArgs e)
        {
            //mostrando la lista de los choferes en la tabla para los adminsitradores.

            mostrarChoferes();
        }

        private void mostrarChoferes() {
            CN_ADMIN ca2 = new CN_ADMIN();
            dataGridView1.DataSource = ca2.MostarChoferes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtFecha.Text != "" && txtCedula.Text != "")
            {
                ca1.InsertarChoferes(txtNombre.Text, txtApellido.Text, txtFecha.Text, txtCedula.Text);
                MessageBox.Show("Chofer ingresado correctamente!");
                mostrarChoferes();
                LimpiarText();
            }
            else
            {
                MessageBox.Show("Por favor no dejar los campos vacios");
            }
        }

        public void LimpiarText() {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFecha.Text = "";
            txtCedula.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuPrincipalAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void menuPrincipalAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point P = PointToScreen(e.Location);
                this.Location = new Point(P.X - start_point.X, P.Y - start_point.Y);
            }
        }

        private void menuPrincipalAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
