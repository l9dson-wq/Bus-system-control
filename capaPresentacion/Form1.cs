using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using capaNegocio;

namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //----RIGISTER
            registro r1 = new registro();
            this.Hide();
            r1.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crear un objeto para el formulario que tiene el menu principal (admin/usuario).
            menuPrincipalAdmin MPA = new menuPrincipalAdmin();
            menuReservacion MR1 = new menuReservacion();
            SUBmenuPRINCIPALadmin SMPA = new SUBmenuPRINCIPALadmin();

            //crear un objeto de capa de negocios.
            CPlogicaInicioSesion CPL1 = new CPlogicaInicioSesion();


            //Verifico que los campos no esten vacios.
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                bool bandera = false;

                //mando a llamar la funcion buscarUsuario alojada en la capa de negocio.
                bandera = CPL1.buscarUsuario(textBox1.Text, textBox2.Text);

                if (bandera) //Si se encuentran los datos se ejecutara la siguiente parte del codigo.
                {
                    MessageBox.Show("Genial los datos estan correcto, puede continuar!");
                    if (CPL1.datoTipoUsuario == "admin")
                    {
                        this.Hide();
                        SMPA.ShowDialog();
                        this.Show();
                    }
                    else if (CPL1.datoTipoUsuario == "comun")
                    {
                        this.Hide();
                        MR1.ShowDialog();
                        this.Show();
                    }
                    else {
                        MessageBox.Show("Lo siento pero no tienes acceso como usuario ni administrador");
                    }
                }
                else {
                    MessageBox.Show("Lo sentimos pero no pudimos encontrar los datos suministrados");
                }
            }
            else {
                MessageBox.Show("Por favor introducir los datos antes de seguir");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
