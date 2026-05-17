namespace Clase4.poo.Entidades;
//opcion 1
public enum Raza
{
    Elfo,
    Paladin,
    Hechicero
}

//opcion 2
public static class Razas
{
    public static class Elfo
    {
        public const int Id = 1;
        public const string Nombre = "Elfo";
    }

    public static class Paladin
    {
        public const int Id = 2;
        public const string Nombre = "Paladin";
    }
    public static class Hechicero
    {
        public const int Id = 3;
        public const string Nombre = "Hechicero";
    }



}
