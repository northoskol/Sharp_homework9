// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbers(int firstNumber, int SecondNumber)
{
    if (firstNumber > SecondNumber) return 0;
    return firstNumber + SumNaturalNumbers(firstNumber + 1, SecondNumber);
}

Console.Write("Введите число M: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int sum = SumNaturalNumbers(firstNumber, secondNumber);
Console.WriteLine("Сумма натуральных элементов в диапазоне от " + firstNumber + " до " + secondNumber + ": " + sum);