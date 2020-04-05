using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgo
{
    class ArrayEasy
    {
        public int A136_SingleNumber(int[] nums)
            {
                if (nums.Length == 1) 
        {
            return nums[0];
        }
        Array.Sort(nums);
         for (int i = 0; i < nums.Length; i++) 
         {           
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
                else
                {
                    i++;
                     if(i+1==nums.Length-1)
                        return nums[i+1];
                }
           
        }
        return -1;
        }

        public bool A202_IsHappy(int n) 
        {
            var visited = new Dictionary<int, bool>();
            var next = n;

            while (!visited.ContainsKey(next))
                {
                visited.Add(next,true);
                var start = next;
                next =0;
                while (start > 0)
                {
                    next += (start % 10) * ( start % 10);
                    start = start / 10;
                }

                if (next == 1) return true;
            }

            return false;
                }


        public int A53_MaxSubArray(int[] nums) {
        int size = nums.Length; 
        int max_so_far = int.MinValue,  
            max_ending_here = 0; 
  
        for (int i = 0; i < size; i++) 
        { 
            max_ending_here += nums[i]; 
              
            if (max_so_far < max_ending_here) 
                max_so_far = max_ending_here; 
              
            if (max_ending_here < 0) 
                max_ending_here = 0; 
        } 
          
        return max_so_far; 
        
    }


        public void A283_MoveZeroes(int[] nums)
        {
            int i = 0;
            int j = 0;

            while (j < nums.Length)
            {
                if (nums[j] != 0)
                {
                    nums[i++] = nums[j];
                }

                j++;
            }

            while (i < nums.Length)
            {
                nums[i++] = 0;
            }
        }

    }
             
           

}

        
 
