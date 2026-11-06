using Tyuiu.StryzhakMA.Sprint4.Task2.V19.Lib;

namespace Tyuiu.StryzhakMA.Sprint4.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Стрыжак М. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Вариант 19                                                              *");
            Console.WriteLine("* Выполнила: Стрыжак М. А. | АСОиУб-26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный        *");
            Console.WriteLine("* случайными в диапазоне от 4 до 9 подсчитать сумму нечетных элементов    *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 14;
            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                numsArray[i] = rnd.Next(4, 10);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < len; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                if (numsArray[i] % 2 != 0)
                {
                    sum += numsArray[i];
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма нечетных элементов массива: {sum}");

            Console.ReadKey();

        }
    }
}
