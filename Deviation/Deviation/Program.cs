using System;

namespace Deviation
{
    class Program
    {
        public static void Main(string[] args)
        {
                bool Exit = false;
                while (Exit == false)
                {
                    var foos1 = Console.ReadLine();
                    string[] arr1 = foos1.Split(',');

                    int d = Convert.ToInt16(Console.ReadLine());
                    double Median = getMedian(arr1, d);
                    Console.WriteLine(Median);
                }
        }

       public static double getMedian(string[] arr2, int size)
        {
            double result = 0;
            int l = arr2.Length;
            int j = 0;

            double[] Numbers2 = new double[l/ size];

            for (int i = 0; i < l-(size+1); i=(i+size))
            {
                double[] Numbers = new double[size];
                j = i;
                for (int x = 0; x < size; x++)
                {
                    Numbers[x] = Convert.ToDouble(arr2[j]);
                    j++;
                }

                double[] sortedPNumbers = (double[])Numbers.Clone();
                Array.Sort(sortedPNumbers);
     
                int mid = size / 2;
                double median1 = (size % 2 != 0) ? (double)sortedPNumbers[mid] : ((double)sortedPNumbers[mid] + (double)sortedPNumbers[mid - 1]) / 2;
                if (result < median1) { result = median1; }
            }
                return result;    
    }
  }
}
