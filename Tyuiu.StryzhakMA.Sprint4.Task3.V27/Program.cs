using Tyuiu.StryzhakMA.Sprint4.Task3.V27.Lib;

namespace Tyuiu.StryzhakMA.Sprint4.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Стрыжак М. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Вариант 27                                                              *");
            Console.WriteLine("* Выполнила: Стрыжак М. А. | АСОиУб-26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 7. Подсчитайте количество   *");
            Console.WriteLine("* четных элементов во всем массиве.                                       *");

            int[,] array = new int[5, 5]
            {
                { 4, 3, 5, 5, 3 },
                { 6, 7, 4, 4, 3 },
                { 3, 3, 7, 3, 6 },
                { 3, 4, 3, 7, 7 },
                { 3, 5, 6, 3, 6 }
            };

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            

            int res = ds.Calculate(array);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество четных элементов = " + res);

            Console.ReadKey();
        }
    }
}
