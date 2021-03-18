using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraybasic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            
           /* for(int i =0; i<array1.Length;  i++)
            {
                array1[i] = i + 1;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }*/
            int[,] array2 = new int[3,4];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; i++)
                {
                    array2[i, j] = i + 100;
                }
            }
            int[,] arr5 = { { 1, 2 }, { 23, 3 }, { 4, 5 }, { 6, 7 } };
            Console.WriteLine(arr5[1, 0]);

        }
        
    }
}
