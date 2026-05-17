namespace Clase4.poo.Entidades;

public class Hechicero: Personaje
{
    public Hechicero()
    {
        HpInicial = 700;
        Xp = 0;
        Mana = 200;
        CapacidadMochila = 20;
        Monedas = 100;

        Habilidades.Add(0, new List<IHabilidad>
        {
            new Curacion(),
            new BolaDeFuego()
        });

        Habilidades.Add(100, new List<IHabilidad>
        {
            //NIVEL 100
            new BolaDeLava()
        });
        AtaqueBasico = new AtaqueBasico("Rayo necrotico", 50);
        Raza = Raza.Hechicero;
    }
}