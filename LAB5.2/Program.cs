// Скрипников варинт 17 ИСП 2.1
using System;

class A
{
    static void Main()
    {
        int sum = 0;

        int[,] mas = {{1,2,3,4,5},
                      {6,7,8,9,10},
                      {11,12,13,14,15},
                      {-1,-3,-8,-10,-15}
                     };

        for (int i = 0; i < mas.Length / 4 - 1; i++)        
            for (int j = 0; j < mas.Length / 8 - 1; j++)   
                sum += mas[i, j];

        Console.WriteLine("Среднее геометрическое положение матрицы " + (double)sum / mas.Length);
        Console.ReadKey();
    }
}
