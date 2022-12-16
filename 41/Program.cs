// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите любое число : ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите любое число : ");
int B = int.Parse(Console.ReadLine()!);
Console.Write("Введите любое число : ");
int C = int.Parse(Console.ReadLine()!);
Console.Write("Введите любое число : ");
int D = int.Parse(Console.ReadLine()!);
Console.Write("Введите любое число : ");
int E = int.Parse(Console.ReadLine()!);
int[] massive = { A, B, C, D, E };
int l = massive.Length;
Console.WriteLine($"{A},{B},{C},{D},{E} -> {Numbers(A, B, C, D, E)}");

int Numbers(int a, int b, int c, int d, int e)
{
    int count = 0;
    foreach (int el in massive)
    {
        if (el > 0)
            count++;
    }
    return count;
}