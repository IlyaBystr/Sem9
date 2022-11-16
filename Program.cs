Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N, 1));

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();

    return (start + " " + PrintNumbers(start - 1, end));

}