namespace Clase1.Logica.IO; //es como package de java import

public interface IConsola
{
    void Escribir(string texto);
    void EscribirLinea(string texto = "");
    char LeerTecla();
}
