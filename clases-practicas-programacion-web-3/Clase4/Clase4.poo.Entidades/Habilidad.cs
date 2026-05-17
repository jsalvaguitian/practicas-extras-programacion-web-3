namespace Clase4.poo.Entidades;

public interface IHabilidad
{
    public string Nombre{get;}
    public int Coste{ get;}

    public int Enfriamiento{get;}

    public IResultadoHabilidad Efecto(Personaje personajeEjecutor, Personaje personajeObjetivo);
}