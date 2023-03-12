static void Task65()
{
/*Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"*/


int PutNumber(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string ReturnNumber(int m, int n)
{
    if (m == n)
    return n + " ";  
    else 
    return m + " " + ReturnNumber(m + 1, n);
}
ReturnNumber(4, 8);
System.Console.WriteLine(ReturnNumber(PutNumber("Введите m:  "), PutNumber("Введите n: ")));
}

static void Task67()
{
    /*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/
    int PutNumber(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
    int SumNumbers(int number)
    {
        if (number == 0)
        return 0;
        else
        return number % 10 + SumNumbers(number / 10);
    

        
    }
    System.Console.WriteLine(SumNumbers(PutNumber("Введите число: ")));
}
Task67();




/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 29*/
