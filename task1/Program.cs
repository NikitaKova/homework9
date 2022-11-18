// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int PrintNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    System.Console.Write(m + " ");
    m = m + 2;
    return PrintNumbers(m, n);
}

int m = Prompt("Enter num ");
int n = Prompt("Enter num ");
if (m % 2 != 0) m = m + 1;
PrintNumbers(m, n);
