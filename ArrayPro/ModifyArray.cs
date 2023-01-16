using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPro
{
    internal class ModifyArray
    {



        public int elementSearch(int ele,int[] numArray)
        {
            // Search of first instance only 
            int i = 0;
            foreach (int num in numArray)
            {
                if(num == ele)
                {
                    return i;
                }
                i++;
            }

            return -1; // If element not present inside
        }

        public int[] insertElementAtPos(int ele, int pos, int[] numArray)
        {
            subArrays subObj = new subArrays();

            int[] tempHolder = subObj.CreateSubArray(pos, numArray);


            if(tempHolder.Length == 0 && pos != numArray.Length + 1)
            {
                Console.WriteLine(":))))");
                return new int[0];
            }

            if(pos == numArray.Length+1)
            {
                int[] newNumArray = new int[numArray.Length + 1];

                for(int i = 0; i< numArray.Length; i++)
                {
                    newNumArray[i] = numArray[i];
                }

                newNumArray[numArray.Length ] = ele;
                return newNumArray;
            }
            else
            {
                numArray[pos - 1] = ele;

                int[] newNumArray = new int[numArray.Length + 1];

                for (int i = 0; i <= pos - 1; i++)
                {
                    newNumArray[i] = numArray[i];
                }

                int k = 0;
                for (int j = pos; j < numArray.Length + 1; j++)
                {
                    newNumArray[j] = tempHolder[k];
                    k++;
                }

                return newNumArray;


            }


        }

        public int[] removeElemenyAtPos(int pos, int[] numArray)
        {

            int arrayLength = numArray.Length;

            subArrays subObj = new subArrays();

            int[] newShortArray = new int[arrayLength-1];



            if(pos == 1)
            {
                for(int i = 0; i < arrayLength-1; i++)
                {
                    newShortArray[i] = numArray[i + 1];
                }

                return newShortArray;

            }
            else if(pos == arrayLength)
            {
                for (int i = 0; i < arrayLength-1; i++)
                {
                    newShortArray[i] = numArray[i];
                }

                return newShortArray;
            }
            else
            {

                int[] tempHolder = subObj.CreateSubArray(pos + 1, numArray);

                for(int i =0; i< pos-1; i++)
                {
                    newShortArray[i] = numArray[i];
                }

                int k = 0;
                for(int i = pos-1; i< arrayLength-1;i++)
                {
                    newShortArray[i] = tempHolder[k];
                    k++;
                }

                return newShortArray;
            }
            
            
        }

    }

}
