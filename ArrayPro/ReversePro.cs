using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPro
{
    internal class ReversePro
    {
        // Algorithm to reverse  the array !

        public int[] ReverseFunction(int[] numArray)
        {
            // Algorithm to reverse  the array !

             int arrayLength =  numArray.Length;
             decimal limiter = Math.Ceiling((Decimal)arrayLength / 2);
            int left, right = arrayLength-1, temp=0;

          
                //Array having even length

                for(left=0; left< limiter;left++)
                {
                    temp = numArray[left];
                    numArray[left]=numArray[right];
                    numArray[right] = temp;
                    right--;
                }
                

           
            return numArray;
            
        }

    }
}
