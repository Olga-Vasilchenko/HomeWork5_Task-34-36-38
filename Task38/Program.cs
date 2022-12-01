// Задача 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] RndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(arr[i], 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double CraetArrayRndDouble(double[] arr)
{
    double max = 0;
    double min = 0;
    double dif = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            min = max;
        }
        else if (arr[i] < min) min = arr[i];
        dif = max - min;
    }
    return dif;
}

double[] array = RndDouble(5, 0, 100);
PrintArray(array);
double craetArrayRndDouble = CraetArrayRndDouble(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {craetArrayRndDouble}");
