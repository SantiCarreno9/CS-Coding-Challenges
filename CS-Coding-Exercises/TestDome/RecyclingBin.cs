namespace TestDome;

public class RecyclingBin
{
    protected List<string> recyclables = new List<string>();

    public void Add(string recyclable)
    {
        if (recyclable.Split(' ').Length > 1 &&
            recyclable.Split(' ')[1].Length > 3)
        {
            recyclables.Add(recyclable);
        }
    }

    public List<IGrouping<string, string>> SortRecyclables()
    {
        return recyclables.GroupBy(recyclable => recyclable.Split(' ').First()).ToList();
    }
}

public class RecyclingBinProgram
{
    //public static void Main(string[] args)
    //{
    //    RecyclingBin recyclingBin = new RecyclingBin();
    //    recyclingBin.Add("metal pipe");
    //    recyclingBin.Add("plastic toy");
    //    recyclingBin.Add("metal bar");
    //    recyclingBin.Add("copper wire");
    //    recyclingBin.Add("plastic button");
    //    recyclingBin.Add("wire");
    //    recyclingBin.Add("brass");

    //    var recyclables = recyclingBin.SortRecyclables();

    //    for (int i = 0; i < recyclables.Count; i++)
    //    {
    //        Console.WriteLine("Key: " + recyclables[i].Key);
    //        var array = recyclables[i].ToArray();
    //        for (int j = 0; j < array.Length; j++)
    //        {
    //            Console.WriteLine(array[j]);
    //        }
    //    }
    //}
}
