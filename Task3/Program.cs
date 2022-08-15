// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void InputArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {    
        Console.Write($"Введите {i+1}е число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
System.Console.WriteLine($"Введенный массив: {String.Join(" ",array)}");
}
Console.Write("Введите размер массива: ");
InputArray(Convert.ToInt32(Console.ReadLine()));