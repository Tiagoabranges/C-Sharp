using FluentAssertions;
namespace rocket;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
var trybeRocket = new Rocket();
trybeRocket.Should().NotBeNull();
trybeRocket.Should().BeOfType<Rocket>();
    }

 [Fact]
     public void Test2()
    {
var trybeRocket = new Rocket("Trybe I", "Brasil", 100000);

trybeRocket._Name.Should().Be("Trybe I");
trybeRocket._Country.Should().Be("Brasil");
trybeRocket._Speed.Should().Be(100000);
    }
}