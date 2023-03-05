using System;
namespace Interview
{
    public class TrappingRainWater
    {
        public int getTrappedRainWaterArea(int[] height)
        {
            if (height.Length == 0 || height.Length == 1 || height.Length == 2)
            {
                return 0;
            }
            int pLeft = 0;
            int pRight = height.Length - 1;
            int waterTrapped = 0;
            int maxRight = height[pRight];
            int maxLeft = height[pLeft];

            while (pLeft < pRight)
            {
                if (height[pLeft] <= height[pRight])
                {
                    if (height[pLeft] >= maxLeft)
                    {
                        maxLeft = height[pLeft];
                    }
                    else
                    {
                        waterTrapped += maxLeft - height[pLeft];
                    }
                    pLeft++;
                }
                else
                {
                    if (height[pRight] >= maxRight)
                    {
                        maxRight = height[pRight];
                    }
                    else
                    {
                        waterTrapped += maxRight - height[pRight];

                    }

                    pRight--;


                }
            }
            return waterTrapped;

        }
    }
}

