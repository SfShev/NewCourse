Console.WriteLine("Если хотите узнать какая вторая цифра этого трехзначного числа");
Console.WriteLine("Введите трехзначное число");

int number1 = Convert.ToInt32(Console.ReadLine());

int a = number1 % 100;
int b = a / 10;


Console.WriteLine(b);

