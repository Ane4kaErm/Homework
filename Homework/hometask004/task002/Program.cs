// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число ");
int x = int.Parse(Console.ReadLine()!);

int[] array = new int[x.ToString().Length];
for (int i = 0; i < array.Length; i++)
    {
    array[i] = x % 10;
    x = x / 10;
    }
 Array.Reverse(array);

Console.WriteLine(string.Join(" ", array));
Console.ReadKey();  
 
