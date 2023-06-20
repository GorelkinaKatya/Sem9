string printNumbers(int n)
{
    if (n == 1)
        return $"{n}";
    return $"{n}, " + printNumbers(n - 1);
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNumbers(n));