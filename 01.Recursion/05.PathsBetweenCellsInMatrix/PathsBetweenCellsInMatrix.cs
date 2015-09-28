using System;

namespace _05.PathsBetweenCellsInMatrix
{
    class PathsBetweenCellsInMatrix
    {
        private static int exitsFound = 0;

        //private static string[,] matrix = 
        //{
        //    {"s", " ", " ", " "},
        //    {" ", "*", "*", " "},
        //    {" ", "*", "*", " "},
        //    {" ", "*", "e", " "},
        //    {" ", " ", " ", " "}
        //};

        private static string[,] matrix = 
        {
            {"s", " ", " ", " ", " ", " "},
            {" ", "*", "*", " ", "*", " "},
            {" ", "*", "*", " ", "*", " "},
            {" ", "*", "e", " ", " ", " "},
            {" ", " ", " ", "*", " ", " "}
        };

        static void Main()
        {
            TraverseMatrix(0, 0);
            Console.WriteLine("Total paths found: " + exitsFound);
        }

        public static void TraverseMatrix(int row, int col, string path = "")
        {
            bool legitMovement = row < matrix.GetLength(0) &&
                                    row >= 0 &&
                                    col < matrix.GetLength(1) &&
                                    col >= 0;

            if (!legitMovement)
            {
                return;
            }

            if (matrix[row, col] == "e")
            {
                Console.WriteLine(path);
                exitsFound++;
                return;
            }

            if (matrix[row, col] == "*" || matrix[row, col] == "V")
            {
                return;
            }

            matrix[row, col] = "V";

            TraverseMatrix(row + 1, col, path + "D");
            TraverseMatrix(row, col + 1, path + "R");
            TraverseMatrix(row - 1, col, path + "U");
            TraverseMatrix(row, col - 1, path + "L");

            matrix[row, col] = " ";
        }
    }
}