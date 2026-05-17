namespace Clase4.poo.Entidades;

public class Elfo : Personaje
{
    public Elfo()
    {
        HpInicial = 1200;
        Xp = 0;
        Mana = 150;
        Habilidades.Add(0, new List<IHabilidad>
        {
            //nivel 0
            
        });

        Habilidades.Add(1000, new List<IHabilidad>
        {
           //nivel 100 
        });

        AtaqueBasico = new AtaqueBasico("Flechas", 30);
        Raza = Raza.Elfo;
    }
}