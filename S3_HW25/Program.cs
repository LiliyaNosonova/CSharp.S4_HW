// ДЗ ОБЯЗАТЕЛЬНО РЕШИТЬ: 25. Найти сумму чисел от 1 до А

// // 1 способ. Стихийный код
// int A = new Random().Next(1, 10);
// int sum = 0;
// for (int i = 1; i < A; i++)
// {
//     sum = ((A + 1) / 2) * A;
// }
// System.Console.WriteLine($"Сумма арифметической прогрессии от 1 до {A} равна {sum}");


// 2 способ. Методы
int ArProgress(int N)
{
    int sum1 = 0;
    for (int ii = 1; ii < N; ii++)
    {
        sum1 = ((N + 1) / 2) * N;
    }
    return sum1;
}
// =======================================
int A = new Random().Next(1, 10);
int sum = ArProgress(A);
System.Console.WriteLine($"Сумма арифметической прогрессии от 1 до {A} равна {sum}");