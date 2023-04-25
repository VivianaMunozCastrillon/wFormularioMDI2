using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wFormularioMDI2
{
    public partial class frmDatosEstudiante : Form
    {
        public frmDatosEstudiante()
        {
            InitializeComponent();
        }

        private void Datos_Estudiante_Load(object sender, EventArgs e)
        {
            //Desactiva los botones guardar al iniciar la compilacion.
            btnGuardar.Enabled = false;
            guardarMenu.Enabled = false;


        }
        //Metodo para validar si los campos estan vacios y no permite guardar hasta que todos
        //esten diligenciados
        private void validarCampo()

        {
       
            var validacion = !string.IsNullOrEmpty(txtNombre.Text) &&
            !string.IsNullOrEmpty(txtApellido.Text) &&
            !string.IsNullOrEmpty(txtNumDocumento.Text) &&
            !string.IsNullOrEmpty(cboDocumento.Text) &&
            !string.IsNullOrEmpty(cboCiudad.Text) &&
            !string.IsNullOrEmpty(cboSexo.Text);
            btnGuardar.Enabled = validacion;
            guardarMenu.Enabled = validacion;

        }

        private void limpiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {   
            //Instruccion de limpiar desde el menu
            txtApellido.Clear();
            txtNombre.Clear();
            txtNumDocumento.Clear();
            cboDocumento.ResetText();
            cboSexo.ResetText();
            cboCiudad.ResetText();
            btnGuardar.Enabled = false;
            guardarMenu.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //instruccion para limpiar desde el boton
            txtApellido.Clear();
            txtNombre.Clear();
            txtNumDocumento.Clear();
            cboDocumento.ResetText();
            cboSexo.ResetText();
            cboCiudad.ResetText();
            btnGuardar.Enabled = false;
            guardarMenu.Enabled=false;
        }

       

        private void button1_Click(object sender, EventArgs e)

        {
            //Captura los datos de entrada
           string nombre=txtNombre.Text;
           string apellido=txtApellido.Text;
            //Bloque try-catch que intenta un bloque de codigo, si sale error, envia un mensaje 
            //de salida y no detiene la compilacion
            try
            {   //Captura los datos de entrada
                int numeroDocumento = Convert.ToInt32(txtNumDocumento.Text);
                int sexo = cboSexo.SelectedIndex;
                int ciudad = cboCiudad.SelectedIndex;
                //Mensaje de salida
                MessageBox.Show(nombre + " tu registro ha sido exitoso","Registro Exitoso",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                //Mensaje de salida
                MessageBox.Show("Ingrese los datos correctamente", "Registro fallido",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

           

            

            



        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cboDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtNumDocumento_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void guardarMenu_Click(object sender, EventArgs e)
        {
            //Captura los datos de entrada
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            //Bloque try-catch que intenta un bloque de codigo, si sale error, envia un mensaje 
            //de salida y no detiene la compilacion
            try
            {   //Captura los datos de entrada
                int numeroDocumento = Convert.ToInt32(txtNumDocumento.Text);
                int sexo = cboSexo.SelectedIndex;
                int ciudad = cboCiudad.SelectedIndex;
                //Mensaje de salida
                MessageBox.Show(nombre + " tu registro ha sido exitoso", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                //Mensaje de salida
                MessageBox.Show("Ingrese los datos correctamente", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
