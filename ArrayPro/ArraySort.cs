using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPro
{
    internal class ArraySort
    {
        public int[] SortArray(int[] numArray)
        {
            int arrayLength = numArray.Length;

            for (int i = 0; i < arrayLength - 2; i++)
            {
                if(numArray[i] > numArray[i + 1])
                {
                    int temp = numArray[i];
                    numArray[i] = numArray[i + 1];
                    numArray[i + 1] = temp;
                }
            }

            return numArray;

        }
    }
}
