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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //----Getting the value
            string display = this.comboBox1.Text;
            MessageBox.Show("Values = " + display);
        }
    }
}
