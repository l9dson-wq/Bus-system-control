using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class SUBmenuPRINCIPALadmin : Form
    {

        //HACIENDO LOS OBJETOS DE LOS OTROS FORMULARIOS.
        menuPrincipalAdmin MPA = new menuPrincipalAdmin();
        InsertarAutobusesADMIN IAA = new InsertarAutobusesADMIN();
        InsertarRutasADMIN IRA = new InsertarRutasADMIN();

        Form1 fm1 = new Form1();

        //objetos para mover el formulario con un diseño = none
        Point start_point = new Point(0, 0);
        bool drag = false;

        public SUBmenuPRINCIPALadmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SUBmenuPRINCIPALadmin_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MPA.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            IAA.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            IRA.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point P = PointToScreen(e.Location);
                this.Location = new Point(P.X - start_point.X, P.Y - start_point.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            fm1.Show();
        }

        private void SUBmenuPRINCIPALadmin_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void SUBmenuPRINCIPALadmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point P = PointToScreen(e.Location);
                this.Location = new Point(P.X - start_point.X, P.Y - start_point.Y);
            }
        }

        private void SUBmenuPRINCIPALadmin_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
