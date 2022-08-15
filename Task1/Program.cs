// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int MethodDegreeNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Число {number} в степени {degree} будет равно: {MethodDegreeNumber(number, degree)}");
