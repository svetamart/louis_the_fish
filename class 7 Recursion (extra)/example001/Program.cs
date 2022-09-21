// собрать строчку с числами от а до b. a <= b

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for(int i = a; i <= b; i++)
    {
        result = result + $"{i} ";
    }
    return result;
}

Console.WriteLine(NumbersFor(1, 10));

string NumbersRec(int a, int b)
{
    if(a <= b)
    {
        return $"{a} " + NumbersRec(a + 1, b);
    }
    else
    {
        return String.Empty;
    }
}

Console.WriteLine(NumbersRec(5, 10));