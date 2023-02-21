// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] Massiv(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange,rightRange); 
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

void Count(int[] array, out int sum)
{
    sum = 0;
    for(int i = 0; i <array.Length; i ++)
    {
        if(i % 2 != 0)
        {
           sum += array[i];
        }
    }
}

int[] myArray = Massiv (6, 100, 1000);
PrintArray(myArray);
Count (myArray, out int sum);
System.Console.WriteLine($"Сумма нечетных чисел массива равна {sum}");
