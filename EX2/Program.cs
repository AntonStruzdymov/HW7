int[,] second = { { 44, 56, 18 }, { 67, 45, 89 }, {126, 23,76 } };
for (int i = 0; i < 3; i++)
{   
    int max = 0;
    for (int j = 0; j < 3; j++)
    {
        if (second[i, j] > max)
        {
            max = second[i, j];
        }
    }
    Console.WriteLine($"Максимальный элемент в {i+1} строке: {max}");
}
