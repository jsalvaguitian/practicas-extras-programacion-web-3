namespace Clase4.poo.Entidades;

public class BolaDeLava : IHabilidad
{
    public string Nombre{get;} = "Bola de Lava";

    public int Coste{get; } = 40;

    public int Enfriamiento => 3;

    public IResultadoHabilidad Efecto(Personaje personajeEjecutor, Personaje personajeObjetivo)
    {
        if(personajeEjecutor.Mana < Coste)
        {
            return new ResultadoHabilidadFallido("No tiene suficiente mana para usar esta habilidad");
        }
        personajeEjecutor.Mana -= Coste;
        personajeObjetivo.HpActual -=300;
        if(personajeObjetivo.HpActual <0)
            personajeObjetivo.HpActual =0;
        return new ResultadoHabilidadExitoso();
    }
}