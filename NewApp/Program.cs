// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Modyfikacja 1");
Console.WriteLine($"Aktualna data i godzina: {DateTime.Now}");

Console.WriteLine("Modyfikacja 2");
static int Suma(int a, int b)
{
    return a + b;
}

Console.WriteLine($"Suma 3 + 4 = {Suma(3, 4)}");

Console.WriteLine("Modyfikacja 3");
int i = 0; 

while (i < 10) 
{
    Console.WriteLine("i = {0}", i);

    i++;
}

Console.WriteLine("feature-average");

static double getAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        throw new ArgumentException("it cannot be an empty table", nameof(numbers));

    double totalSum = 0;
    foreach (int num in numbers)
    {
        totalSum += num;
    }
    return totalSum / numbers.Length;
}

static int getMaxValue(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("it cannot be an empty table");
    }

    int maxValue = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > maxValue)
        {
            maxValue = numbers[i];
        }
    }
    return maxValue;
}

