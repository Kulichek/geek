Console.WriteLine("ВВедите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Да это же МАША!");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}