int sumNumbers(int n, int m)
{
    if (n == m)
        return n;
    return sumNumbers(n + 1, m - 1) + n + m;
}

Console.Clear();
Console.Write("Введите 1-e число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-e число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(sumNumbers(n, m));