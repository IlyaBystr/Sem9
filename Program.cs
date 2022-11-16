/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
*/
/*
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N, 1));

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();

    return (start + " " + PrintNumbers(start - 1, end));

}
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от N до M.
*/

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine()!);

int Sum = N;
int Summa=SumNumbers(Sum, N, M);

Console.WriteLine($"сумму натуральных элементов в промежутке от {N} до {M} равна = {Summa}");

int SumNumbers(int Sum, int NumbN, int NumbM)
{
    if (NumbN == NumbM) return Sum;
    return SumNumbers(Sum = Sum + 1 + NumbN++, NumbN, NumbM);
}