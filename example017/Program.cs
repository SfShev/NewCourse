Console.WriteLine("Если хотите узнать какая третья цифра числа");
Console.WriteLine("Введите число");

int number1 = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 0;


if (number1 > 99)
{
    string  str = number1.ToString();
    
    Console.WriteLine(str [2]);

}

if (number1 < 99)
{
    Console.WriteLine("третьей цифры нет");
}