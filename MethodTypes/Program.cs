// Вид 1 - не принимают аргументов и не возвращают данные

void Method1()
{
    Console.WriteLine("какой-то текст");
}

Method1(); // вызываем метод. обязательно поставить круглые скобки с аргументом или без

// Вид 2 - принимают аргументы, но ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "какой-то текст"); 

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
Method21(msg: "текст", count: 4); // сколько раз хотим увидеть этот текст при исполнении метода. указываем 

// Вид 3 - ничего не принимают, но что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3(); // вводим новую переменную и кладем туда значение, вызывая метод
Console.WriteLine(year);


// Вид 4 - что-то принимают, что-то возвращают

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty; // пока что в переменной ничего нет, пустая строка

//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "ahsdbvj ");
// Console.WriteLine(res);

string Method4(int count, string c)
{
    string result = String.Empty; // пока что в переменной ничего нет, пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res = Method4(10, "larry is real ");
Console.WriteLine(res);

for (int i = 2; i <= 10; i++) // таблица умножения
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}

//=====Работа с текстом 
// Дан текст. В тексте нужно все пробелы заменить чёрточками, 
// маленькие буквы “к” заменить большими “К”, 
// а большие “С” маленькими “с”. 
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, " 
            + "вы бы взяли приступом согласие прусского короля. " 
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = “qwerty” 
//             012345
// s[3] // r - можем обратиться к любому символу строки по индексу. отсчет с нуля!

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // если символ из строки совпал с oldValue т.е. с тем символом, который мы хотим заменить, то мы заменяем его на newValue
        else result = result + $"{text[i]}"; // если не совпал, то оставляем прежний символ
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine(); // пустая строка для красоты
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

// АЛГОРИТМ СОРТИРОВКИ МЕТОДОМ ВЫБОРА (МИНИМАКС, ВЫБОР МАКСИМАЛЬНОГО/МИНИМАЛЬНОГО)

int[] arr = {5, 7, 2, 8, 9, 3, 1, 3, 3};

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // сортируем массив
{ 
    for (int i = 0; i < array.Length - 1; i++) // array.length - 1 -- если мы начинаем позицию поиска максимального от индекса i+1, 
                                                            //       где i меняется до максимального значения позиции нашего массива, 
                                                            // то в этом случае мы должны будем искусственно одну единицу отнять. 
                                                            // Тогда получится, что ровно это i+1 даст общее количество элементов.
    { 
        int minPosition = i; // вводим минимальное число
        
        for (int j = i + 1; j < array.Length; j++) 
        { 
            if(array[j] < array[minPosition])  minPosition = j; // если число меньше минимума, он становится минимумом
        } 
        int temporary = array[i];
        array[i] = array[minPosition]; 
        array[minPosition] = temporary; // сортируем массив. меняем элементы местами
    } 
} 
PrintArray(arr); 
SelectionSort(arr); 
PrintArray(arr);
