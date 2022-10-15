using Xunit;
using System.IO;
using System;
using election_day;
using FluentAssertions;
using Xunit.Sdk;

namespace election_day.Test;

[Collection("Sequential")]
public class TestFirstReq
{
    [Theory]
    [InlineData(1)]
    public void TestGetCountVoters(int countVoters)
    {
        int response;

        using(var stringReader = new StringReader(Convert.ToString(countVoters))) 
        {  
            if (countVoters <= 0)
                throw new XunitException();
  
            Console.SetIn(stringReader);
            BallotBox instance = new();
            response = instance.GetCountVoters();
        }          
        response.Should().Be(countVoters); 
    }
}
