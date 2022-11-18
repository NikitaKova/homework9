// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int m = Prompt("Enter num m");
int n = Prompt("Enter num n");

void AkermanFun(int m, int n)
{
    Console.Write(AkFunction(m, n));
}

int AkFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkFunction(m - 1, 1);
    }
    else
    {
        return (AkFunction(m - 1, AkFunction(m, n - 1)));
    }
}
AkermanFun(m, n);