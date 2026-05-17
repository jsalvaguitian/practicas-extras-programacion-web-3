namespace Clase4.poo.Entidades;

public class Personaje
{
    public int Id {get; set;}
    public string Nombre {get; set;} = "";

    public bool Derrotado{get; set;}

    public int HpActual{get; set;}

    public int HpInicial {get; set;}
//me lo anoto ni idea de juegos
//Al matar a un personaje se sube el xp.  Al subir de nivel se puede mejorar las habilidades, aumentar el hp, mana
    public int Xp {get; set;}

//parecido a HASHMAP clave valor
    protected Dictionary<int, List<IHabilidad>> Habilidades {get; } = new Dictionary<int, List<IHabilidad>>();

    public List<IHabilidad> ObtenerHabilidadesDisponibles()
    {
        return Habilidades
        .Where(h=> h.Key <= Xp)
        .SelectMany(h => h.Value)
        .ToList();
    }

    public int Mana {get; set;}

    public int CapacidadMochila {get; set;}

    public int Monedas {get; set;}

    public Raza Raza {get; set;}

    public IAtaque AtaqueBasico {get; set;}


}
