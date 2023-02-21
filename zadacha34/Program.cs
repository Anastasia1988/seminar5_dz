// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
// 
int[] Count (int[] array)
{
    int[] result = new int[2];
    for(int i = 0; i <array.Length; i ++)
    {
        if(array[i] % 2 == 0)
        {
            result[0] ++;
        }
    }
    return result;
}

int[] myMass = Massiv(12,99,1000);
PrintArray(myMass);
int[] Kol = Count(myMass);
System.Console.WriteLine($" Количество четных чисел в массиве равна {Kol[0]}");

