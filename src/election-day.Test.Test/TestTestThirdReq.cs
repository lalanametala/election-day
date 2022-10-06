using Xunit;
using System;
using FluentAssertions;
using election_day.Test;

namespace election_day.Test.Test;

[Collection("Sequential")]
public class TestTestThirdReq
{
    [Trait("Category", "5 - Criou testes de sucesso para o TestPrintResult.")]
    [Theory(DisplayName = "TestPrintResult deve ser executado com sucesso quando printar o resultado da votação que foi armazenado nas variáveis durante a leitura dos votos.")]
    [InlineData(new string[]{"6","1","1","5","A","3","2"}, 2, 1, 1, 2)]
    public void TestSucessTestPrintResult(
        string[] entrys,
        int expectedReceivedOption1,
        int expectedReceivedOption2,
        int expectedReceivedOption3,
        int expectedOptionNull)
    {
        TestThirdReq instance = new();
        Action act = () => instance.TestPrintResult(entrys, expectedReceivedOption1, expectedReceivedOption2, expectedReceivedOption3, expectedOptionNull);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestThirdReq2
{

    [Trait("Category", "6 - Criou testes de falha para o TestPrintResult.")]
    [Theory(DisplayName = "TestPrintResult deve falhar quando printar o resultado da votação que foi armazenado nas variáveis durante a leitura dos votos.")]
    [InlineData(new string[]{"6","1","1","5","A","3","2"}, 1, 1, 1, 2)]
    [InlineData(new string[]{"6","1","1","5","A","3","2"}, 2, 2, 1, 2)]
    [InlineData(new string[]{"6","1","1","5","A","3","2"}, 2, 1, 2, 2)]
    [InlineData(new string[]{"6","1","1","5","A","3","2"}, 2, 1, 1, 3)]
    public void TestFailTestPrintResult(
        string[] entrys,
        int expectedReceivedOption1,
        int expectedReceivedOption2,
        int expectedReceivedOption3,
        int expectedOptionNull)
    {
        TestThirdReq instance = new();
        Action act = () => instance.TestPrintResult(entrys, expectedReceivedOption1, expectedReceivedOption2, expectedReceivedOption3, expectedOptionNull);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

}
