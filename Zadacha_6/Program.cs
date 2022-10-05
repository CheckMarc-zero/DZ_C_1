Console.WriteLine("Введите число:");
string a1 = Console.ReadLine();
int a = int.Parse(a1);
int n = a%2;

if (n != 0)
{
Console.WriteLine("Число нечетное.");
}
else
{
Console.WriteLine("Число четное.");
}
