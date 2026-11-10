using Tyuiu.StryzhakMA.Sprint4.Task7.V17.Lib;

namespace Tyuiu.StryzhakMA.Sprint4.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "753159864";

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Стрыжак М. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Вариант 17                                                              *");
            Console.WriteLine("* Выполнила: Стрыжак М. А. | АСОиУб-26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 753159864. Преобразуйте ее в матрицу  *");
            Console.WriteLine("* 3 на 3 и подсчитайте количество четных чисел                            *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, str);
            Console.WriteLine("Количество четных элементов = " + res);

            Console.ReadKey();
        }
    }
}
