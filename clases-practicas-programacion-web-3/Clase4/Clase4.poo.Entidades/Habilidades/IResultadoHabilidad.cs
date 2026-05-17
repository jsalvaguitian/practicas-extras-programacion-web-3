namespace Clase4.poo.Entidades;

public interface IResultadoHabilidad
{
    public bool HabilidadExitosa{get;}
    public string Mensaje {get;set;}
}

public class ResultadoHabilidadExitoso : IResultadoHabilidad
{
    public bool HabilidadExitosa{get;} = true;
    public string Mensaje {get; set;} = "Exitosa";
}

public class ResultadoHabilidadFallido : IResultadoHabilidad
{
    public bool HabilidadExitosa{get;} = false;
    public string Mensaje {get;set;}

    public ResultadoHabilidadFallido(string mensaje)
    {
        Mensaje = mensaje;
    }

}