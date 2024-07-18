public class SetOne {

    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        /*
        You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, 
        and two integers m and n, representing the number of elements in nums1 and nums2 
        respectively.

        Merge nums1 and nums2 into a single array sorted in non-decreasing order.

        The final sorted array should not be returned by the function, but instead be 
        stored inside the array nums1. To accommodate this, nums1 has a length of m + n, 
        where the first m elements denote the elements that should be merged, and the 
        last n elements are set to 0 and should be ignored. nums2 has a length of n.
        */
        
        for (int i = 0; i < n; i++)
        {
            nums1[i + m] = nums2[i];
        }

        Array.Sort(nums1);
    }

    public int RemoveElement(int[] nums, int val) {
        /*
        Given an integer array nums and an integer val, remove all occurrences of 
        val in nums in-place. The order of the elements may be changed. Then return 
        the number of elements in nums which are not equal to val.

        Consider the number of elements in nums which are not equal to val be k, 
        to get accepted, you need to do the following things:

        - Change the array nums such that the first k elements of nums contain the 
          elements which are not equal to val. The remaining elements of nums are not 
          important as well as the size of nums.

        - Return k.
        */

        int counter = 0;
        for(int i = 0; i < nums.Length; i++) 
        {
            if (nums[i] == val) 
                nums[i] = -1;
            else 
                counter++;
        }

        nums.Sort();
        nums.Reverse();
        return counter;
    }
}