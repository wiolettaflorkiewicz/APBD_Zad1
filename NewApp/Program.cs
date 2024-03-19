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

    double sum = 0;
    foreach (int num in numbers)
    {
        sum += num;
    }
    return sum / numbers.Length;
}
