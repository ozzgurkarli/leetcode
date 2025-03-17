using System;

class Program
{
    static void Main()
    {
        
    }

    private bool solution_2206_(int[] nums)
    {
        List<int> pairedIndexes = new List<int>();
        int pairIndex;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if(pairedIndexes.Contains(i))
                continue;

            pairIndex = findPair(nums, nums[i], i + 1, pairedIndexes);

            if (pairIndex == -1)
            {
                return false;
            }
            
            pairedIndexes.Add(pairIndex);
        }

        return true;
    }

    private int findPair(int[] nums, int num, int startIndex, List<int> pairedIndexes)
    {
        for (int i = startIndex; i < nums.Length; i++)
        {
            if (nums[i] == num && !pairedIndexes.Contains(i))
                return i;
        }

        return -1;
    }
}