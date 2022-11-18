using codeKatas;
using FluentAssertions;

namespace MarsRovers.Tests;

public class MarsRoverShould
{
    [Fact]
    public void turn_right()
    {
        var marsRover = new MarsRover2();
        
        marsRover.execute().Should().Be("0:0:E");
    }
}