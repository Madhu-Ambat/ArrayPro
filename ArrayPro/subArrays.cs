using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPro
{
    internal class subArrays
    {
        public int[] CreateSubArray(int pos,int[] numArrays)
        {
            int oriArrayLength = numArrays.Length;
          

            if(pos ==0 || pos > oriArrayLength+1)
            {
                Console.WriteLine("Invalid index number ! ");
                return new int[0];
            }
            // This module will return a subarray starting from the point given by end user all the way up to the end of the array
         
                int SubLength = oriArrayLength - (pos - 1);
                int[] subArray = new int[SubLength];
                int j = 0;
                for (int i = (pos - 1); i < oriArrayLength; i++)
                {
                    subArray[j] = numArrays[i];
                    j++;
                }

                return subArray;
    

        }
    }
}
