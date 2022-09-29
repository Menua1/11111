Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "мария")
{
    Console.WriteLine("ура,это Мария");
}
else 
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}