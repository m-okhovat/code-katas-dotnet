using codeKatas;
using FluentAssertions;

namespace MarsRover.Tests;

public class MovingTestsWithoutObstacles
{
    [Fact]
    public void moves_one_direction_towards_north()
    {
        var rover = new Rover();

        string roverPosition = rover.Execute("MMMM");

        roverPosition.Should().Be("0:4:N");
    }

    [Fact]
    public void moves_one_direction_towards_west()
    {
        var rover = new Rover();

        var position = rover.Execute("RMM");

        position.Should().Be("2:0:E");
    }

    [Fact]
    public void moves_north_and_then_turns_right()
    {
        var position = new Rover().Execute("MRMM");

        position.Should().Be("2:1:E");
    }

    [Fact]
    public void moves_right_then_turns_left()
    {
        string position = new Rover().Execute("RMMMLMM");

        position.Should().Be("3:2:N");
    }

    [Fact]
    public void moves_right_then_turns_left_then_turns_left()
    {
        string position = new Rover().Execute("RMLMLM");

        position.Should().Be("0:1:W");
    }

    [Fact]
    public void moves_toward_north_then_turns_right_then_turns_right()
    {
        var position = new Rover().Execute("MMMRMRM");

        position.Should().Be("1:2:S");
    }

    [Fact]
    public void moves_toward_north_then_turns_right_then_turns_right_then_turns_right()
    {
        var position = new Rover().Execute("MMMRMRMRM");

        position.Should().Be("0:2:W");
    }

    [Fact]
    public void moves_toward_north_then_turns_right_then_turns_right_then_turns_right_then_turns_right()
    {
        var position = new Rover().Execute("MMMRMRMRMRM");

        position.Should().Be("0:3:N");
    }

    [Fact]
    public void moves_right_then_turns_left_then_turns_left_then_turns_left()
    {
        string position = new Rover().Execute("RMLMLMLM");

        position.Should().Be("0:0:S");
    }

    [Fact]
    public void moves_right_then_turns_left_then_turns_left_then_turns_left_then_left()
    {
        string position = new Rover().Execute("RMLMLMLMLM");

        position.Should().Be("1:0:E");
    }

    [Fact]
    public void moves_in_four_directions()
    {
        string position = new Rover().Execute("MMMRMLMMRMMRMRMRMMM");

        position.Should().Be("2:7:N");
    }

}