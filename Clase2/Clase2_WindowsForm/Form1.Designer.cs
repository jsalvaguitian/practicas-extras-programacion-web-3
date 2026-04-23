namespace Clase2_WindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpLicencias = new GroupBox();
            lblDiasSolicitados = new Label();
            cmbCantDias = new ComboBox();
            lblTipoLicencia = new Label();
            txtTipoLicencia = new TextBox();
            grpEmpleados = new GroupBox();
            lblDepartamento = new Label();
            cmbDepartamento = new ComboBox();
            lblEmpleado = new Label();
            txtEmpleado = new TextBox();
            btnRegistrar = new Button();
            dgvLicencias = new DataGridView();
            TipoLicencia = new DataGridViewTextBoxColumn();
            NombreEmpleado = new DataGridViewTextBoxColumn();
            Area = new DataGridViewTextBoxColumn();
            CantidadDias = new DataGridViewTextBoxColumn();
            grpLicencias.SuspendLayout();
            grpEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLicencias).BeginInit();
            SuspendLayout();
            // 
            // grpLicencias
            // 
            grpLicencias.Controls.Add(lblDiasSolicitados);
            grpLicencias.Controls.Add(cmbCantDias);
            grpLicencias.Controls.Add(lblTipoLicencia);
            grpLicencias.Controls.Add(txtTipoLicencia);
            grpLicencias.Location = new Point(27, 12);
            grpLicencias.Name = "grpLicencias";
            grpLicencias.Size = new Size(366, 131);
            grpLicencias.TabIndex = 0;
            grpLicencias.TabStop = false;
            grpLicencias.Text = "Licencias";
            // 
            // lblDiasSolicitados
            // 
            lblDiasSolicitados.AutoSize = true;
            lblDiasSolicitados.Location = new Point(0, 96);
            lblDiasSolicitados.Name = "lblDiasSolicitados";
            lblDiasSolicitados.Size = new Size(120, 15);
            lblDiasSolicitados.TabIndex = 3;
            lblDiasSolicitados.Text = "Cant. Dias Solicitados";
            // 
            // cmbCantDias
            // 
            cmbCantDias.FormattingEnabled = true;
            cmbCantDias.Items.AddRange(new object[] { "1 día", "7 días", "14 días", "21 días" });
            cmbCantDias.Location = new Point(165, 93);
            cmbCantDias.Name = "cmbCantDias";
            cmbCantDias.Size = new Size(187, 23);
            cmbCantDias.TabIndex = 2;
            // 
            // lblTipoLicencia
            // 
            lblTipoLicencia.AutoSize = true;
            lblTipoLicencia.Location = new Point(0, 34);
            lblTipoLicencia.Name = "lblTipoLicencia";
            lblTipoLicencia.Size = new Size(89, 15);
            lblTipoLicencia.TabIndex = 1;
            lblTipoLicencia.Text = "Tipo de licencia";
            // 
            // txtTipoLicencia
            // 
            txtTipoLicencia.Location = new Point(0, 52);
            txtTipoLicencia.Name = "txtTipoLicencia";
            txtTipoLicencia.Size = new Size(352, 23);
            txtTipoLicencia.TabIndex = 0;
            // 
            // grpEmpleados
            // 
            grpEmpleados.Controls.Add(lblDepartamento);
            grpEmpleados.Controls.Add(cmbDepartamento);
            grpEmpleados.Controls.Add(lblEmpleado);
            grpEmpleados.Controls.Add(txtEmpleado);
            grpEmpleados.Location = new Point(408, 12);
            grpEmpleados.Name = "grpEmpleados";
            grpEmpleados.Size = new Size(365, 131);
            grpEmpleados.TabIndex = 1;
            grpEmpleados.TabStop = false;
            grpEmpleados.Text = "Empleados";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(0, 93);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(83, 15);
            lblDepartamento.TabIndex = 4;
            lblDepartamento.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Items.AddRange(new object[] { "Marketing", "Sistemas", "Recursos Humanos" });
            cmbDepartamento.Location = new Point(165, 93);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(187, 23);
            cmbDepartamento.TabIndex = 3;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(0, 34);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(60, 15);
            lblEmpleado.TabIndex = 2;
            lblEmpleado.Text = "Empleado";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(0, 52);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(352, 23);
            txtEmpleado.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.Location = new Point(27, 141);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(366, 33);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvLicencias
            // 
            dgvLicencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLicencias.Columns.AddRange(new DataGridViewColumn[] { TipoLicencia, NombreEmpleado, Area, CantidadDias });
            dgvLicencias.Location = new Point(27, 184);
            dgvLicencias.Name = "dgvLicencias";
            dgvLicencias.Size = new Size(746, 150);
            dgvLicencias.TabIndex = 3;
            dgvLicencias.TabStop = false;
            // 
            // TipoLicencia
            // 
            TipoLicencia.HeaderText = "Tipo Licencia";
            TipoLicencia.Name = "TipoLicencia";
            // 
            // NombreEmpleado
            // 
            NombreEmpleado.HeaderText = "Nombre Empleado";
            NombreEmpleado.Name = "NombreEmpleado";
            NombreEmpleado.Width = 300;
            // 
            // Area
            // 
            Area.HeaderText = "Area/Departamento";
            Area.Name = "Area";
            // 
            // CantidadDias
            // 
            CantidadDias.HeaderText = "Cantidad de Días";
            CantidadDias.Name = "CantidadDias";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvLicencias);
            Controls.Add(btnRegistrar);
            Controls.Add(grpEmpleados);
            Controls.Add(grpLicencias);
            Name = "Form1";
            Text = "Form1";
            grpLicencias.ResumeLayout(false);
            grpLicencias.PerformLayout();
            grpEmpleados.ResumeLayout(false);
            grpEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLicencias).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private GroupBox grpLicencias;
        private GroupBox grpEmpleados;
        private TextBox txtTipoLicencia;
        private TextBox txtEmpleado;
        private Button btnRegistrar;
        private Label lblTipoLicencia;
        private Label lblEmpleado;
        private ComboBox cmbCantDias;
        private ComboBox cmbDepartamento;
        private Label lblDiasSolicitados;
        private Label lblDepartamento;
        private DataGridView dgvLicencias;
        private DataGridViewTextBoxColumn TipoLicencia;
        private DataGridViewTextBoxColumn NombreEmpleado;
        private DataGridViewTextBoxColumn Area;
        private DataGridViewTextBoxColumn CantidadDias;
    }
}
