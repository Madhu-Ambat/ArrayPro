using System;

namespace ArrayPro
{
    class Program
    {

        public static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12 };

            ReversePro revObj = new ReversePro();

            // Calling the reverse function
            /*  numArray = revObj.ReverseFunction(numArray);*/

        


            // Rotation of an Array

            RotationOfArray rotObj = new RotationOfArray();

            // Calling the rotate function

          /*  numArray = rotObj.rightCircularRoatate(numArray);*/


    /*        Console.WriteLine("--------------------------------------------------");

            foreach (int num in numArray)
            {
                Console.Write(num + ",");
            }*/

            // Modify an array

            ModifyArray modObj = new ModifyArray();

            // Calling get position
            /*
                        Console.WriteLine("---------");
                        Console.WriteLine(modObj.elementSearch(13,numArray));*/

            subArrays modSub = new subArrays();

            /* numArray =  modSub.CreateSubArray(5,numArray);*/



            /*
                        ArraySort sortObj = new ArraySort();
                        numArray = sortObj.SortArray(numArray);
                        Console.WriteLine("--------------------------------------------------");*/

            int[] newNumArray = modObj.removeElemenyAtPos(11, numArray);

            foreach (int num in newNumArray)
            {
                Console.Write(num + ",");
            }
        }

    }
}

