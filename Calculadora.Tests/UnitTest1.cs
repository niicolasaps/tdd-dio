using Xunit;
using CalculadoraApp;

public class CalculadoraTests
{
    [Fact]
    public void Adicao_DeveRetornarResultadoCorreto()
    {
        var calculadora = new Calculadora();
        var resultado = calculadora.Adicionar(2, 3);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Subtracao_DeveRetornarResultadoCorreto()
    {
        var calculadora = new Calculadora();
        var resultado = calculadora.Subtrair(5, 3);
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void Multiplicacao_DeveRetornarResultadoCorreto()
    {
        var calculadora = new Calculadora();
        var resultado = calculadora.Multiplicar(2, 3);
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void Divisao_DeveRetornarResultadoCorreto()
    {
        var calculadora = new Calculadora();
        var resultado = calculadora.Dividir(6, 3);
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void Divisao_PorZero_DeveLancarExcecao()
    {
        var calculadora = new Calculadora();
        Assert.Throws<System.DivideByZeroException>(() => calculadora.Dividir(6, 0));
    }
}
