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
    public partial class registro : Form
    {
        CPlogicaInicioSesion CLIS1 = new CPlogicaInicioSesion();

        //objetos para mover el formulario con un diseño = none
        Point start_point = new Point(0, 0);
        bool drag = false;

        public registro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //----Getting the value
            //string display = this.comboBox1.Text;

            if (txtNombre.Text.Length > 0 && txtClave.Text.Length > 0 && comboBox1.Text.Length > 0)
            {
                bool bandera = false;
                bandera = CLIS1.compararUsuarioRegistro(txtNombre.Text);
                if (bandera)
                {
                    MessageBox.Show("Lo siento pero ese nombre de usuario ya esta registrado");
                }
                else
                {
                    CLIS1.insertarUsuarioRegistro(txtNombre.Text, txtClave.Text, comboBox1.Text);
                    MessageBox.Show("Usuario registrado con exito");
                    limpiarText();
                }
            }
            else {
                MessageBox.Show("No puede dejar los campos vacios, favor llenarlos todos!");
            }
        }

        private void registro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiarText() {
            txtNombre.Clear();
            txtClave.Clear();
            comboBox1.Text = ""; 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void registro_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void registro_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point P = PointToScreen(e.Location);
                this.Location = new Point(P.X - start_point.X, P.Y - start_point.Y);
            }
        }

        private void registro_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
