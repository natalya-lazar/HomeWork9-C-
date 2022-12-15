//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//Решение:

/*void ShowNumbers (int n)
{
    Console.Write(n + ", ");
    if (n > 1) ShowNumbers(n - 1);
}
Console.WriteLine("Input N: ");
int user_n = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {user_n} -> ");
ShowNumbers(user_n);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
//Решение:

/*int SumMN(int m, int n)
{
    if (Math.Max(m, n) == Math.Min(m, n)) return Math.Max(m, n);
    return SumMN(Math.Min(m, n) + 1, Math.Max(m, n)) + Math.Min(m, n);
}
Console.WriteLine("Input M: ");
int user_m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N: ");
int user_n = Convert.ToInt32(Console.ReadLine());
int sum = SumMN(user_m, user_n);
Console.WriteLine($"M = {user_m}; N = {user_n} -> {sum}");
*/

//Задача: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную
//Решение:

void System (int a)
{
    if (a == 0) return;
    System(a / 2);
    if (a % 2 == 0) Console.Write(0);
    else Console.Write(1);
}
Console.WriteLine("Input a: ");
int user_a = Convert.ToInt32(Console.ReadLine());
System(user_a);

//Задача 68: дополнительно Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
