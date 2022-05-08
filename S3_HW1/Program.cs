// ДЗ ОБЯЗАТЕЛЬНО РЕШИТЬ:
//Задача 1: Напишите цикл, который принимает 
//на вход два числа (A и B) и возводит число A в натуральную степень B.

int A = new Random().Next(-10, 10);
int B = new Random().Next(0, 10);

// Цикл while
//int i = 1;
//int res = 1;
// while (i <= B)
// {
//     res = res * A;
//     i = i + 1;
// }

// Цикл for
// int res = 1;
// for (int i = 1; i <= B; i++)
// {
//     res = res * A;
// }


int Stepen (int x, int y)// Метод возведения в заданного числа в заданную степень
{
    int res1 = 1;
    for (int n = 1; n <= y; n++)
    {
        res1 = res1 * x;
    }
    return res1;
}
int res = Stepen (A, B);
if (B == 0) res = 1;

System.Console.WriteLine($"Число {A} в cтепени {B} равно {res}");