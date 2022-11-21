using codeKatas;
using FluentAssertions;

namespace MarsRovers.Tests;

public class MarsRoverShould
{
    private MarsRover2 _marsRover;

    public MarsRoverShould()
    {
        _marsRover = new MarsRover2();
    }

    [Theory]
    [InlineData("R", "0:0:E")]
    [InlineData("RR", "0:0:S")]
    [InlineData("RRR", "0:0:W")]
    [InlineData("RRRR", "0:0:N")]
    public void turn_right(string command, string position)
    {
        var roverPosition = _marsRover.Execute(command);
        
        roverPosition.Should().Be(position);
    }

    [Theory]
    [InlineData("L", "0:0:W")]
    [InlineData("LL", "0:0:S")]
    [InlineData("LLL", "0:0:E")]
    [InlineData("LLLL", "0:0:N")]
    public void turn_left(string command, string position)
    {
        var roverPosition = _marsRover.Execute(command);
        
        roverPosition.Should().Be(position);
    }

    [Fact]
    public void move_to_north()
    {
        const string expected = "0:2:N";
        const string command = "MM";

        var roverPosition = _marsRover.Execute(command);

        roverPosition.Should().Be(expected);
    }

    [Theory]
    [InlineData("RMMMM","4:0:E")]
    [InlineData("RMMLMMM","2:3:N")]
    [InlineData("MMRMMM","3:2:E")]
    [InlineData("RMMMMLMMLMM","2:2:W")]
    [InlineData("RMMMMLMMLMMLM","2:1:S")]
    public void move_and_turn_around(string command, string position)
    {
        var roverPosition = _marsRover.Execute(command);
        
        roverPosition.Should().Be(position);
    }
}