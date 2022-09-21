using System; // используем/импортируем определенное пространство имен

// using System.Text;

class Program // внутри класса находятся методы
{
    static public void Main(string[] args); // точка входа
    {
        if(args.Length >= 1)
        {
            Console.WriteLine($"Hello, {args[0].Remove("-","")}!");
        }
        
        Console.ReadKey();
    }
}


