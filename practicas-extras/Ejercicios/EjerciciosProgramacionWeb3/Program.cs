int intentosIniciales = 6;
int intentos = intentosIniciales;


//Palabras para el juego 
string[] palabras = { "programacion", "consola", "csharp", "desarrollo", "juego" };

//Elegir una palabra al azar
Random rand = new Random();
string palabraSecreta = palabras.OrderBy(x => rand.Next()).ToArray()[0];
//Mostrar la cantidad de letras de la palabra
string palabraOculta = new String('_', palabraSecreta.Length);

do
{
    Console.WriteLine();
    Console.WriteLine(palabraOculta.Replace("_"," _"));

    //Pedir al usuario que ingrese una letra    
    char letraIngresada = Console.ReadKey().KeyChar;

    //Verificar si la letra esta en la palabra
    if (palabraSecreta.Contains(letraIngresada))
    {

        //Mostrar la letra en su posicion correspondiente
        for (int i = 0; i < palabraSecreta.Length; i++)
        {
            if (palabraSecreta[i] == letraIngresada)
            {
                palabraOculta = palabraOculta.Remove(i, 1).Insert(i, letraIngresada.ToString());
            }
        }
    }
    else
    {
        Console.WriteLine();
        //Restar un intento
        Console.WriteLine("Letra incorrecta.Intentos restantes: " + (--intentos));
    }
} while (intentos > 0 && palabraOculta.Contains('_'));

if (palabraOculta.Contains('_'))
{
    Console.WriteLine($"Game over. Utilizo todos los {intentosIniciales} intentos... ");
}
else
{
    Console.WriteLine("Felicidades, Has adivinado la palabra: " + palabraSecreta);
}
//Si la letra esta en la palabra, mostrar la letra en su posicion correspondiente


//Si la letra no esta en la palabra, resta un intento.

//Mostrar el estado actual del juego (letras adivinadas y cantidad de intentos restantes)

//Repetir el proceso hasta que el usuario adivine la palabra o se quede sin intentos
