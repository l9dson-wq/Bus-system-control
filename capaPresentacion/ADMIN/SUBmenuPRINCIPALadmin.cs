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

        public SUBmenuPRINCIPALadmin()
        {
            InitializeComponent();
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
    }
}
