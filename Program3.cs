class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        rev(arr, arr.Length - 1);
        Console.ReadLine();
    }
    static void rev(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + ",");
            rev(arr, index - 1);
        }
    }
}