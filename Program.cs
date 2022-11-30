/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {num} -> ");
void ShowNumbers(int num)
{
    Console.Write(num + ", ");
    if (num > 1) ShowNumbers(num - 1);
}

ShowNumbers(num);
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Enter the number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int CalculateSum(int m, int n)
{
    int start = m;
    int end = n;
    if(m > n)
    {
        start = m;
        end = n;
    }
return (end + start)*(end - start + 1)/2;    
}

Console.WriteLine("The sum of natural elements between M and N: " + CalculateSum(m, n));
Console.WriteLine();