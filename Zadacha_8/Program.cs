Console.WriteLine("Введите число N:");
string N1 = Console.ReadLine();
int N = int.Parse(N1);
int x = 2;

if (N<2)
{
  Console.WriteLine("Четных чисел от 1 до N нет.");  
}

while (x<=N)
{
   Console.Write(x); 
if (x<(N-1)) 
{  
Console.Write(",");
}
x = x+2;
}


