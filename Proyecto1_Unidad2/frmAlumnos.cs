using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto1_Unidad2
{
    public partial class frmAlumnos : Form
    {
        Datos datos = new Datos();
        bool updating = false;
        int id = 0;
        public frmAlumnos()
        {
            InitializeComponent();
        }
        public frmAlumnos(int idAlumnos, String Nombre, String ApellidoPaterno, String ApellidoMaterno, int NumeroControl, String Grupos)
        {
            InitializeComponent();
            this.id = id;
            txtNombre.Text = Nombre;
            txtApellidoP.Text = ApellidoPaterno;
            txtApellidoM.Text = ApellidoMaterno;
            txtNC.Text = NumeroControl.ToString();
            txtGrupo.Text = Grupos;
            updating = true;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado = datos.ejecutarComando(
            $"Insert into Alumnos (Nombre,ApellidoPaterno,ApellidoMaterno,NumeroControl,Grupos) " +
            $"values ('{txtNombre.Text}','{txtApellidoP.Text}','{txtApellidoM.Text}',{txtNC.Text},'{txtGrupo}')");

            if (resultado)
            {
                MessageBox.Show("Alumno agregada correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar el Alumno");
            }
        }

   
    }
}

