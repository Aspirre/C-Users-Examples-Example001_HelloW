Console.WriteLine("User Name");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Yea, it's Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}