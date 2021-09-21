using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest
{
    class PoleMinMax
    {
        Random rd = new Random();
        private int n;
        private int i;
        private int max;
        private int min;
        public void MinMax(int n)
        {
            this.n = n;
            int[] array = new int[n];
            for (i = 0; i < n; i++)
            {
                array[i] = rd.Next(1, 100);
            }

            max = array[0];
            min = array[0];
            for (i = 0; i < n; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
                if(array[i] < min)
                {
                    min = array[i];
                }
                Console.WriteLine("Maximální hodnota je: " + max);
                Console.WriteLine("Minimální hodnota je: " + min);
            }
        }
    }
}
