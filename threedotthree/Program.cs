int[,] arr = new int[7, 4];
int firstIndex = -1;
int secondIndex = 0;

Random r = new Random();

for (int i = 0; i < 4; i++)
{
    for(int j = 0; j < 7; j++)
    {
        arr[j, i] = r.Next(100, 1000);
        int max = arr[0, 0];
        Console.Write(arr[j, i] + " ");
        if (j == 0 && i == 0) continue;
        if (arr[j, i] > max)
            firstIndex= j;
            secondIndex= i;
    }
    Console.WriteLine();
}

Console.WriteLine($"Сумма индексов максимального элемента матрицы равна: {firstIndex + secondIndex}");