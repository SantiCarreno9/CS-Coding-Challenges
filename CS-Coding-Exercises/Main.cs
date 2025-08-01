public class MainProgram
{
    public static void Main(string[] args)
    {
        int[] values = { 1, 2, 2, 3, 4 };
        int[] except = { 3, 4 };
        var filtered = values.Except(except);
        //max = 3;
        filtered.ToList().ForEach(x => Console.WriteLine(x));        
    }
}

