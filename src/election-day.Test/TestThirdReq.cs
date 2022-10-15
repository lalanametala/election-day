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
        BallotBox instance = new();

        string stringReaderEntry = "";

        foreach (var entry in entrys)
        {
            stringReaderEntry += entry + "\n";
        }
        
        string[] response;
        using (var stringWriter = new StringWriter())
        {
            Console.SetOut(stringWriter);
            using (var stringReader = new StringReader(stringReaderEntry))
            {
                Console.SetIn(stringReader);
                instance.Start(entrys.Length);
            }
        }
        using (var stringWriter = new StringWriter())
        {
            Console.SetOut(stringWriter);
            instance.PrintResult();
            response = stringWriter.ToString().Trim().Split('\n');
        }
        int[] allVotes = {expectedReceivedOption1, expectedReceivedOption2, expectedReceivedOption3, expectedOptionNull};
        for (int index = 0; index < response.Length; index++)
        {
            if(index < allVotes.Length - 1) response[index].Should().Be("A opção" +(index + 1)+" recebeu: "+allVotes[index]+" voto(s)");
            else response[index].Should().Be("Total de votos anulados: "+allVotes[index]+" voto(s)");
        }


    }
}