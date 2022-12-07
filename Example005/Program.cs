Console.WriteLine("Введи имя");
string username = Console.ReadLine();

if(username.ToLower() == "наташа")
{
    Console.WriteLine("Этож Наташа");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}