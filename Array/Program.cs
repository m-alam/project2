using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Practice");
            // Normal Array
            int[] number = new int[10];
            number = new int[]{ 2,4,7,8,9};
            Console.WriteLine($"{number[0]} {number[1]}");
            string[] names = new string[] { "Mahabub", "Alam", "Sahadat", "Taj" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            int[] ages = { 1, 4, 7, 9 };

            // Multi dimentional Array
            //3 row 3 column
            int[,] nums = new int[3,3];
            nums[0, 0] = 1;
            nums[0, 1] = 2;
            nums[0, 2] = 3;
            nums[1, 0] = 4;
            nums[1, 1] = 5;
            nums[1, 2] = 6;
            nums[2, 0] = 7;
            nums[2, 1] = 8;
            nums[2, 2] = 9;

            int[,] twoDArry = new int[,]
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12 }
            };

            Console.WriteLine(twoDArry[2,1]);
            //3d Array
            //string[,,] books = new string[3, 4, 3]
            //{
            //    {{"1","2","3" } ,{ },{ },{ } },
            //    {{ } ,{ },{ },{ } },
            //    {{ } ,{ },{ },{ } },
            //}
            string[] fruits = new string[] { "Apple", "Banana", "mango" };
            string[] places = new string[] { "Dhaka", "Chapai", "Uttara" };

            foreach(string fruit in fruits)
            {
                foreach(string place in places)
                {
                    if()
                }
            }
        }
    }
}
