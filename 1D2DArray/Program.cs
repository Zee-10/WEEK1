using System.Globalization;
using System.IO.Pipes;
using System.Runtime.Serialization.Formatters;

namespace _1D2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] number = { 1, 2, 4, 5, 6, 7, 8 };
            foreach (int num in number) {
                count++;
            }
            System.Console.WriteLine("The Length of the 1D array = "+count);

            int[,] twoArray = {
                                  {1,2,3}, 
                                  {4,5,6} 
                                ,{7,8,9},
                                  {10,11,12}
                                };
            int countTotal = 0;
           
            // Getlength(0) is for the rows 
            // GetLength(1) is for columns
            
            for (int n = 0; n < twoArray.GetLength(0); n++ ) {
                
                for (int t = 0; t < twoArray.GetLength(1); t++) {
                    countTotal++;
                   
                }
            }
            Console.WriteLine("The Total Number of elements in 2D Array = " + countTotal + "\nThe Total Number of Rows =" + twoArray.GetLength(0) + "\nThe Total Number of Cols = " + twoArray.GetLength(1) );

            // Find the Max Numbers
            // CYCLIC sort works only in 1 to n 
            int[] nums = { 2, 4, 3, 6, 5,7 , 1 };
            int temp = 0;
            for (int n = 0; n < nums.Length-1; n++)
            {
                
                if (nums[n] > nums[n + 1]) {
                    temp = nums[n];
                    nums[n] = nums[n + 1];
                    nums[n + 1] = temp;
                    // SWAP
                }
            }
            Console.WriteLine("The Largest element in the array is = " + nums[nums.Length-1]);
            Console.WriteLine("The Smallest element in the array is = " + nums[0]);
            foreach (int n in nums) {
                Console.Write(n+" ");
            }


            int max = nums[0];
            int min = nums[0];

            foreach (int nn in nums) {
                if (max < nn) { 
                    max = nn;
                }
            }
            foreach (int nn in nums)
            {
                if (min > nn)
                {
                    min = nn;
                }
            }

            Console.WriteLine("\nTHE LARGEST NUMBER IS = " + max + "\n THE SMALLEST NUMBER IS = " + min);

            // Reverse of an Array
            int[] rev = [5, 4, 32, 1];
            int left = 0;
            int right = rev.Length - 1;
            while(left<right)
            {
                temp = rev[left];
                rev[left] = rev[right];
                rev[right] = temp;

                left++;
                right--;

            
            }
            foreach (int r in rev) { 
            Console.Write(r+" "); 
            }
            string word = "12";
            string[] names = { "Nanthinee", "Zeeshan", "Sultan", "12" };
            for (int g =0; g<names.Length; g++) {
                if (names[g] == word) {
                    Console.WriteLine("\nThe Word was found at the index = "+ g );
                }
            }
        }
        }

  

        

    }

