namespace Interview
{
    class TwoSum
    {
        private int[] nums;
        private int target;
        public TwoSum(int[] nums, int target)
        {
            this.nums = nums;
            this.target = target;
        }

        public int[] GetTwoSum()
        {
            Dictionary<int, int> passedValues = new Dictionary<int, int>();

            if (nums.Length == 0)
            {
                return null;
            }
            passedValues.Add(target - nums[0], 0);

            for (int i = 1; i < nums.Length; i++)
            {
                if (passedValues.ContainsKey(nums[i]))
                {
                    return new int[2] { passedValues[nums[i]], i };


                }
                passedValues.Add(target - nums[i], i);
            }


            return null;

        }
    }
}