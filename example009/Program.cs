Console.WriteLine("Если вы хотите проверить является ли первое число квадратом второго");
Console.WriteLine("Введите числа"); 
int a = Convert.ToInt32(Console.ReadLine()) ;
int b =Convert.ToInt32(Console.ReadLine()) ;
int c = b*b;

if(a == c)

{
    Console.WriteLine("Является!"); 
}

else
{
    Console.WriteLine("Увы,нет"); 
}