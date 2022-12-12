//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int MathPow(int num1, int num2)
{
    int  number = num1;
    while(num2 > 1)
    {
        num1 = num1 * number;
        num2--;
    }
    return num1;
}

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int ans = MathPow(number1, number2);

Console.WriteLine($"Степень числа {number1} ровна {ans}.");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumNumber(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ans = SumNumber(number);

Console.WriteLine($"Сумма числа {number} ровна {ans}.");
*/

