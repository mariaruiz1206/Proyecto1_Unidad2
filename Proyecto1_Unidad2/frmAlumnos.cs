using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

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
            if (txtNombre.Text == "" || txtApellidoP.Text == "" || txtApellidoM.Text == "")
            {
                MessageBox.Show("Completa los campos obligatorios");
                return;
            }

            string validar = $@"
                SELECT * FROM Alumnos 
                WHERE NumeroControl = '{txtNC.Text}';";

            var ds = datos.ejecutar(validar);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Ese número de control ya existe");
                return;
            }

            string query = $@"
    INSERT INTO Alumnos 
    (Nombre, ApellidoPaterno, ApellidoMaterno, NumeroControl, Grupo)
    VALUES 
    ('{txtNombre.Text}', '{txtApellidoP.Text}', '{txtApellidoM.Text}', '{txtNC.Text}', '{txtGrupo.Text}');";

            bool resultado = datos.ejecutarComando(query);

            if (resultado)
            {
                MessageBox.Show("Alumno agregado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar alumno");
            }

        }



        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            cargarAlumnos();
        }
        private void cargarAlumnos()
        {
            Datos d = new Datos();

            string query = "SELECT * FROM Alumnos;";
            dataGridView1.DataSource = d.ejecutarConsulta(query);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNC.Text == "")
            {
                MessageBox.Show("Selecciona un alumno");
                return;
            }

            Datos d = new Datos();

            string query = $@"
                DELETE FROM Alumnos 
                WHERE NumeroControl = '{txtNC.Text}';";

            bool resultado = d.ejecutarComando(query);

            if (resultado)
            {
                MessageBox.Show("Alumno eliminado");
                cargarAlumnos();
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtNC.Clear();
                txtGrupo.Clear();
            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(txtNC.Text == "")
            {
                MessageBox.Show("Selecciona un Alumno.");
                return;
            }
            Datos d = new Datos();
            string query = $@"
                UPDATE Alumnos 
                SET 
                    Nombre = '{txtNombre.Text}',
                    ApellidoPaterno = '{txtApellidoP.Text}',
                    ApellidoMaterno = '{txtApellidoM.Text}',
                    Grupo = '{txtGrupo.Text}'
                WHERE NumeroControl = '{txtNC.Text}';";

            bool resultado = d.ejecutarComando(query);

            if (resultado)
            {
                MessageBox.Show("Alumno actualizado");
                cargarAlumnos();
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtNC.Clear();
                txtGrupo.Clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtNC.Enabled = false;
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellidoP.Text = row.Cells["ApellidoPaterno"].Value.ToString();
                txtApellidoM.Text = row.Cells["ApellidoMaterno"].Value.ToString();
                txtNC.Text = row.Cells["NumeroControl"].Value.ToString();
                txtGrupo.Text = row.Cells["Grupo"].Value.ToString();
            }
        }

        private void btnLimpFilt_Click(object sender, EventArgs e)
        {
            txtNC.Enabled = true;
            txtNombre.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            txtNC.Clear();
            txtGrupo.Clear();
        }
    }
}

