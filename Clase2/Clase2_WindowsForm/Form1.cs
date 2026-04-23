namespace Clase2_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //al hacer click,cargar en la grilla los datos de licencia, empleado, cant de dias y area
            string tipoLicencia = txtTipoLicencia.Text;
            string nombreEmpleado = txtEmpleado.Text;

            if (string.IsNullOrEmpty(tipoLicencia) || string.IsNullOrEmpty(nombreEmpleado) || cmbDepartamento.SelectedIndex == -1 || cmbCantDias.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar la licencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string area = cmbDepartamento.SelectedItem.ToString();
            string cantDias = cmbCantDias.SelectedItem.ToString();

            dgvLicencias.Rows.Add(tipoLicencia, nombreEmpleado, area, cantDias);

            limpiarControles();

        }

        private void limpiarControles() 
        {
            txtTipoLicencia.Clear();
            txtEmpleado.Clear();
            cmbCantDias.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;
        }




    }
}
