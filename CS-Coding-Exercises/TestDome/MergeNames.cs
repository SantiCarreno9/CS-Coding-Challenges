namespace TestDome;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        //HashSet method
        HashSet<string> result = new HashSet<string>();

        int i = 0;
        while (true)
        {
            if (i < names1.Length)
                result.Add(names1[i]);

            if (i < names2.Length)
                result.Add(names2[i]);

            i++;
            if (i >= names1.Length && i >= names2.Length)
                break;
        }

        //List method
        //List<string> result = new List<string>();
        //for (int i = 0; i < names1.Length; i++)
        //{
        //    if (!result.Contains(names1[i]))
        //        result.Add(names1[i]);
        //}

        //for (int i = 0; i < names2.Length; i++)
        //{
        //    if (!result.Contains(names2[i]))
        //        result.Add(names2[i]);
        //}

        return result.ToArray();
    }

    //public static void Main(string[] args)
    //{
    //    string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
    //    string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
    //    Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    //}
}