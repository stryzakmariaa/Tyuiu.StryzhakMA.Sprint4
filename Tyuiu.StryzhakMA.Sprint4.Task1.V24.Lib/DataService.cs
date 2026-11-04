using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.StryzhakMA.Sprint4.Task1.V24.Lib
{
    public class DataService : ISprint4Task1V24
    {
        public int Calculate(int[] array)
        {
            int multArray = 1;
            bool hasOdd = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    multArray *= array[i];
                    hasOdd = true;
                }
            }
            return hasOdd ? multArray : 0;
        }
    }
}
