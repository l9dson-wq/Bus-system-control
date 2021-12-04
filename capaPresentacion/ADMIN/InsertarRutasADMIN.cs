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
        public InsertarRutasADMIN()
        {
            InitializeComponent();
            mostrarRutas();
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
                LimpiarCampos();
            } else {
                MessageBox.Show("Por favor no deje los campos vacios");
            }
        }

        public void LimpiarCampos() {
            txtNombre.Clear();
        }
    }
}
