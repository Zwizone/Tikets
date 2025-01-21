Console.WriteLine("Task 2");

Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetPow(value, pow));

static double GetPow(int x, int y)
{
    if (y == 0)
        return 1;
    else if (y > 0)
        return x * GetPow(x, y - 1);
    return 1.0 / GetPow(x, -y);
}