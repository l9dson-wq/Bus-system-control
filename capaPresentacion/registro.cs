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

        public registro()
        {
            InitializeComponent();
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
    }
}
