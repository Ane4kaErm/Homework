//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine()!);

while (day <= 7)
{
    if (day >= 1 && day <= 5)
    {
        Console.WriteLine("нет");
    }
    else
    {
        Console.WriteLine("да");
    }
    break;
}


















