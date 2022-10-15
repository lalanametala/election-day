using Xunit;
using System.IO;
using System;
using election_day;
using FluentAssertions;

namespace election_day.Test;

[Collection("Sequential")]
public class TestSecondReq
{
    [Theory(DisplayName = "Deve ler os votos")]
    [InlineData(2, 2)]
    public void TestStart(int countVoters, int printExpected)
    {
        using(var stringWriter = new StringWriter())
        {
            int consoleResponse;
            using(var stringReader = new StringReader(Convert.ToString(printExpected)))
            {
                BallotBox instance = new();

                Console.SetOut(stringWriter);
                Console.SetIn(stringReader);

                instance.Start(countVoters);
                consoleResponse = stringWriter.ToString().Trim().Split('\n').Length;
            }
            consoleResponse.Should().Be(printExpected);
        };
    }
}