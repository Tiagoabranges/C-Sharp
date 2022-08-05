public static string IdentifyPolygon(int sideCount)
{
    var name = string.Empty;
    switch (sideCount)
    {
        case < 3:
            name = "Não é um polígono";
            break;
        case 3:
            name = "Triângulo";
            break;
        case 4:
            name = "Quadrado";
            break;
        case 5:
            name = "Pentágono";
            break;
        default:
            name = "Polígono não identificado";
            break;
    }
    return name;
}

    [Theory(DisplayName = "Deve classificar um polígono.")]
    [InlineData(2,"Não é um polígono")]
    [InlineData(3,"Triângulo")]
    [InlineData(4,"Quadrado")]
    [InlineData(5,"Pentágono")]
    [InlineData(6,"Polígono não identificado")]
    public void TestIdentifyPolygon(int sideCount, string name)
    {
        var resultName = Polygon.ClassificarPoligono(name);

        resultName.Should().Be(name);
    }