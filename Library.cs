public static class Library

// метод, который создает массив

int[] CreateArray(int count)
{
    return new int[count];
}

// метод заполнения массива

void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = Random.Shared.Next(min, max);
        // array[i] = new Random().Next(min, max);
    }
}

// метод печати массива

string PrintGood(int[] numbers)
{
    int size = numbers.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
        result += ($"{numbers[i]}");
        i++;
    }
    return result + "]";
}

// метод нахождения суммы положительных элементов массива

int SumPositive(int[] numbers)
{
    int result = 0;
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] > 0 ) result += numbers[i];
    }
    return result;
}

// метод нахождения суммы отрицательных элементов массива

int SumNegative(int[] numbers)
{
    int result = 0;
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] < 0 ) result += numbers[i];
    }
    return result;
}

// создаем массив из наших данных

int [] col = CreateArray(12);
Console.WriteLine(PrintGood(col));
Fill (col, -9, 10);
Console.WriteLine(PrintGood(col));
Console.WriteLine($">0 {SumPositive(col)}");
Console.WriteLine($"<0 {SumNegative(col)}");

