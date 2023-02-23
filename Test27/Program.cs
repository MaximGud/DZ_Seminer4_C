// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int NumberSum(int number)
{
  int sum = 0;
  while (number > 0)
  {
    sum = sum + number % 10;
    number /= 10;
  }
  return sum;
}

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {A} равна - {NumberSum(A)}");