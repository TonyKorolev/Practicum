void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}


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

