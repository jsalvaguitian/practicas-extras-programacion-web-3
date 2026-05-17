namespace Clase4.poo.Entidades;

public class BolaDeFuego: IHabilidad
{
    public string Nombre{get;} = "Bola de Fuego";
    public int Coste{get;} = 30;

    public int Enfriamiento =>2;

    public IResultadoHabilidad Efecto(Personaje personajeEjecutor, Personaje personajeObjetivo)
    {
        if(personajeEjecutor.Mana < Coste)
        {
            return new ResultadoHabilidadFallido("No tienes suficiente mana para usar esta habilidad");
        }

        personajeEjecutor.Mana -= Coste;

        personajeObjetivo.HpActual-= 200;
        if(personajeObjetivo.HpActual < 0)
        {
            personajeObjetivo.HpActual =0;
        }
        return new ResultadoHabilidadExitoso();
    }

}