using Entidades;

namespace Servicios
{
    //Creamos la interfaz de la clase servicio
    public interface IHerramientaServicio
    {
        List<Herramienta> ObtenerHerramientas();
        void AgregarHerramienta(Herramienta herramienta);
        void EliminarHerramienta(int id);


    }


    //_herramientas: con _ para variables privadas
    public class HerramientaServicio: IHerramientaServicio
    {
        private static List<Herramienta> _herramientas;
        private static int _idContador = 3;

        public HerramientaServicio()
        {
            _herramientas = new List<Herramienta>();

            _herramientas.Add(new Herramienta { Id = 1, Descripcion = "Martilllo", Precio = 12.10m, Imagen = "\\imagenes\\martillo.jpg" });
            _herramientas.Add(new Herramienta { Id = 2, Descripcion= "Destornillador", Precio = 33.2m, Imagen = "\\imagenes\\destornillador.jpg" });
        }

        public List<Herramienta> ObtenerHerramientas()
        {
            return _herramientas;
        }

        public void AgregarHerramienta(Herramienta herramienta)
        {
            herramienta.Id = _idContador++;

            if (string.IsNullOrEmpty(herramienta.Imagen))
            {
                herramienta.Imagen = "\\imagenes\\sinImagen.jpg";

            }
            else
            {
                herramienta.Imagen = "\\imagenes\\" + herramienta.Imagen;
            }
            _herramientas.Add(herramienta);
        }

        public Herramienta BuscarHerramientaPorId(int id) {
            return _herramientas.FirstOrDefault(buscado => buscado.Id == id);
        }

        public void EliminarHerramienta(int id)
        {
            var herramienta = BuscarHerramientaPorId(id);
            if(herramienta!= null)
            {
                _herramientas.Remove(herramienta);
            }
        }
    }
}
