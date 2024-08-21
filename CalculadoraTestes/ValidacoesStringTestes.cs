using Calculadora.Services;

namespace ValidacoesStringTestes;

public class ValidacoesStringTestes
{
    private ValidacoesString _validacoes;

    public ValidacoesStringTestes(){
        _validacoes = new ValidacoesString();
    }

    [Fact]
    public void DeveContar3CaracteresEmOlaERetornar3()
    {
        //Arrange
        string texto = "Olá";

        //Act
        int resultado = _validacoes.ContarCaracteres(texto);

        //Assert
        Assert.Equal(3, resultado);
    }
}