// See https://aka.ms/new-console-template for more information

namespace Interview
{
   internal class Program
    {
        static void Main(string[] args)
        {
            //TwoSum
            //int[] arr = {1,2,6,3,4};
            //int target = 7;
            //TwoSum twoSum = new TwoSum(arr, target);
            //int[] results = twoSum.GetTwoSum();
            //Console.WriteLine(results[0] + " " + results[1]);


            //ContainerWithMostWater
            int[] arr = { 1, 1, 7, 3, 9 };
            ContainerWithMostWater container = new ContainerWithMostWater();
            int maxArea = container.GetMaxArea(arr);
            Console.WriteLine(maxArea);
        }

       
    }
}

