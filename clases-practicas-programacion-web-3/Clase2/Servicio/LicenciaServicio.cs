using Entidad;

namespace Servicio
{
    //La interfaz Servicio
    public interface ILicenciaServicio
    {
        void RegistrarLicencia(Entidad.Licencia licencia);
        List<Entidad.Licencia> ObtenerLicencias();

    }

    //La clase Servicio
    public class LicenciaServicio : ILicenciaServicio
    {
        private List<Entidad.Licencia> licencias;

        public LicenciaServicio()
        {
            licencias = new List<Licencia>();
        }

        public void RegistrarLicencia(Entidad.Licencia licencia)
        {
            licencias.Add(licencia);
        }

        public List<Entidad.Licencia> ObtenerLicencias()
        {
            return licencias;
        }

    }
}
