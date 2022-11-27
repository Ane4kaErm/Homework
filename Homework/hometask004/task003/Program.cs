// Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int[] CreateArray(int count)
{
  return new int[count];
}

void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = Random.Shared.Next(min, max);
    }
}

string PrintGood(int[] array)
{
  int size = array.Length;
  int i = 0;
  string result = "[ ";

  while (i < size)
  {
    result += ($"{array[i]} ");
    i++;
  }
  return result + "]";
}


int [] collection = CreateArray (8);
Fill(collection, 1, 9);
Console.WriteLine(PrintGood(collection));
