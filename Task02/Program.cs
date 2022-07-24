Console.WriteLine("Введите числа");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int max = x;
int min = x;
if(x>y)
{
    max = x;
    min = y;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.Write(min);
}
else
{
    max = y;
    min = x;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.Write(min);
}