 public int[] TwoSum(int[] nums, int target) {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int i=0;i<nums.Length;i++)
                {
                    var tempValue = target - nums[i];
                    if(dict.ContainsKey(tempValue))
                    {
                        return new int[]{dict[tempValue],i};
                    }
                    
                    if (dict.ContainsKey(nums[i]) == false)
                    {
                        dict.Add(nums[i], i);
                    }
                     
                 }
            return null;
        }