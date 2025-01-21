Console.WriteLine("Task 1");

Console.WriteLine(RecurFact(4));

static int RecurFact(int n)
{
    if (n < 1) return 0;
    else if (n == 1) return 1;
    return n * RecurFact(n - 1);
}