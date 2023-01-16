using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPro
{
    internal class RotationOfArray
    {

        public int[] rightCircularRoatate(int[] numArray)
        {
            int arrayLength = numArray.Length;
            int temp = numArray[arrayLength - 1];

            for(int i = arrayLength-2; i>0 ;i--)
            {
                numArray[i+1] = numArray[i];
            }

            numArray[0] = temp;

            return numArray;
        }

        public int[] leftCircularRotate(int[] numArray)
        {
            int arrayLength = numArray.Length;
            int temp = numArray[0];

            for(int i = 0; i< arrayLength-1; i++)
            {

                numArray[i] = numArray[(i+1)];
            }

            numArray[arrayLength - 1] = temp;
            return numArray;
        }
    }
}
