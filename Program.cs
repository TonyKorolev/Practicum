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

int EvenCounter(int[] array)
{
    int evenCounter = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            evenCounter++;
        }
    }
    return evenCounter;
}

int[] GenerateNewArray(int[] array)
{
    int[] resultArray = new int[EvenCounter(array)];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

