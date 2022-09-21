int FactorialFor (int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    return result;
}

Console.WriteLine(FactorialFor(5));

int FactorialRec (int n)
{
    if(n == 1 || n == 0)
    {
        return 1;
    }
    else
    {
        return n * FactorialRec(n - 1);
    }
}

Console.WriteLine(FactorialRec(5));