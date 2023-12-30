int M = 1;
int N = 100;
PrintNumbersInRange(M, N);
Console.ReadLine();
void PrintNumbersInRange(int first, int sec)
{
    if (first <= sec)
    {
        Console.WriteLine(first);
        PrintNumbersInRange(first + 1, sec);
    }
}