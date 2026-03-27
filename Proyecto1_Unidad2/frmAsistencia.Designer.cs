namespace Proyecto1_Unidad2
{
    partial class frmAsistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            CBGrupos = new ComboBox();
            txtNC = new TextBox();
            btnRegistrar = new Button();
            lblRegistro = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(CBGrupos);
            splitContainer1.Panel1.Controls.Add(txtNC);
            splitContainer1.Panel1.Controls.Add(btnRegistrar);
            splitContainer1.Panel1.Controls.Add(lblRegistro);
            splitContainer1.Panel1.Controls.Add(dtpFecha);
            splitContainer1.Panel1.Controls.Add(lblFecha);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 232;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(465, 22);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 8;
            label1.Text = "Grupo:";
            // 
            // CBGrupos
            // 
            CBGrupos.FormattingEnabled = true;
            CBGrupos.Items.AddRange(new object[] { "A", "B", "C" });
            CBGrupos.Location = new Point(467, 62);
            CBGrupos.Name = "CBGrupos";
            CBGrupos.Size = new Size(182, 33);
            CBGrupos.TabIndex = 7;
            CBGrupos.SelectedIndexChanged += CBGrupos_SelectedIndexChanged;
            // 
            // txtNC
            // 
            txtNC.Location = new Point(54, 173);
            txtNC.Name = "txtNC";
            txtNC.Size = new Size(337, 31);
            txtNC.TabIndex = 6;
            txtNC.TextChanged += txtNC_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(467, 170);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(51, 122);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(235, 25);
            lblRegistro.TabIndex = 2;
            lblRegistro.Text = "Agregar Número de Control";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(44, 64);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(347, 31);
            dtpFecha.TabIndex = 1;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(44, 23);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(66, 25);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(800, 214);
            dataGridView1.TabIndex = 0;
            // 
            // frmAsistencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmAsistencia";
            Text = "frmAsistencia";
            Load += frmAsistencia_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox textBox1;
        private Label lblRegistro;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private DataGridView dataGridView1;
        private Button btnRegistrar;
        private TextBox txtNC;
        private ComboBox CBGrupos;
        private Label label1;
    }
}