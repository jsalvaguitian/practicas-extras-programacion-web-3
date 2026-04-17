using Clase1.Logica.Juego; // para usar otro proyecto se necesita hacer inclue en .csproj

namespace Clase1.Test;

public class JuegoAhorcadoTest
{
    //opcion 1 de testeo enviando parametros y usamos theory
    [Theory]
    [InlineData("casa", 'a', true, "_a_a")]
    [InlineData("casa", 'c', true, "c___")]
    [InlineData("casa", 's', true, "__s_")]
    public void Adivinar_LetraCorrecta_RevelaLaLetra(string palabraSecreta, char letraIntento, bool esValida, string palabraEnmascarada)
    {
        var juego = new JuegoAhorcado(palabraSecreta, intentosMaximos : 6);
        var resultado = juego.Adivinar(letraIntento);

        Assert.True(resultado);
        Assert.Equal(palabraEnmascarada, juego.PalabraEnmascarada);
    }

    //opcion 2 de testeo sin parametros se usa palabra clave [Fact]
    [Fact]
    public void Adivinar_LetraIncorrecta_RestaIntento()
    {
        var juego = new JuegoAhorcado("test", intentosMaximos: 3);
        var resultado = juego.Adivinar('z');

        Assert.False(resultado);
        Assert.Equal(2, juego.IntentosRestantes);

    }

    [Fact]
    public void Adivinar_LetraRepetida_NoRestaIntento()
    {
        var juego = new JuegoAhorcado("hola", intentosMaximos: 3);

        var primera = juego.Adivinar('x');
        var intentosDespuesPrimera = juego.IntentosRestantes;
        var segunda = juego.Adivinar('x');
        
        Assert.False(primera);
        Assert.False(segunda);
        Assert.Equal(intentosDespuesPrimera, juego.IntentosRestantes);
    }

    [Fact]
    public void Juego_Completo_Ganado()
    {
        var juego = new JuegoAhorcado("ab", intentosMaximos: 6);

        juego.Adivinar('a');
        juego.Adivinar('b');

        Assert.True(juego.IsGanado);
        Assert.False(juego.IsPerdido);
    }

    [Fact]
    public void Juego_Completo_Game_Over()
    {
        var juego = new JuegoAhorcado("xyz", intentosMaximos:2);
        
        juego.Adivinar('a');
        juego.Adivinar('b');

        Assert.True(juego.IsPerdido);
    }
}
