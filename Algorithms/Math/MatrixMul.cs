namespace Algorithms.Math
{
    public class MatrixMul
    {
        public int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.GetColumnsCount() != matrixB.GetRowsCount())
            {
                throw new Exception("The number of columns of the matrixA doesn't equal to the number of rows of the matrixB");
            }
            var matrixC = new int[matrixA.GetRowsCount(), matrixB.GetColumnsCount()];
            for (int i = 0; i < matrixA.GetRowsCount(); i++)
            {
                for (int j = 0; j < matrixB.GetColumnsCount(); j++)
                {
                    for (int k = 0; k < matrixA.GetColumnsCount(); k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return matrixC;
        }

        public void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetRowsCount(); i++)
            {
                for (int j = 0; j < matrix.GetColumnsCount(); j++)
                {
                    Console.Write($"  {matrix[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
    }

    public static class MatrixExt
    {
        public static int GetRowsCount(this int[,] matrix)
        {
            return matrix.GetLength(0);
        }

        public static int GetColumnsCount(this int[,] matrix)
        {
            return matrix.GetLength(1);
        }
    }
}
