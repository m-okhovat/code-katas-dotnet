using codeKatas;
using FluentAssertions;

namespace MarsRovers.Tests;

public class MarsRoverShould
{
    [Theory]
    [InlineData("R","0:0:E")]
    [InlineData("RR","0:0:S")]
    [InlineData("RRR","0:0:W")]
    public void turn_right(string command, string position)
    {
        var marsRover = new MarsRover2();
        
        marsRover.Execute(command).Should().Be(position);
    }
}