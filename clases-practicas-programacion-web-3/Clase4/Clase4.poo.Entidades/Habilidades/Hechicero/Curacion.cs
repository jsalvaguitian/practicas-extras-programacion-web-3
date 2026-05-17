namespace Clase4.poo.Entidades;

public class Curacion : IHabilidad
{
    public string Nombre { get; } = "Curacion";
    public int Coste { get; } = 20;

    public int Enfriamiento => 1;

    public IResultadoHabilidad Efecto(Personaje personajeEjecutor, Personaje personajeObjetivo)
    {

        if(personajeEjecutor.Mana < Coste)
        {
            return new ResultadoHabilidadFallido("No tienes suficiente mana para usar esta habilidad");
        }

        personajeEjecutor.Mana -= Coste;

        //Curacion + 300 hp
        personajeObjetivo.HpActual += 300;
        if (personajeObjetivo.HpActual > personajeObjetivo.HpInicial)
        {
            personajeObjetivo.HpActual = personajeObjetivo.HpInicial;
        }
        return new ResultadoHabilidadExitoso();
    }

   
}