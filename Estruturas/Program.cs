public static string IdentifyTriangle(double xSide, double ySide, double zSide)
{       
    var name = "";


    if(xSide == ySide && xSide == zSide)
    {
        name = "Triângulo Equilátero";
    }
    else if((xSide == ladoB) || (xSide == zSide) || (ySide ==zSide))
    {
        name = "Triângulo Isóscele";
    }
    else
    {
        name = "Triângulo Escaleno";
    }
    return name;
}


    [Theory(DisplayName = "Deve classificar um triangulo")]
    [InlineData(2,2,2, "Triângulo Equilátero")]
    [InlineData(5,6,6, "Triângulo Isóscele")]
    [InlineData(6,2,6, "Triângulo Isóscele")]
    [InlineData(6,6,2, "Triângulo Isóscele")]
    [InlineData(1,2,3, "Triângulo Escaleno")]
    public void TestIdentifyTriangle(double xSide, double ySide, double zSide, string name)
    {
        var resultName = Triangle.IdentifyTriangle(xSide, ySide, zSide);

        resultName.Should().Be(name);
    }