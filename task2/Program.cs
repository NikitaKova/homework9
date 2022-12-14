// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write(message + " > ");
    return int.Parse(Console.ReadLine());
}

int PrintNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    return m + PrintNumbers(m + 1, n);
}

int m = Prompt("Enter num ");
int n = Prompt("Enter num ");
int sum = 0;
sum = PrintNumbers(m, n);
Console.WriteLine(sum);