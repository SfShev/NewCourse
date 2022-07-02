int getPlanesNumber(float x, float y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;

    if (x < 0 && y < 0)
        return 3;

    if (x > 0 && y < 0)
        return 4;
    return -1;
}

    int planesNumber = getPlanesNumber(-1, -9);
if (planesNumber != -1 )
    Console.WriteLine($"Плоскость {planesNumber}");
else
    Console.WriteLine("Некорректные входные данные!!!");





void printPlanesNumber(float x, float y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("Плоскость 1 ");
    else if (x < 0 && y > 0)
        Console.WriteLine("Плоскость 2 ");

    else if (x < 0 && y < 0)
        Console.WriteLine("Плоскость 3 ");

    else if (x > 0 && y < 0)
        Console.WriteLine("Плоскость 4 ");
    else
        Console.WriteLine("Некорректные данные");
}


printPlanesNumber(-1, 2);
Console.WriteLine();

