// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
double[] Massiv(int size)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble(), 3);
    }
    return array;
}

void printMassiv(double[] array)
{

    System.Console.WriteLine("[" + string.Join(";", array) + "]");
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double MinNumber(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] myMass = Massiv(12);
printMassiv(myMass);
System.Console.WriteLine($"Максимальное число массива:{MaxNumber(myMass)}");
System.Console.WriteLine($"Минимальное число массива:{MinNumber(myMass)}");
System.Console.WriteLine($"Разница чисел равна:{MaxNumber(myMass)-MinNumber(myMass)}");


