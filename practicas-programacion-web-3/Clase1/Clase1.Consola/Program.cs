using Clase1.Logica.IO;
using Clase1.Logica.Juego;
using Clase1.Logica.Providers;

int intentosIniciales = 6;

IConsola consola = new ConsolaWrapper();
IProveedorPalabras proveedor = new ProveedorPalabrasEstatico(new[] {"programacion", "consola", "juego", "csharp", "desarrollo", "juego"});

string palabraSecreta = proveedor.ObtenerPalabraAleatoria();
IJuegoAhorcado juego = new JuegoAhorcado(palabraSecreta, intentosIniciales);

consola.EscribirLinea("Bienvenido al juego del ahorcado");
consola.EscribirLinea($"Tendras {intentosIniciales} intentos para adivinar la palabra secreta");

while(juego.IntentosRestantes>0 && !juego.IsGanado){
    consola.EscribirLinea(juego.PalabraEnmascarada.Replace("_", " _"));
    char letra = consola.LeerTecla();
    consola.EscribirLinea();

    bool acierto = juego.Adivinar(letra);
    if(!acierto)
        consola.EscribirLinea("Letra incorrecta. Intentos restantes: "+ juego.IntentosRestantes);
    
}

consola.EscribirLinea();
if (!juego.IsGanado)
{
    consola.EscribirLinea($"GAME OVER :C Se utilizo todos los {intentosIniciales} intentos posibles");
}
else
{
    consola.EscribirLinea("Ganaste! Adivinaste la palabra: "+ palabraSecreta);
}
