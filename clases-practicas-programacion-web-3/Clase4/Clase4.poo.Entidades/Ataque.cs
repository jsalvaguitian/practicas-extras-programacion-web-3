namespace Clase4.poo.Entidades;


public interface IAtaque
{
    public string Nombre {get; set;}
    public int Danio {get; set;}
}

public class AtaqueBasico : IAtaque
{
   
    public string Nombre { get; set; }
    public int Danio { get ; set; }

     public AtaqueBasico(string nombre, int danio)
    {
        Nombre = nombre;
        Danio = danio;
    }

    
}