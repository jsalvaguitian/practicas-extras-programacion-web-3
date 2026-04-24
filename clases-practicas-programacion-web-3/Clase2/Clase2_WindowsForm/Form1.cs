using Entidad;

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

            Licencia licencia = new Licencia
            {
                TipoLicencia = tipoLicencia,
                NombreEmpleado = nombreEmpleado,
                Area = area,
                CantidadDias = cantDias

            };

            enviarResultadosAPI(licencia);

            //cargarGrilla(licencia);

            limpiarControles();

        }

        private void limpiarControles()
        {
            txtTipoLicencia.Clear();
            txtEmpleado.Clear();
            cmbCantDias.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;
        }

        private void cargarGrilla(Licencia licencia)
        {
            dgvLicencias.Rows.Add(licencia.TipoLicencia, licencia.NombreEmpleado, licencia.Area, licencia.CantidadDias);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            obtenerResultadosAPI();
        }

        //desde api obtener resultado de licencias
        private async Task obtenerResultadosAPI()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync("https://localhost:7119/api/Licencia");
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        var licencias = System.Text.Json.JsonSerializer.Deserialize<List<Licencia>>(jsonResponse, new System.Text.Json.JsonSerializerOptions {PropertyNameCaseInsensitive=true});

                        dgvLicencias.Rows.Clear();

                        foreach (var licencia in licencias)
                        {
                            cargarGrilla(licencia);

                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error al obtener resultados de la API: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(HttpRequestException ex)
                {
                    MessageBox.Show($"Error al obtener resultados de la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //los datos completados desde el formulario lo enviamos a la api
        private async Task enviarResultadosAPI(Licencia licencia)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var jsonContent = new StringContent(System.Text.Json.JsonSerializer.Serialize(licencia), System.Text.Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("https://localhost:7119/api/Licencia", jsonContent);

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Error al enviar resultados a la API: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (HttpRequestException ex) {
                    MessageBox.Show($"Error al enviar resultados a la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }
    }
}
