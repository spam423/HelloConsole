Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ника")
{
    Console.WriteLine("Ура это же Ника!");
}
else    
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}