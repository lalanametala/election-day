using Xunit;
using System;
using FluentAssertions;
using election_day.Test;

namespace election_day.Test.Test;

[Collection("Sequential")]
public class TestTestFirstReq
{
    [Trait("Category", "1 - Criou testes de sucesso para o TestGetCountVoters.")]
    [Theory(DisplayName = "TestGetCountVoters deve ser executado com sucesso quando printar o número de eleitores informado.")]
    [InlineData(1)]
    public void TestSucessTestGetCountVoters(int countVoters)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestGetCountVoters(countVoters);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
public class TestFirstReq2
{
    [Trait("Category", "2 - Criou testes de falha para o TestGetCountVoters.")]
    [Theory(DisplayName = "TestGetCountVoters deve falhar quando não printar o número de eleitores informados")]
    [InlineData(-1)]
    [InlineData(0)]
    public void TestFailTestGetCountVoters(int countVoters)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestGetCountVoters(countVoters);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
