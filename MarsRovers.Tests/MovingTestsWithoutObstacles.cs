using codeKatas;
using FluentAssertions;

namespace MarsRovers.Tests;

public class MovingTestsWithoutObstacles
{
    [Fact]
    public void moves_one_direction_towards_north()
    {
        var rover = new MarsRover();

        string roverPosition = rover.Execute("MMMM");

        roverPosition.Should().Be("0:4:N");
    }

    [Fact]
    public void moves_one_direction_towards_west()
    {
        var rover = new MarsRover();

        var position = rover.Execute("RMM");

        position.Should().Be("2:0:E");
    }

    [Fact]
    public void moves_north_and_then_turns_right()
    {
        var position = new MarsRover().Execute("MRMM");

        position.Should().Be("2:1:E");
    }

    [Fact]
    public void moves_right_then_turns_left()
    {
        string position = new MarsRover().Execute("RMMMLMM");

        position.Should().Be("3:2:N");
    }

    [Fact]
    public void moves_right_then_turns_left_then_turns_left()
    {
        string position = new MarsRover().Execute("RMLMLM");

        position.Should().Be("0:1:W");
    }

    [Fact]
    public void moves_toward_north_then_turns_right_then_turns_right()
    {
        var position = new MarsRover().Execute("MMMRMRM");

        position.Should().Be("1:2:S");
    }

    [Fact]
    public void moves_toward_north_then_turns_right_then_turns_right_then_turns_right()
    {
        var position = new MarsRover().Execute("MMMRMRMRM");

        position.Should().Be("0:2:W");
    }

    [Fact]
    public void moves_toward_north_then_turns_right_then_turns_right_then_turns_right_then_turns_right()
    {
        var position = new MarsRover().Execute("MMMRMRMRMRM");

        position.Should().Be("0:3:N");
    }

    [Fact]
    public void moves_right_then_turns_left_then_turns_left_then_turns_left()
    {
        string position = new MarsRover().Execute("RMLMLMLM");

        position.Should().Be("0:0:S");
    }

    [Fact]
    public void moves_right_then_turns_left_then_turns_left_then_turns_left_then_left()
    {
        string position = new MarsRover().Execute("RMLMLMLMLM");

        position.Should().Be("1:0:E");
    }

    [Fact]
    public void moves_in_four_directions()
    {
        string position = new MarsRover().Execute("MMMRMLMMRMMRMRMRMMM");

        position.Should().Be("2:7:N");
    }

}