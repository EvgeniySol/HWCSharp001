Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int x = 1;
while (x <= a)
{
    if (x%2==0)
    {
        Console.WriteLine(x);
    }
    x = x+1;
}
