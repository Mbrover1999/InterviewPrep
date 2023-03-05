using System;
namespace Interview
{
    public class ContainerWithMostWater
    {
        public int GetMaxArea(int[] height)
        {
            int maxArea = 0;
            int a = 0;
            int b = height.Length - 1;

            if (height.Length == 0 || height.Length == 1)
            {
                return 0;
            }


            while (a != b)
            {
                int currentHeight = Math.Min(height[a], height[b]);
                int currentWidth = b - a;
                int currentArea = currentHeight * (b - a);
                maxArea = Math.Max(maxArea, currentArea);
                if (height[a] < height[b])
                {
                    a++;
                }
                else
                {
                    b--;
                }
            }

            return maxArea;
        }

    }
}

