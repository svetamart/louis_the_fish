Console.WriteLine("Введите число, чтобы вычислить его факториал");
int number = Convert.ToInt32(Console.ReadLine());

double Factorial (int n)
{
    
    
    
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

// Console.WriteLine(Factorial(number));