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
        Point start_point = new Point(0, 0);
        bool drag = false;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
                        limpiarText();
                        //this.Show();
                    }
                    else if (CPL1.datoTipoUsuario == "comun")
                    {
                        this.Hide();
                        MR1.Show();
                        limpiarText();
                        //this.Show();
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

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point P = PointToScreen(e.Location);
                this.Location = new Point(P.X - start_point.X, P.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        //funcion para limpiar los textbox
        private void limpiarText() {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point P = PointToScreen(e.Location);
                this.Location = new Point(P.X - start_point.X, P.Y - start_point.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
