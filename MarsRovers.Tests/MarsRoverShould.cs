using codeKatas;
using FluentAssertions;

namespace MarsRovers.Tests;

public class MarsRoverShould
{
    [Theory]
    [InlineData("R", "0:0:E")]
    [InlineData("RR", "0:0:S")]
    [InlineData("RRR", "0:0:W")]
    [InlineData("RRRR", "0:0:N")]
    public void turn_right(string command, string position)
    {
        var marsRover = new MarsRover2();

        marsRover.Execute(command).Should().Be(position);
    }

    [Theory]
    [InlineData("L","0:0:W")]
    [InlineData("LL","0:0:S")]
    [InlineData("LLL","0:0:E")]
    [InlineData("LLLL","0:0:N")]
    public void turn_left(string command, string position)
    {
        var marsRover = new MarsRover2();

        marsRover.Execute(command).Should().Be(position);
    }

    [Fact]
    public void moves_to_north()
    {
        MarsRover2 marsRover = new MarsRover2();
        
        marsRover.Execute("M").Should().Be("0:1:N");
    }
}