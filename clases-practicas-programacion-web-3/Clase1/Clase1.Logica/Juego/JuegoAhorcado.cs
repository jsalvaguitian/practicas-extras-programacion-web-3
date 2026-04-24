using System;
using System.Collections.Generic;
using System.Linq; //Language Integrated query  

namespace Clase1.Logica.Juego;

public class JuegoAhorcado : IJuegoAhorcado
{
    
    private readonly string palabraSecreta;
    private readonly HashSet<char> letrasAdivinadas = new();
    public string PalabraEnmascarada => new string(palabraSecreta.Select(cadaLetra => letrasAdivinadas.Contains(cadaLetra) ? cadaLetra : '_' ).ToArray()); //viene de Linq parecido a foreach pero mas estetico (parecido a JAVA Stream)

    public int IntentosRestantes{get; private set; }

    public IReadOnlyCollection<char> LetrasAdivinadas => letrasAdivinadas;

    public bool IsGanado => !PalabraEnmascarada.Contains('_');

    public bool IsPerdido => IntentosRestantes <= 0 && !IsGanado;

    //Constructor
    public JuegoAhorcado(string palabraSecreta, int intentosMaximos = 6)
    {
        if(string.IsNullOrWhiteSpace(palabraSecreta)) 
            throw new ArgumentException("La palabra secreta no puede estar vacia", nameof(palabraSecreta));
        this.palabraSecreta = palabraSecreta.ToLowerInvariant();
        IntentosRestantes = intentosMaximos;
    }
    public bool Adivinar(char letra)
    {
        letra = char.ToLowerInvariant(letra);
        if(letrasAdivinadas.Contains(letra))
            return palabraSecreta.Contains(letra);

        letrasAdivinadas.Add(letra);

        if(palabraSecreta.Contains(letra))
            return true;

        IntentosRestantes--;
        return false;
    }
}