// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N. 
//Выполнить с помощью рекурсии.

Console.WriteLine("Input first number M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Input first number N:");
int numberN = int.Parse(Console.ReadLine());

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Sum of elements between M and N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);




//Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.WriteLine("Input natural number > 1:");
int number = int.Parse(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} not natural number");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

NumberCounter(number);




