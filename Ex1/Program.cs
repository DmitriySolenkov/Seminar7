int[,] PrintArrayArray(int length1, int length2)
{
    int[,] array = new int[length1, length2];
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

int[,] arr = PrintArrayArray(3, 4);

for (int k = 0; k < arr.GetLength(0); k++)
{
    for (int l = 0; l < arr.GetLength(1); l++)
    {
        Console.Write($"{arr[k, l]} ");
    }
    Console.WriteLine();
}