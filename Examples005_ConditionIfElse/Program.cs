Console.Clear();
Console.Write("Ввидите имя пользоателя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine ("Ура, это же МАША");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine(username);
}