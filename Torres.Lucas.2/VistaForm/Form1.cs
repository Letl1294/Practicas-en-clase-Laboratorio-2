using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class CrearPickUp : Form
    {
        public CrearPickUp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PickUp pickUp = new PickUp(txtPatente.Text,textModelo.Text);
            MessageBox.Show(pickUp.consultarDatos());
        }

        private void textModelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
