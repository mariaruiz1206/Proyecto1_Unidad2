using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto1_Unidad2
{
    public partial class frmAsistencia : Form
    {
        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void txtNumC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNC.Text == "" || CBGrupos.Text == "")
            {
                MessageBox.Show("Ingresa número de control y selecciona grupo");
                return;
            }

            Datos d = new Datos();

            string numero = txtNC.Text;
            string grupo = CBGrupos.Text;
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            string validarAlumno = $@"
                SELECT * FROM Alumnos 
                WHERE NumeroControl = '{numero}';";

            var alumno = d.ejecutar(validarAlumno);

            if (alumno.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("El alumno no existe");
                return;
            }

            string verificar = $@"
                SELECT * FROM Asistencia 
                WHERE NumeroControl = '{numero}' 
                AND Fecha = '{fecha}';";

            var ds = d.ejecutar(verificar);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Ese alumno ya tiene asistencia en esa fecha");
                return;
            }

            string query = $@"
                INSERT INTO Asistencia (Fecha, NumeroControl, Presente, Grupos)
                VALUES ('{fecha}', '{numero}', 1, '{grupo}');";

            bool resultado = d.ejecutarComando(query);

            if (resultado)
            {
                MessageBox.Show("Asistencia registrada");

                cargarAsistencia();

                txtNC.Clear();
                txtNC.Focus();
            }
            else
            {
                MessageBox.Show("Error al registrar asistencia");
            }
        }


        private void btnAsistencia_Click(object sender, EventArgs e)
        {

        }

        private void txtNC_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarAsistencia()
        {
            try
            {
                if (CBGrupos.Text == "") return;

                Datos d = new Datos();

                string grupo = CBGrupos.Text;
                string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

                string query = $@"
                SELECT 
                    a.Nombre,
                    a.ApellidoPaterno,
                    a.ApellidoMaterno,
                    a.NumeroControl,
                    a.Grupo,
                    IFNULL(asist.Presente, 0) AS Presente
                FROM Alumnos a
                LEFT JOIN Asistencia asist 
                    ON a.NumeroControl = asist.NumeroControl 
                    AND asist.Fecha = '{fecha}'
                WHERE a.Grupo = '{grupo}';";

                dataGridView1.DataSource = d.ejecutarConsulta(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
        }

        private void CBGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarAsistencia();

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            cargarAsistencia();
        }
    }

}
