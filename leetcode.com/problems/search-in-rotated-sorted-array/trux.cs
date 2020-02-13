public  int Search(int[] nums, int target) {
        if(nums.Length != 0 )
        {
            if(target > nums[0])
            {
                for(int i=0;i<nums.Length;i++)
                {
                    if(target == nums[i])
                    {
                        return i;
                    }
                }
            }else {
         
                for(int i=nums.Length -1;i >= 0; i--)
                {

                    if(target == nums[i])
                    {
                        return i;
                    }
                }
            }
        }
            return -1;
        }