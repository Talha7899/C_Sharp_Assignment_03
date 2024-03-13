using System.Security.Cryptography.X509Certificates;

namespace C_Sharp_Assignment_03
{
    internal class Program
    {
        /*
        Q.7:
        Write a function to calculate the area of a rectangle the length of the rectangle is 20cm and the width is 12cm.
        */

        public static double Area_of_Reactangle(double length, double width)
        {
            double area = length * width;
            return area;

        }

        static void Main(string[] args)
        {

            Program Area = new Program();
            Console.WriteLine($"Area of Rectangle is : {Program.Area_of_Reactangle(20,12)}cm.");

            /*
             Given Array = [1,3,42,20,97,65,88,43,64,20,12,48,24,38]
            Q.1: Find the sum of all the integers in the array.
             */

            //int[] arrInt = { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };
            //int sum = 0;
            //for (int i = 0; i < arrInt.Length; i++)
            //{
            //    sum += arrInt[i];
            //}
            //Console.WriteLine($"Sum of all integers in a given array = {sum}");


            /*
            Given Array = [1,3,42,20,97,65,88,43,64,20,12,48,24,38]
           Q.2: Find the maximum and minimum values in the array.
            */

            //int[] arrMax = { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };
            //Console.WriteLine($"Maximum value in a given array is : {arrMax.Max()}");

            //int[] arrMin = { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };
            //Console.WriteLine($"Minimum value in a given array is : {arrMax.Min()}");

            /*
            Given Array = [1,3,42,20,97,65,88,43,64,20,12,48,24,38]
           Q.3: Count the number of even and odd integers in the array.
             */

            //int[] count = { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };
            //int evenCount = 0;
            //int oddCount = 0;

            //for (int i = 0; i < count.Length; i++)
            //{
            //    Console.WriteLine(count[i]);

            //    if (count[i] % 2 == 0)
            //    {
            //        evenCount++;
            //    }
            //    else
            //    {
            //        oddCount++;
            //    }
            //}
            //Console.WriteLine($"No. of even integers in a given array is : {evenCount}");
            //Console.WriteLine($"No. of odd integers in a given array is : {oddCount}");

            /*
           Given Array = [1,3,42,20,97,65,88,43,64,20,12,48,24,38]
          Q.4: Calculate the average of all the integers in the array.
            */

            //int[] arrAvg = { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };

            //double Average = arrAvg.Average();
            //Console.WriteLine($"Average all given integers in a given array is : {Average}");

            /*
             Given Array = [1,3,42,20,97,65,88,43,64,20,12,48,24,38]
            Q.5: Check if a specific integer is present in the array.
            */

            //int[] checkInt = { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };
            //Console.WriteLine("Enter a number check the given number is present in the given array");

            //var userInput = Convert.ToInt32(Console.ReadLine());

            //if (userInput == checkInt[0])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else if (userInput == checkInt[1])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else if (userInput == checkInt[2])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else if (userInput == checkInt[3])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else if (userInput == checkInt[4])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else if (userInput == checkInt[5])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else if(userInput == checkInt[6])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");

            //}
            //else if(userInput == checkInt[7])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else if (userInput == checkInt[8])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else if(userInput == checkInt[9])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else if (userInput == checkInt[10])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else if(userInput == checkInt[11])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else if (userInput == checkInt[12])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else if (userInput == checkInt[13])
            //{
            //    Console.WriteLine($"Yes {userInput} is present in a given array.");
            //}
            //else
            //{
            //    Console.WriteLine($"No {userInput} is not present in a given array.");
            //}


            /*
             Create two dimensional Array.
            Q.6: Create a program that finds the sum of all elements in a two-dimensional array (matrix).
             */

            //int[,] ints = new int[3, 4]
            //{
            //    {35,41,26,11},
            //    {78,54,61,44}, 
            //    {1,3,5,7}
            //};

            //int sum = 0;

            //for (int i = 0; i < ints.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ints.GetLength(1); j++)
            //    {
            //        sum += ints[i,j];
            //    }
            //}
            //Console.WriteLine($"Sum of all integers in a two dimensional array is: {sum}");

        }
    }
}
