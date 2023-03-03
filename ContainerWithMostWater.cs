using System;
namespace Interview
{
    public class ContainerWithMostWater
    {
        public int GetMaxArea(int[] arr)
        {
            int maxArea = 0;
            int currentArea = 0;
            int a = 0;
            int b = arr.Length - 1;

            while(a != b)
            {
                
                if (arr[a] < arr[b])
                {
                    currentArea = arr[a] * (b - a);
                    a++;
                }
                else
                {
                    currentArea = arr[b] * (b - a);
                    b++;
                }
                if(currentArea > maxArea)
                {
                    maxArea = currentArea;
                }
            }

            if(arr.Length == 0 || arr.Length == 1)
            {
                return 0;
            }

            
            return maxArea;
        }

    }
}

