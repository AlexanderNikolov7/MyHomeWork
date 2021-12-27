// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8.

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 8);
    }
}
int[] array = new int[15];

int count = 0;
int num = 8;
void Result(int[] arr, int[] newArr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > num)
        {
            newArr[i] = arr[i];
            Console.Write($"{newArr[i]} ");
            count++;
        }
    }
}

FillArray(array);
PrintArray(array);
int[] arr = new int[15];
System.Console.WriteLine();
Result(array, arr);
if (count == 0)System.Console.WriteLine("Цифр болбше 8, в первом массиве не существует!");
