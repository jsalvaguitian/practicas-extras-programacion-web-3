namespace Clase4.poo.Entidades;

public class FlechaExplosiva : IHabilidad
{
    public string Nombre{get;} = "Flecha explosiva";
    public int Coste {get;} = 150;
    public int Enfriamiento => 3;


    public IResultadoHabilidad Efecto(Personaje personajeEjecutor, Personaje personajeObjetivo)
    {
        if(personajeEjecutor.Mana < Coste)
        {
            return new ResultadoHabilidadFallido("No tienes suficiente mana para usar esta habilidad");
        }
        personajeEjecutor.Mana -=Coste;

        personajeObjetivo.HpActual -= 700;
        if(personajeObjetivo.HpActual < 0)
        {
            personajeObjetivo.HpActual = 0;
        }
        return new ResultadoHabilidadExitoso();
    }
}