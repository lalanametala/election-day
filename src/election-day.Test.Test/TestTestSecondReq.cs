using Xunit;
using System;
using FluentAssertions;
using election_day.Test;

namespace election_day.Test.Test;

[Collection("Sequential")]
public class TestTestSecondReq
{
    [Trait("Category", "3 - Criou testes de sucesso para o TestStart.")]
    [Theory(DisplayName = "TestStart deve ser executado com sucesso quando printar a solicitação de voto na mesma quantidade de vezes que os votos esperados.")]
    [InlineData(2, 2)]
    public void TestSucessTestStart(int countVoters, int printExpected)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestStart(countVoters, printExpected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestSecondReq2
{

    [Trait("Category", "4 - Criou testes de falha para o TestStart.")]
    [Theory(DisplayName = "TestStart deve falhar quando printar a solicitação de voto diferente da quantidade de vezes que os votos esperados.")]
    [InlineData(2, 1)]
    public void TestFailTestStart(int countVoters, int printExpected)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestStart(countVoters, printExpected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }  
}
