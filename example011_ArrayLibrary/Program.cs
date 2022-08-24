void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col) // надо давать разные имена аргументам
{
    int size = col.Length;
    int position = 0;
    while(position < size)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // находим какой-то элемент из массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // прием на случай, если искомого элемента в массиве нет. чтоб не путаться с 0


    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // определили массив из N элементов (в данном случае 10)

FillArray(array); // вызвали метод FillArray, чтобы заполнить массив
array[4] = 4;
array[2] = 4; // добавляем побольше четверок, чтобы посмотреть, что будет показывать консоль

PrintArray(array); // вызвали метод PrintArray, чтобы "распечатать" массив
Console.WriteLine();

int pos = IndexOf(array, 4); // новая переменная, где лежит результат работы метода IndexOf -- в кач-ва аргумента передается наш массив, ищум цифру "4"
Console.WriteLine(pos);
