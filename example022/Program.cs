Console.WriteLine("Введите число");

int number1 = Convert.ToInt32(Console.ReadLine());
int index = 0;



if (number1 > 0)

    while (index <= number1)
    {
        Console.Write($"{index * index} ");
        index++;
    }
else
    while (index >= number1)
    {
        Console.Write($"{index * index} ");
        index -= 1;
    }