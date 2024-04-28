using System;
using System.Collections.Generic;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(List<int> list, int sum)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        for (int i = 0; i < list.Count; i++)
        {
            if (!keyValuePairs.ContainsKey(list[i]))
                keyValuePairs.Add(list[i], i);
            else keyValuePairs[list[i]] = i;
        }

        foreach (int item in keyValuePairs.Keys)
        {
            int delta = sum - item;

            if (keyValuePairs.ContainsKey(delta))
            {
                if (delta == item)
                {
                    int index = list.FindIndex(0, x => x == delta);
                    if (index == keyValuePairs[item])
                        continue;
                    else return Tuple.Create(keyValuePairs[item], index);
                }
                return Tuple.Create(keyValuePairs[item], keyValuePairs[delta]);
            }
        }


        //For loop method - less performant
        //for (int i = 0; i < list.Count; i++)
        //{
        //    int delta = sum - list[i];
        //    for (int j = 0; j < list.Count; j++)
        //    {
        //        if (j == i)
        //            continue;

        //        if (delta == list[j])
        //        {
        //            return Tuple.Create(i, j);
        //        }
        //    }
        //}

        return null;
    }

    //public static void Main(string[] args)
    //{
    //    Tuple<int, int> indices = FindTwoSum(new List<int>() { /*3, 1,*/ 5, 7, 5, 9 }, 10);
    //    if (indices != null)
    //    {
    //        Console.WriteLine(indices.Item1 + " " + indices.Item2);
    //    }
    //}
}