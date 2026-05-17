namespace Clase4.poo.Entidades;

public class IncrementoMana : IHabilidad
{
    public string Nombre{get;} =  "Incremento de Mana";

    public int Coste{get; } = 20;

    public int Enfriamiento => 1;

    public IResultadoHabilidad Efecto(Personaje personajeEjecutor, Personaje personajeObjetivo)
    {
        if(personajeEjecutor.Mana < Coste)
        {
            return new ResultadoHabilidadFallido("No tienes suficiente mana para usar esta habilidad");
        }
        personajeEjecutor.Mana -= Coste;

        personajeEjecutor.Mana += 50;
        return new ResultadoHabilidadExitoso();
    }
}