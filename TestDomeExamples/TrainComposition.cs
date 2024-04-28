using System;
using System.Collections.Generic;

public class TrainComposition
{    
    LinkedList<int> wagons = new LinkedList<int>();
    int Count => wagons.Count;

    public void AttachWagonFromLeft(int wagonId)
    {
        wagons.AddFirst(wagonId);
    }

    public void AttachWagonFromRight(int wagonId)
    {
        wagons.AddLast(wagonId);
    }

    public int DetachWagonFromLeft()
    {
        if (wagons.Count == 0)
            return 0;

        int result = wagons.First.Value;
        wagons.RemoveFirst();
        return result;
    }

    public int DetachWagonFromRight()
    {
        if (wagons.Count == 0)
            return 0;

        int result = wagons.Last.Value;
        wagons.RemoveLast();
        return result;
    }

    //public static void Main(string[] args)
    //{
    //    //Example
    //    TrainComposition train = new TrainComposition();
    //    train.AttachWagonFromLeft(7);
    //    train.AttachWagonFromLeft(13);
    //    Console.WriteLine(train.DetachWagonFromRight()); // 7 
    //    Console.WriteLine(train.DetachWagonFromLeft()); // 13

    //    //Zigzag
    //    //TrainComposition train = new TrainComposition();
    //    //train.AttachWagonFromRight(7);
    //    //train.AttachWagonFromLeft(13);
    //    //train.AttachWagonFromRight(8);
    //    //train.AttachWagonFromLeft(12);
    //    //while (train.Count > 0)
    //    //{
    //    //    Console.WriteLine(train.DetachWagonFromLeft()); // 12 - 13 
    //    //    Console.WriteLine(train.DetachWagonFromRight()); // 8 - 7 
    //    //}

    //    //Insert from left, remove from left
    //    //TrainComposition train = new TrainComposition();
    //    //train.AttachWagonFromLeft(7);
    //    //train.AttachWagonFromLeft(13);
    //    //train.AttachWagonFromLeft(8);
    //    //train.AttachWagonFromLeft(12);
    //    //while (train.Count > 0)
    //    //{
    //    //    Console.WriteLine(train.DetachWagonFromLeft()); // 12 - 8 - 13 - 7             
    //    //}

    //    //Insert from left, remove from right
    //    //TrainComposition train = new TrainComposition();
    //    //train.AttachWagonFromLeft(7);
    //    //train.AttachWagonFromLeft(13);
    //    //train.AttachWagonFromLeft(8);
    //    //train.AttachWagonFromLeft(12);
    //    //while (train.Count > 0)
    //    //{
    //    //    Console.WriteLine(train.DetachWagonFromRight()); // 7 - 13 - 8 - 12             
    //    //}

    //    //Insert from right, remove from left
    //    //TrainComposition train = new TrainComposition();
    //    //train.AttachWagonFromRight(7);
    //    //train.AttachWagonFromRight(13);
    //    //train.AttachWagonFromRight(8);
    //    //train.AttachWagonFromRight(12);
    //    //while (train.Count > 0)
    //    //{
    //    //    Console.WriteLine(train.DetachWagonFromLeft()); // 7 - 13 - 8 - 12             
    //    //}

    //    //Insert from right, remove from right
    //    //TrainComposition train = new TrainComposition();
    //    //train.AttachWagonFromRight(7);
    //    //train.AttachWagonFromRight(13);
    //    //train.AttachWagonFromRight(8);
    //    //train.AttachWagonFromRight(12);
    //    //while (train.Count > 0)
    //    //{
    //    //    Console.WriteLine(train.DetachWagonFromRight()); // 12 - 8 - 13 - 7
    //    //}
    //}
}