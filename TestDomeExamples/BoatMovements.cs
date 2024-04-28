using System;

public class BoatMovements
{
    public static bool CanTravelTo(bool[,] gameMatrix, int fromRow, int fromColumn, int toRow, int toColumn)
    {
        int gridRowsBound = gameMatrix.GetLength(0) - 1;
        int gridColumnsBound = gameMatrix.GetLength(1) - 1;

        //Check if coordinates are inside the grid
        if (fromRow < 0 || fromRow > gridRowsBound || fromColumn < 0 || fromColumn > gridColumnsBound
            || toRow < 0 || toRow > gridRowsBound || toColumn < 0 || toColumn > gridColumnsBound)
        {
            Console.WriteLine("Coordinates out of grid");
            return false;
        }

        //Check if the destination coordinates are land
        if (!gameMatrix[toRow, toColumn])
        {
            Console.WriteLine("Destination coordinates are land");
            return false;
        }

        //Check if the destination coordinates are the same as the starting coordinates
        if (toRow == fromRow && toColumn == fromColumn)
            return true;


        if (toColumn == fromColumn)
        {
            if (toRow == fromRow - 1 || toRow == fromRow + 1)
                return true;
        }
        else if (toRow == fromRow)
        {
            if (toColumn == fromColumn - 1 || toColumn == fromColumn + 1)
                return true;

            if (toColumn == fromColumn + 2)
                return gameMatrix[toRow, fromColumn + 1];
        }

        return false;
    }

    //public static void Main()
    //{
    //    bool[,] gameMatrix =
    //    {
    //        {false, true,  true,  false, false, false},
    //        {true,  true,  true,  false, false, false},
    //        {true,  true,  true,  true,  true,  true},
    //        {false, true,  true,  false, true,  true},
    //        {false, true,  true,  true,  false, true},
    //        {false, false, false, false, false, false},
    //    };

    //    Console.WriteLine(CanTravelTo(gameMatrix, 3, 2, 2, 2)); // true, Valid move
    //    Console.WriteLine(CanTravelTo(gameMatrix, 3, 2, 3, 4)); // false, Can't travel through land
    //    Console.WriteLine(CanTravelTo(gameMatrix, 3, 2, 6, 2)); // false, Out of bounds
    //}
}

#region GRAPH alternative (Incomplete)
//using System;
//using System.Collections.Generic;

//public class Cell
//{
//    public int Row { get; }
//    public int Column { get; }

//    public Cell(int row, int column)
//    {
//        Row = row;
//        Column = column;
//    }
//}

//public class Graph
//{
//    private Dictionary<Cell, List<Cell>> adjacencyList;

//    public Graph(bool[,] gameMatrix)
//    {
//        adjacencyList = new Dictionary<Cell, List<Cell>>();

//        // Create nodes and edges based on the game matrix
//        for (int i = 0; i < gameMatrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < gameMatrix.GetLength(1); j++)
//            {
//                if (gameMatrix[i, j])
//                {
//                    var currentCell = new Cell(i, j);
//                    var neighbors = new List<Cell>();

//                    if (i > 0 && gameMatrix[i - 1, j]) // Check up
//                        neighbors.Add(new Cell(i - 1, j));
//                    if (i < gameMatrix.GetLength(0) - 1 && gameMatrix[i + 1, j]) // Check down
//                        neighbors.Add(new Cell(i + 1, j));
//                    if (j > 0 && gameMatrix[i, j - 1]) // Check left
//                        neighbors.Add(new Cell(i, j - 1));
//                    if (j < gameMatrix.GetLength(1) - 1 && gameMatrix[i, j + 1]) // Check right
//                        neighbors.Add(new Cell(i, j + 1));

//                    adjacencyList.Add(currentCell, neighbors);
//                }
//            }
//        }
//    }

//    private bool ContainsKey(Cell cell)
//    {
//        return !adjacencyList.First(x => x.Key.Row == cell.Row && x.Key.Column == cell.Column).Equals(null);
//    }

//    public bool CanTravel(Cell from, Cell to)
//    {
//        if (!ContainsKey(from) || !ContainsKey(to))
//            return false;

//        var visited = new HashSet<Cell>();
//        var stack = new Stack<Cell>();
//        stack.Push(from);

//        while (stack.Count > 0)
//        {
//            var current = stack.Pop();

//            if (current.Equals(to))
//                return true;

//            if (!visited.Contains(current))
//            {
//                visited.Add(current);
//                foreach (var neighbor in adjacencyList[current])
//                {
//                    stack.Push(neighbor);
//                }
//            }
//        }

//        return false;
//    }
//}

//public class BoatMovements
//{
//    public static bool CanTravelTo(bool[,] gameMatrix, int fromRow, int fromColumn, int toRow, int toColumn)
//    {
//        var graph = new Graph(gameMatrix);
//        var fromCell = new Cell(fromRow, fromColumn);
//        var toCell = new Cell(toRow, toColumn);        
//        return graph.CanTravel(fromCell, toCell);
//    }

//    public static void Main()
//    {
//        bool[,] gameMatrix =
//        {
//            {false, true,  true,  false, false, false},
//            {true,  true,  true,  false, false, false},
//            {true,  true,  true,  true,  true,  true},
//            {false, true,  true,  false, true,  true},
//            {false, true,  true,  true,  false, true},
//            {false, false, false, false, false, false},
//        };

//        Console.WriteLine(CanTravelTo(gameMatrix, 3, 2, 2, 2)); // true, Valid move
//        Console.WriteLine(CanTravelTo(gameMatrix, 3, 2, 3, 4)); // false, Can't travel through land
//        Console.WriteLine(CanTravelTo(gameMatrix, 3, 2, 6, 2)); // false, Out of bounds
//    }
//}
#endregion