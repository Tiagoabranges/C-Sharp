﻿//Criando um enum
enum CardinalPoints
{
    Norte,
    Sul,
    Leste,
    Oeste
};
//Utilizando um enum
CardinalPoints direction = CardinalPoints.Norte;
Console.WriteLine("Ponto Cardeal: "+direction);

//Criando uma struct
struct Schedule
{
    public int hour, minute, second;
    public string shift;
}

//utilizando uma struct
Schedule now;
now.hour = 10;
now.minute = 30;
now.shift = "AM";
Console.WriteLine("Horário: " + now.hour + ":" + now.minute + " " + now.shift);