using Tyuiu.StryzhakMA.Sprint4.Task0.V27.Lib;

namespace Tyuiu.StryzhakMA.Sprint4.Task0.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Стрыжак М. А. | АСОиУб-26-1"; 
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Вариант 27                                                              *");
            Console.WriteLine("* Выполнила: Стрыжак М. А. | АСОиУб-26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать               *");
            Console.WriteLine("* произведение нечетных элементов массива.{ 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 }*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetMultOddArrEl(numsArray);

            Console.WriteLine("Произведение нечетных элементов массива равно: " + res);

            Console.ReadKey();
        }
    }
}
