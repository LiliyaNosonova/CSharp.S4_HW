// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


// //1 способ.Без методов
// //int[] array = new int[8] { 1, 2, 3, 4, 5, 68, 9, 5 };// 1 вариант задания массива из конкретных 8-ми элементов

// int[] array = new int[8];// 2 вариант задания массива с количеством элементов,
//                                        // зависящим от длины массива
// for (int index = 0; index < array.Length; index++)
// {
//     array[index] = new Random().Next(0, 10);
// }

// // 3 вариант задания массива вручную пользователем (не рассматривается в данной задаче, но возможен)

// // Вывод массива
// for (int index = 0; index < array.Length; index++)
// {
//     System.Console.Write(array[index] + " ");// Вывод элементов массива в строку через пробел
// }


//2 способ. Методы

void NewArray(int[] Arr1)//Метод задания массива
{
    for (int count = 0; count < Arr1.Length; count++)
    {
        Arr1[count] = new Random().Next(0, 10);
    }
}


void PrintNewArray(int[] Arr2)// Метод вывода массива
{
    for (int position = 0; position < Arr2.Length; position++)
    {
        System.Console.Write(Arr2[position] + " ");
    }
}
//===============================================================
int[] Arr = new int[8];
NewArray(Arr);
PrintNewArray(Arr);