// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int PowNumber(int number, int degree)
{
  int result = Convert.ToInt32(Math.Pow(number, degree));
  return result;
}
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {A} в степени {B} равно - {PowNumber(A,B)}");
