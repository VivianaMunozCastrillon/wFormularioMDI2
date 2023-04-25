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
    public partial class frmDatosAcademicos : Form
    {
        public frmDatosAcademicos()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {   //Metodo que valida cada radio button  y textbox
            validarCampo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Ciclos logicos
            if (rdbBaseDatos.Checked == true && rdbActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de base de datos " +
                    "y se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (rdbCalculo.Checked == true && rdbActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de calculo " +
                    "y se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            if (rdbInteligenciaArtificial.Checked == true && rdbActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de inteligencia artificial" +
                    " y se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            if (rdbSeguridadInformatica.Checked == true && rdbActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de seguridad informatica " +
                    "y se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            if (rdbBaseDatos.Checked == true && rdbNoActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de base de datos y " +
                    "no se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


            if (rdbCalculo.Checked == true && rdbNoActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de calculo" +
                    " y no se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }


            if (rdbInteligenciaArtificial.Checked == true && rdbNoActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de inteligencia artificial" +
                    " y  no se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


            if (rdbSeguridadInformatica.Checked == true && rdbNoActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de seguridad informatica " +
                    "y  no se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Instruccion para limpiar desde el boton
            rdbBaseDatos.Checked = false;
            rdbCalculo.Checked = false;
            rdbInteligenciaArtificial.Checked = false;
            rdbSeguridadInformatica.Checked = false;
            rdbActivo.Checked = false;
            rdbNoActivo.Checked = false;
            cboSemestre.ResetText();
            btnGuardar.Enabled = false;
            guardarMenu2.Enabled = false;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instruccion para limpiar desde el menu
            rdbBaseDatos.Checked = false;
            rdbCalculo.Checked = false;
            rdbInteligenciaArtificial.Checked = false;
            rdbSeguridadInformatica.Checked = false;
            rdbActivo.Checked = false;
            rdbNoActivo.Checked = false;
            cboSemestre.ResetText();
            btnGuardar.Enabled = false;
            guardarMenu2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Cierra el formulario
            this.Close();
        }

        private void cboSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void frmDatosAcademicos_Load(object sender, EventArgs e)
        {
            //Desactiva los botones guardar al iniciar la compilacion.
            btnGuardar.Enabled = false;
            guardarMenu2.Enabled = false;


        }
        //Metodo para validar si los campos estan vacios y no permite guardar hasta que todos
        //esten diligenciados
        private void validarCampo()
        {   
            var validacion = !string.IsNullOrEmpty(cboSemestre.Text) &&
            !string.IsNullOrEmpty(rdbActivo.Text) &&
            !string.IsNullOrEmpty(rdbNoActivo.Text) &&
            !string.IsNullOrEmpty(rdbBaseDatos.Text) &&
            !string.IsNullOrEmpty(rdbCalculo.Text) &&
            !string.IsNullOrEmpty(rdbInteligenciaArtificial.Text)&&
            !string.IsNullOrEmpty(rdbSeguridadInformatica.Text);
            btnGuardar.Enabled = validacion;
            guardarMenu2.Enabled = validacion;


        }

        private void rdbCalculo_CheckedChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void rdbInteligenciaArtificial_CheckedChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void rdbSeguridadInformatica_CheckedChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void rdbActivo_CheckedChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void rdbNoActivo_CheckedChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guardarMenu2_Click(object sender, EventArgs e)
        {
            //Ciclos logicos
            if (rdbBaseDatos.Checked == true && rdbActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de base de datos " +
                    "y se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (rdbCalculo.Checked == true && rdbActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de calculo " +
                    "y se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            if (rdbInteligenciaArtificial.Checked == true && rdbActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de inteligencia artificial" +
                    " y se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            if (rdbSeguridadInformatica.Checked == true && rdbActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de seguridad informatica " +
                    "y se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            if (rdbBaseDatos.Checked == true && rdbNoActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de base de datos y " +
                    "no se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


            if (rdbCalculo.Checked == true && rdbNoActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de calculo" +
                    " y no se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }


            if (rdbInteligenciaArtificial.Checked == true && rdbNoActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de inteligencia artificial" +
                    " y  no se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


            if (rdbSeguridadInformatica.Checked == true && rdbNoActivo.Checked == true)
            {
                //Obtiene el valor tipo string del combobox
                string matricula = cboSemestre.SelectedItem.ToString();
                MessageBox.Show("Su registro ha sido exitoso, cursa la materia de seguridad informatica " +
                    "y  no se encuentra activo en el semestre " + matricula, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }
    }
}
