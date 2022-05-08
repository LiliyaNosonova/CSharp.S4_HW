// ДЗ ОБЯЗАТЕЛЬНО РЕШИТЬ:
// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 1 способ.Стихийный код

// int A = new Random().Next (-1000,1000);
// int q = 0;
// int newA = 0;
// int M = 0;
// int res = 0;
// M = Math.Abs(A);

// for (int n = 1; M > 0; n++)
// {
//     q = M % 10;
//     newA = newA * 10 + q;
//     M = M / 10;
//     res = res + q;
//     //System.Console.WriteLine($"{M,10} {q} {n}");
// }
// System.Console.WriteLine($"Сумма цифр числа {A} =  {res}");

// 2 способ.Методы

int Vvod(int N1) //Метод задания числа.
{
    int A1 = new Random().Next(-100, 100);
    return A1;
}

void Print(int N2)// Метод вывода данных
{
    System.Console.Write(N2);
}

int Modul(int A)// Метод нахождения модуля числа
{
    int mod = Math.Abs(A);
    return mod;
}

int RazSum(int B)// Метод разбора и суммирования цифр числа
{
    int q = 0;
    int res = 0;
    for (int n = 1; B > 0; n++)
    {
        q = B % 10;
        B = B / 10;
        res = res + q;
    }
    return res;
}

//============================================
int V = 0;
int N21 = Vvod(V);
int M = Modul(N21);
int Sum = RazSum(M);
//System.Console.WriteLine(M);
//System.Console.WriteLine($"Сумма цифр числа {N21} = {Sum}"); 1 вариант вывода результата
System.Console.Write($"Сумма цифр числа ");
Print(N21);
System.Console.Write($" равна ");
Print(Sum);
