Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
  Console.WriteLite("Ура, это же МАША!");
}
else
{
  Console.Write("Привет, !");
  Console.WriteLite(username);
}