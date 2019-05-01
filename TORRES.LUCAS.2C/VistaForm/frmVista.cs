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
    public partial class Form1 : Form
    {
        Curso nuevoCurso;
        Profesor nuevoProfesor;
        Alumno nuevoAlumno;
        Divisiones divisionCurso;
        Divisiones divisionAlumno;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblAnioCurso_Click(object sender, EventArgs e)
        {

        }

        private void lblAnio_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblDivision_Click(object sender, EventArgs e)
        {

        }

        private void lblDivisionCurso_Click(object sender, EventArgs e)
        {

        }

        private void lblDocumento_Click(object sender, EventArgs e)
        {

        }

        private void lblDocumentoProfe_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisonCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void lblNombreProfe_Click(object sender, EventArgs e)
        {

        }

        private void lblApellidoProfe_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Enum.TryParse<Divisiones>(cmbDivision.SelectedValue.ToString(), out divisionAlumno);
            nuevoAlumno = new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text, (short)(nudAnio.Value), divisionAlumno);

            nuevoCurso += nuevoAlumno;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Enum.TryParse<Divisiones>(cmbDivisonCurso.SelectedValue.ToString(), out divisionCurso);
            nuevoProfesor = new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text, dtpFechaIngreso.Value);
            nuevoCurso = new Curso((short)(nudAnioCurso.Value), divisionCurso, nuevoProfesor);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (nuevoCurso == null)
            {
                MessageBox.Show("Error.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rtbDatos.Text = (string)nuevoCurso;
            }
        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gpbDatosAlumno_Enter(object sender, EventArgs e)
        {

        }

        private void gpbDatosCurso_Enter(object sender, EventArgs e)
        {

        }

        private void nudAnioCurso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudAnio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rtbDatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProfe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoProfe_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDivisonCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
