using Calculadora;

namespace Calculadora.Testes;

public class UnitTest1
{
    [Fact]
    public void SomarTest()
    {
        Assert.Equal(20, CalculadoraController.Somar(10, 10));
    }

    [Fact]
    public void SubtrairTest()
    {
        Assert.Equal(0, CalculadoraController.Subtrair(10, 10));
    }

    [Fact]
    public void MultiplicarTest()
    {
        Assert.Equal(100, CalculadoraController.Multiplicar(10, 10));
    }

    [Fact]
    public void DividirTest()
    {
        Assert.Equal(1, CalculadoraController.Dividir(10, 10));
    }
}