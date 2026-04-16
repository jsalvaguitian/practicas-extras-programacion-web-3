using Clase1.Logica.Juego; // para usar otro proyecto se necesita hacer inclue en .csproj

namespace Clase1.Test;

public class JuegoAhorcadoTest
{/*
    [Theory]
    [InlineData("casa", 'a', true, "_a_a")]
    [InlineData("casa", 'c', true, "c___")]
    [InlineData("casa", 's', true, "__s_")]
    public void Adivinar_LetraCorrecta_RevelaLaLetra(string palabraSecreta, char letraIntento, bool esValida, string palabraEnmascarada)
    {
        var juego = new JuegoAhorcado("casa", intentosMaximos : 6);
        var resultado = juego.Adivinar('a');

        Assert.True(resultado);
        Assert.Equal("_a_a", juego.PalabraEnmascarada);
    }

    [Fact]
    public void Adivinar_LetraIncorrecta_RestaIntento()
    {
        var juego = new JuegoAhorcado("test", intentosMaximos: 3);
        var resultado = juego.Adivinar('z');

        Assert.False(resultado);
        Assert.Equal(2, juego.IntentosRestantes);

    }*/
}
