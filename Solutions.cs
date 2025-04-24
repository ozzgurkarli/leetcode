namespace leetcode;

public partial class Leetcode
{
    public bool solution_2206_(int[] nums)
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

    public int[] solution_1769_(string boxes)
    {
        int[] output = new int[boxes.Length];
        int count;
        
        for (int i = 0; i < boxes.Length; i++)
        {
            count = 0;
            for (int j = 0; j < boxes.Length; j++)
            {
                if(i != j && boxes[j] != '0'){
                    count += (abs(i - j));
                }
            }

            output[i] = count;
        }

        return output;
    }
    
    public IList<string> solution_1233_(string[] folder)
    {
        List<string> output = new List<string>();

        List<string> folderPaths = new List<string>();

        for (int i = 0; i < folder.Length; i++)
        {
            folderPaths.Add(replace(folder[i], '/', '\0'));
        }

        return output;
    }

    public int solution_1399_(int n)
    {
        // return n  % 9;
        if (n == 0 || n == 1)
            return n;
        
        int output = 1;
        
        List<List<int>> upperList = new List<List<int>>();
        int indexToAdd;
        
        for (int i = 0; i < n; i++)
        {
            if(upperList.Count < 9)
                upperList.Add(new List<int>());
            
            indexToAdd = i % 9;
            
            upperList[indexToAdd].Add(i);
        }

        int maxLen = upperList[0].Count;

        for (int i = 1; i < (n < 9 ? n : upperList.Count); i++)
        {
            if (upperList[i].Count != maxLen)
                break;

            output++;
        }

        return output;
    }
}