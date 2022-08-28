int[,] FillMatrix(int length1, int length2)
{
    int[,] array = new int[length1, length2];
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}

int Prompt(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

void PrintMatrix(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[k, l]}\t");
        }
        Console.WriteLine();
    }
}


int[,] matrix = FillMatrix(Prompt("Введите число строк: "), Prompt("Введите число колонок: "));
int search = Prompt("Введите искомое число: ");
PrintMatrix(matrix);
Console.WriteLine();
int resI = 0;
int resJ = 0;
bool check = false;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == search)
        {
            resI = i;
            resJ = j;
            check = true;
            Console.WriteLine($"Первое вхождение числа: [{resI}, {resJ}]");
            break;
        }

    }
    if (check == true)
    {
        break;
    }
}
if (check == false)
{
    Console.WriteLine("Данного числа в массиве нет!");
}