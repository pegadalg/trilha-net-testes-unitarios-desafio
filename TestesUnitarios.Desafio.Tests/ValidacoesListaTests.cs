using System.Runtime.InteropServices;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
     private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act

        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert

        Assert.False(resultado);
    }

    //TODO: Corrigir a anotação [Fact]
    [Theory]
    [InlineData(new int[] { 5, 7, 8, 9 }, new int[] { 10, 14, 16, 18 })]
    public void DeveMultiplicarOsElementosDaListaPor2(int[] lista, int[] resultadoEsperado)
    {
        //TODO: Implementar método de teste

        // Arrange
        int numero = 2;
        var listaC = lista.ToList();
        var resultadoEsperadoC = resultadoEsperado.ToList();
        
        // Act

        var resultado = _validacoes.MultiplicarNumerosLista(listaC, numero);

        // Assert

        Assert.Equal(resultadoEsperadoC, resultado);
    }

    [Theory]
    [InlineData(new int[] { 5, -1, -8, 9 })]
    public void DeveRetornar9ComoMaiorNumeroDaLista(int[] lista)
    {
        //TODO: Implementar método de teste

        // Arrange
        var listan = lista.ToList();

        // Act

        var resultado = _validacoes.RetornarMaiorNumeroLista(listan);
        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(9, resultado);
    }
    [Theory]
    [InlineData(new int[] { 5, -1, -8, 9 })]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista(int[] lista)
    {
        //TODO: Implementar método de teste

        // Arrange
        var listan = lista.ToList();

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(listan);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(-8, resultado);
    }
}