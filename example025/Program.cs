
int Exponentiation(int RaisedNumber, int Exponent)
{
    int exponentiation = 1;
    for (int i = 0; i < Exponent; i++)
    {
        exponentiation *= RaisedNumber;
    }
    return exponentiation;
}
Console.WriteLine("Введите число которое хотите возвести в степень: ");
int raised_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень хотите возвети? ");
int exponent = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("{0} ^ {1} = {2}", raised_number, exponent, Exponentiation(raised_number, exponent));