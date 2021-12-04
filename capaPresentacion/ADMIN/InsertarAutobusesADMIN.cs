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
        public InsertarAutobusesADMIN()
        {
            InitializeComponent();
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
    }
}
