namespace leetcode;

public partial class Leetcode
{
    private int findPair(int[] nums, int num, int startIndex, List<int> pairedIndexes)
    {
        for (int i = startIndex; i < nums.Length; i++)
        {
            if (nums[i] == num && listContains(pairedIndexes, i) && !pairedIndexes.Contains(i))
                return i;
        }

        return -1;
    }    
    
    private int listMaxValue(List<int> list)
    {
        int maxValue = list[0];

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] > maxValue)
            {
                maxValue = list[i];
            }
        }

        return maxValue;
    }
    
    private int listMinValue(List<int> list)
    {
        int minValue = list[0];

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] < minValue)
            {
                minValue = list[i];
            }
        }

        return minValue;
    }

    private char[] toCharArray(string str)
    {
        char[] charArray = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            charArray[i] = str[i];
        }

        return charArray;
    }

    private string replace(string str, char oldVal, char newVal)
    {
        List<char> charArr = new List<char>();
        for (int i = 0; i < charArr.Count; i++)
        {
            if (str[i] != oldVal)
            {
                charArr.Add(str[i]);
            }
            else if (newVal != '\0')
            {
                charArr.Add(newVal);
            }
        }
        
        return new string(charArr.ToArray());
    }

    private List<string> split(string str, char divider)
    {
        List<string> list = new List<string>();
        
        string temp = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (divider == str[i])
            {
                list.Add(temp);
                temp = "";
                continue;
            }

            temp += str[i];
        }

        return list;
    }

    private int abs(int num)
    {
        return num < 0 ? -num : num;
    }
    
    private List<int> listMinKValue(List<int> list, int k)
    {
        List<int> lowestValues = new List<int>();

        for (int i = 0; i < k; i++)
        {
            lowestValues.Add(list[i]);
        }

        int highestInList2 = listMaxValue(lowestValues);

        for (int i = k; i < list.Count; i++)
        {
            if (list[i] < highestInList2)
            {
                lowestValues = listReplaceHighest(lowestValues, highestInList2, list[i]);
                highestInList2 = listMaxValue(lowestValues);
            }
        }

        return lowestValues;
    }
    
    private List<int> listReplaceHighest(List<int> list, int highest, int newVal)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (highest == list[i])
            {
                list[i] = newVal;
                return list;
            }
        }

        return list;
    }

    private bool listContains<T>(List<T> list, T value)
    {
        if (value == null)
            return false;
        
        for (int i = 0; i < list.Count; i++)
        {
            if (value.Equals(list[i]))
                return true;
        }

        return false;
    }
}