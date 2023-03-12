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
Task65();
