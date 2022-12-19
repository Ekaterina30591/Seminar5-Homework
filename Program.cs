/*
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

int CountEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count = count + 1;
    
    }

    return count;
}

Console.Write("Input number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum positive three digit value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum positive three digit value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
int result = CountEven(myArray);
Console.WriteLine($"Number of even numbers in array is {result}");
*/
/*
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

int OddIndexSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        sum = sum + array[i];
    }

    return sum;
}

Console.Write("Input number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
int result = OddIndexSum(myArray);
Console.WriteLine($"Sum of array elements witn odd index is {result}");
*/

// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
        
    for (int i = 0; i < size; i++)
    {
       array[i] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);
        
    }
    return array;
}

void ShowArray(double[] array)

{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

double Diff (double[]array)
{
    int iMax = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[iMax] < array[i])
        iMax = i;
    }
    int iMin = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[iMin] > array[i])
        iMin = i;
    }
    double arrayMax = array[iMax];
    double arrayMin = array[iMin];
    double result = arrayMax - arrayMin;

    return result;
}

Console.Write("Input number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

double result = Math.Round(Diff(myArray), 2);

Console.WriteLine($"Different between max and min elements of the array is {result}");
*/