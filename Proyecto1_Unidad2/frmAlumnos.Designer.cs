namespace Proyecto1_Unidad2
{
    partial class frmAlumnos
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
            lblNombre = new Label();
            lblApellidoP = new Label();
            lblApellidoM = new Label();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            txtApellidoP = new TextBox();
            txtApellidoM = new TextBox();
            txtNC = new TextBox();
            lblNC = new Label();
            lblGrupo = new Label();
            txtGrupo = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(39, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellidoP
            // 
            lblApellidoP.AutoSize = true;
            lblApellidoP.Location = new Point(277, 27);
            lblApellidoP.Name = "lblApellidoP";
            lblApellidoP.Size = new Size(147, 25);
            lblApellidoP.TabIndex = 1;
            lblApellidoP.Text = "Apellido Paterno:";
            // 
            // lblApellidoM
            // 
            lblApellidoM.AutoSize = true;
            lblApellidoM.Location = new Point(534, 27);
            lblApellidoM.Name = "lblApellidoM";
            lblApellidoM.Size = new Size(154, 25);
            lblApellidoM.TabIndex = 2;
            lblApellidoM.Text = "Apellido Materno:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(538, 201);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar:";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(39, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 31);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellidoP
            // 
            txtApellidoP.Location = new Point(277, 89);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(235, 31);
            txtApellidoP.TabIndex = 6;
            txtApellidoP.TextChanged += txtApellidoP_TextChanged;
            // 
            // txtApellidoM
            // 
            txtApellidoM.Location = new Point(538, 89);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(229, 31);
            txtApellidoM.TabIndex = 7;
            txtApellidoM.TextChanged += txtApellidoM_TextChanged;
            // 
            // txtNC
            // 
            txtNC.Location = new Point(39, 203);
            txtNC.Name = "txtNC";
            txtNC.Size = new Size(150, 31);
            txtNC.TabIndex = 8;
            txtNC.TextChanged += txtNC_TextChanged;
            // 
            // lblNC
            // 
            lblNC.AutoSize = true;
            lblNC.Location = new Point(46, 159);
            lblNC.Name = "lblNC";
            lblNC.Size = new Size(175, 25);
            lblNC.TabIndex = 9;
            lblNC.Text = "Numero de Control: ";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(298, 161);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(66, 25);
            lblGrupo.TabIndex = 10;
            lblGrupo.Text = "Grupo:";
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(298, 201);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(150, 31);
            txtGrupo.TabIndex = 11;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtGrupo);
            Controls.Add(lblGrupo);
            Controls.Add(lblNC);
            Controls.Add(txtNC);
            Controls.Add(txtApellidoM);
            Controls.Add(txtApellidoP);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(lblApellidoM);
            Controls.Add(lblApellidoP);
            Controls.Add(lblNombre);
            Name = "frmAlumnos";
            Text = "frmAlumnos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellidoP;
        private Label lblApellidoM;
        private Label label4;
        private Button btnAgregar;
        private TextBox txtNombre;
        private TextBox txtApellidoP;
        private TextBox txtApellidoM;
        private TextBox txtNC;
        private Label lblNC;
        private Label lblGrupo;
        private TextBox txtGrupo;
    }
}