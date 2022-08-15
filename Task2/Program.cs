// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/* Сделал два метода, на первом методе при вводе 
11 знаков ошибка(наверное переполнения)
*/

int SumMethodInt(string number) //1 метод
{
    int numberInt = Convert.ToInt32(number);
    int sum = 0;
    while (numberInt > 0)
    {
        sum += numberInt % 10;
        numberInt /= 10;
    }
    return sum;
}

int SumMethodString(string number) // 2 метод
{
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        sum = sum + int.Parse("" + number[i]);
    }
    return sum;
}

Console.Write("Введите число: ");
string numberString = Console.ReadLine();
System.Console.WriteLine($"Сумма цифр в числе 1Метод: {SumMethodInt(numberString)}");
System.Console.WriteLine($"Сумма цифр в числе 2Метод: {SumMethodString(numberString)}");
