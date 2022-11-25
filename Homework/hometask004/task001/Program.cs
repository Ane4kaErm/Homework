// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow использовать нельзя
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


  Console.Write("Введите число   : ");
  int A = int.Parse(Console.ReadLine()!);
  
  Console.Write("Введите степень : ");
  int B = int.Parse(Console.ReadLine()!);
  
  int numberN = 1;
  for (int i = 0; i < B; i++) 
  {
   numberN *= A;
  }

  Console.WriteLine("{0} ^ {1} = {2}", A, B, numberN);

 

