Console.WriteLine("Task 3");

Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetPow(value, pow));

static int GetPow(int x, int y)
{
    if (y < 0)
        return 0;
    else if (y == 0)
        return 1;
    else if (y % 2 == 0)
        return GetPow(x * x, y / 2);
    return x * GetPow(x * x, (y - 1) / 2);
}