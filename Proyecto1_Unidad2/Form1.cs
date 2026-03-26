using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Proyecto1_Unidad2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos alumnos = new frmAlumnos();
            alumnos.ShowDialog();

        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsistencia asistencia = new frmAsistencia();
            asistencia.ShowDialog();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos con = new Datos();

            try
            {
                var ds = con.ejecutar("SELECT 1");

                if (ds != null)
                {
                    MessageBox.Show("Conexión exitosa ✅");
                }
                else
                {
                    MessageBox.Show("Error en la conexión ❌");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
