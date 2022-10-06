using Xunit;
using System.IO;
using System;
using election_day;
using FluentAssertions;

namespace election_day.Test;

[Collection("Sequential")]
public class TestThirdReq
{
    [Theory(DisplayName = "Deve imprimir o resultado")]
    [InlineData(new string[]{"6","1","1","5","A","3","2"}, 2, 1, 1, 2)]
    public void TestPrintResult(
        string[] entrys,
        int expectedReceivedOption1,
        int expectedReceivedOption2,
        int expectedReceivedOption3,
        int expectedOptionNull)
    {
        throw new NotImplementedException();
    }
}