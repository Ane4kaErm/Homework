// Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



void FillArray(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size; i++)
    {
        collection[i] = Random.Shared.Next(1, 8);
        
    }
}

string PrintArray(int[] numbers)
{
    int size = numbers.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
        result += ($"{numbers[i]}", 3);
        i++;
    }
    return result + "]";
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);

