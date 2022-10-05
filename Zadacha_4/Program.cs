Console.WriteLine("Введите a:");
string a1 = Console.ReadLine();
int a = int.Parse(a1);
Console.WriteLine("Введите b:");
string b1 = Console.ReadLine();
int b = int.Parse(b1);
Console.WriteLine("Введите c:");
string c1 = Console.ReadLine();
int c = int.Parse(c1);

int max = a;

if (max<b)
{
max = b;
}

if (max<c)
{
max = c;
}

Console.Write("Наибольшее число : ");
Console.Write(max);
