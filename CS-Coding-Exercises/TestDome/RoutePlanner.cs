namespace TestDome;

#region RECURSION Alternative (fastest solution)
public class RoutePlanner
{
    public static bool RouteExists(int fromRow, int fromColumn, int toRow, int toColumn,
                                      bool[,] mapMatrix, int previousRow = -1, int previousColumn = -1)
    {
        int gridRowsBound = mapMatrix.GetLength(0) - 1;
        int gridColumnsBound = mapMatrix.GetLength(1) - 1;

        //Check if coordinates are inside the grid
        if (fromRow < 0 || fromRow > gridRowsBound || fromColumn < 0 || fromColumn > gridColumnsBound
            || toRow < 0 || toRow > gridRowsBound || toColumn < 0 || toColumn > gridColumnsBound)
            return false;

        if (!mapMatrix[fromRow, fromColumn])
            return false;

        if (!mapMatrix[toRow, toColumn])
            return false;

        //Check if the destination coordinates are the same as the starting coordinates
        if (toRow == fromRow && toColumn == fromColumn)
            return true;

        int columnDirection = (fromColumn < toColumn) ? 1 : -1;
        int rowDirection = (fromRow < toRow) ? 1 : -1;

        int direction;
        int nextRow;
        int nextColumn;
        for (int i = 0; i < 2; i++)
        {
            direction = i < 1 ? 1 : -1;
            nextRow = fromRow + rowDirection * direction;
            nextColumn = fromColumn + columnDirection * direction;

            if (nextRow != previousRow && (nextRow >= 0 && nextRow <= gridRowsBound && mapMatrix[nextRow, fromColumn]))
                if (RouteExists(nextRow, fromColumn, toRow, toColumn, mapMatrix, fromRow, fromColumn))
                    return true;

            if (nextColumn != previousColumn && (nextColumn >= 0 && nextColumn <= gridColumnsBound && mapMatrix[fromRow, nextColumn]))
                if (RouteExists(fromRow, nextColumn, toRow, toColumn, mapMatrix, fromRow, fromColumn))
                    return true;
        }
        
        return false;
    }

    //public static void Main(string[] args)
    //{
    //    bool[,] mapMatrix = {
    //        {true, false, false},
    //        {true, true, false},
    //        {false, true, true}
    //    };

    //    Console.WriteLine(RouteExists(0, 0, 2, 2, mapMatrix));
    //}
}
#endregion

#region GRAPH Alternative (Lowest solution)
//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;

//public class RoutePlanner
//{
//    public class Cell
//    {
//        public int Row { get; }
//        public int Column { get; }

//        public Cell(int row, int column)
//        {
//            Row = row;
//            Column = column;
//        }
//    }

//    public class CellEqualityComparer : IEqualityComparer<Cell>
//    {
//        public bool Equals(Cell? c1, Cell? c2)
//        {
//            if (c2 is null || c1 is null)
//                return false;

//            return c1.Row == c2.Row
//                && c1.Column == c2.Column;
//        }

//        public int GetHashCode(Cell obj)
//        {
//            return obj.GetHashCode();
//        }
//    }

//    public class Graph
//    {
//        private bool[,] mapMatrix;

//        public Graph(bool[,] mapMatrix)
//        {
//            this.mapMatrix = mapMatrix;
//        }

//        public bool RouteExists(int fromRow, int fromColumn, int toRow, int toColumn)
//        {
//            int gridRowsBound = mapMatrix.GetLength(0) - 1;
//            int gridColumnsBound = mapMatrix.GetLength(1) - 1;

//            //Check if coordinates are inside the grid
//            if (fromRow < 0 || fromRow > gridRowsBound || fromColumn < 0 || fromColumn > gridColumnsBound
//                || toRow < 0 || toRow > gridRowsBound || toColumn < 0 || toColumn > gridColumnsBound)
//                return false;

//            if (!mapMatrix[fromRow, fromColumn])
//                return false;

//            if (!mapMatrix[toRow, toColumn])
//                return false;

//            Cell from = new Cell(fromRow, fromColumn);
//            Cell to = new Cell(toRow, toColumn);

//            var visited = new HashSet<Cell>();
//            var queue = new Queue<Cell>();
//            queue.Enqueue(from);

//            CellEqualityComparer comparer = new();
//            while (queue.Count > 0)
//            {
//                var current = queue.Dequeue();

//                if (comparer.Equals(current, to))
//                    return true;

//                if (!visited.Contains(current, comparer))
//                {
//                    visited.Add(current);
//                    //var neighbors = GetNeighbors(current);
//                    var neighbors = GetNeighborsTo(current, to);
//                    while (neighbors.Count > 0)
//                        queue.Enqueue(neighbors.Dequeue());
//                }
//            }

//            return false;
//        }

//        private Queue<Cell> GetNeighbors(Cell cell)
//        {
//            Queue<Cell> neighbors = new Queue<Cell>();
//            if (cell.Row > 0 && mapMatrix[cell.Row - 1, cell.Column]) // Check up
//                neighbors.Enqueue(new Cell(cell.Row - 1, cell.Column));
//            if (cell.Row < mapMatrix.GetLength(0) - 1 && mapMatrix[cell.Row + 1, cell.Column]) // Check down
//                neighbors.Enqueue(new Cell(cell.Row + 1, cell.Column));
//            if (cell.Column > 0 && mapMatrix[cell.Row, cell.Column - 1]) // Check left
//                neighbors.Enqueue(new Cell(cell.Row, cell.Column - 1));
//            if (cell.Column < mapMatrix.GetLength(1) - 1 && mapMatrix[cell.Row, cell.Column + 1]) // Check right
//                neighbors.Enqueue(new Cell(cell.Row, cell.Column + 1));

//            return neighbors;
//        }

//        private Queue<Cell> GetNeighborsTo(Cell from, Cell to)
//        {
//            int columnDirection = (from.Column < to.Column) ? 1 : -1;
//            int rowDirection = (from.Row < to.Row) ? 1 : -1;

//            int direction;
//            int nextRow;
//            int nextColumn;

//            Queue<Cell> neighbors = new Queue<Cell>();
//            for (int i = 0; i < 2; i++)
//            {
//                direction = i < 1 ? 1 : -1;
//                nextRow = from.Row + rowDirection * direction;
//                nextColumn = from.Column + columnDirection * direction;

//                if ((nextRow >= 0 && nextRow <= mapMatrix.GetLength(0) - 1 && mapMatrix[nextRow, from.Column]))
//                    neighbors.Enqueue(new Cell(nextRow, from.Column));

//                if ((nextColumn >= 0 && nextColumn <= mapMatrix.GetLength(1) - 1 && mapMatrix[from.Row, nextColumn]))
//                    neighbors.Enqueue(new Cell(from.Row, nextColumn));
//            }

//            return neighbors;
//        }
//    }

//    public static bool RouteExists(int fromRow, int fromColumn, int toRow, int toColumn,
//                                      bool[,] mapMatrix)
//    {
//        Graph graph = new Graph(mapMatrix);
//        return graph.RouteExists(fromRow, fromColumn, toRow, toColumn);
//    }

//    public static void Main(string[] args)
//    {
//        bool[,] mapMatrix = {
//            {true, false, false},
//            {true, true, false},
//            {false, true, true}
//        };

//        Console.WriteLine(RouteExists(0, 0, 2, 2, mapMatrix));
//    }
//}
#endregion