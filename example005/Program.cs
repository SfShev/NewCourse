Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "павел")
{
    Console.WriteLine("Ура,это же Паша!"); 
}

else
{
    Console.Write("Привет," + username); 
}