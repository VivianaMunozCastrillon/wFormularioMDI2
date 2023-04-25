using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///Nombres:Viviana Muñoz Castriilon, Laura Serena Rivera Mejia
///Fecha:24/04/2023
///Descripcion:Este programa registra los datos personales y academicos de los estudiantes atraves de menustrip
///y botones desde el formulario.
namespace wFormularioMDI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Llama al formulario datos academicos
            frmDatosAcademicos FrmDatosAcademicos = new frmDatosAcademicos();
            FrmDatosAcademicos.MdiParent = this;
            FrmDatosAcademicos.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosAcademicosToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Llama al formulario datos estudiantes
            frmDatosEstudiante FrmDatosEstudiante = new frmDatosEstudiante ();
            FrmDatosEstudiante.MdiParent = this;
            FrmDatosEstudiante.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDatos = this.ActiveMdiChild;
            if (frmDatos != null)
            {
                frmDatos.Close();
            }
        }
    }
}
