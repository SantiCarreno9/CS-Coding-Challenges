using System;
using System.Collections.Generic;

public class Folders
{
    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
    {
        string[] lines = xml.Split('>');
        List<string> folders = new List<string>();
        for (int i = 1; i < lines.Length - 1; i++)
        {
            string[] parts = lines[i].Split('\"');
            if (parts.Length > 1 && parts[1][0] == startingLetter)
                folders.Add(parts[1]);
        }
        return folders;
    }

    //public static void Main(string[] args)
    //{
    //    string xml =
    //        "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
    //        "<folder name=\"c\">" +
    //            "<folder name=\"program files\">" +
    //                "<folder name=\"uninstall information\" />" +
    //            "</folder>" +
    //            "<folder name=\"users\" />" +
    //        "</folder>";

    //    foreach (string name in Folders.FolderNames(xml, 'u'))
    //        Console.WriteLine(name);
    //}
}