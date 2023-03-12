static void Task64()
{
    /*Задача 64: Задайте значение N. Напишите программу, 
    которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

    int PutNumber(string message)
    {
        System.Console.WriteLine(message);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    string ReturnNumber(int n)
    {
        if (n == 1) return 1 + " ";  
        return n + " " + ReturnNumber(n - 1);
    }
    
    System.Console.WriteLine(ReturnNumber(PutNumber("Введите n: ")));
    }


    static void Task66()
    {
        /*Задача 66: Задайте значения M и N. Напишите программу, которая 
        найдёт сумму натуральных элементов в промежутке от M до N.
        M = 1; N = 15 -> 120
        M = 4; N = 8. -> 30*/

        int PutNumber(string message)
        {
            System.Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        int SumNumber(int m, int n)
        {
            if (m == n) return n;  
            return m + SumNumber(m + 1, n);
        }
        
        System.Console.WriteLine(SumNumber(PutNumber("Введите M:  "), PutNumber("Введите N: ")));

}

static void Task68()
{
    /*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    Даны два неотрицательных числа m и n. 
    m = 2, n = 3 -> A(m,n) = 29*/
    int PutNumber(string message)
    {
        System.Console.WriteLine(message);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    int Akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
        else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
        return Akkerman(m, n);
    
    }
    System.Console.WriteLine(Akkerman(PutNumber("Введите M:  "), PutNumber("Введите N: ")));
}
Task64();





