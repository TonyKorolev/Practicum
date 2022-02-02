void PrintArray(int[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Массив пустой!");
        return;
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

