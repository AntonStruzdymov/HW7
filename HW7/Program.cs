int[] first = new int[6];
for (int i = 0; i< first.Length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    first[i] = int.Parse(Console.ReadLine());
}
for (int b = 0; b < first.Length; b++)
{
    for (int i = 0; i < first.Length - 1; i++)
    {
        if (first[i] < first[i + 1])
        {
            int c = first[i];
            first[i] = first[i + 1];
            first[i + 1] = c;
        }
    }
}
for (int i = 0; i < first.Length; i++)
{
    Console.WriteLine(first[i]);
}