using System;

public class Account2
{
    //Explanation: https://www.youtube.com/watch?v=Pp7T-O3dIrs
    [Flags]
    public enum Access
    {
        Delete = 1,//0b_0000_0001
        Publish = 2,//0b_0000_0010
        Submit = 4,//0b_0000_0100
        Comment = 8,//0b_0000_1000
        Modify = 16,//0b_0001_0000
        Writer = Submit | Modify,//0b_0001_0100 - 20
        Editor = Delete | Publish | Comment,//0b_0000_1011 - 11
        Owner = Writer | Editor//0b_0001_1111 - 31
    }

    //public static void Main(string[] args)
    //{
    //    Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
    //    Console.WriteLine(((byte)Access.Writer));                                                                 
    //    Console.WriteLine(((byte)Access.Editor));                                                                 
    //    Console.WriteLine(((byte)Access.Owner));                                                                 
    //}
}