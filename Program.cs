//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Stepen(int number, int stepen)
{
    int res = number;
    for (int i = 1; i < stepen; i++)
    {
        res *= number;
    }
    return res;
}

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int num = InputNum("Введите целое число: ");
int step = InputNum("Введите степень числа: ");
int result = Stepen(num, step);
Console.WriteLine($"Степень числа {num} равна {result}.");
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Sum(int num)
{
    int res = 0;
    while (num != 0)
    {
        res += num % 10;
        num /= 10;
    }
    return res;
}

int num = InputNum("Введите целое число: ");
int result = Sum(num);
Console.WriteLine($"Сумма цифр числа {num} равна {result}.");