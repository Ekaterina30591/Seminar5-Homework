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

