int[] array = {1, 34, 8, 28, 665, 9, 8, 55, 4, 28};

int n = array.Length; // это типа size, размер массива

int find = 28;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1; // index++
}

