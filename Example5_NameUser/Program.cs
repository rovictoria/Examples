Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "вика")
{
  Console.WriteLine("Ура, это же ВИКА!!!");  
}
else
{
    Console.WriteLine("Привет, " + username);
}
