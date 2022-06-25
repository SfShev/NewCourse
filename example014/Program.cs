Console.WriteLine("Если хотите узнать все четные числа от 1 до выбранного числа");
Console.WriteLine("Введите число");

int number1 = Convert.ToInt32(Console.ReadLine());
int index = 2;

while (index <= number1)
{
    Console.Write($"{index} ");


    index += 2;
}