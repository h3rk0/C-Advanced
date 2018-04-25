using System;
using System.Linq;

namespace Diagonal_Difference
{
	class Program
	{
		static void Main(string[] args)
		{
			//diagonals 

			double firstDiagonal = 0;

			double secondDiagonal = 0;


			long n = long.Parse(Console.ReadLine());

			double[][] matrix = new double[n][];

			for (long row = 0; row < matrix.GetLength(0); row++)
			{
				matrix[row] = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
			}

			for (long row = 0; row < matrix.GetLength(0); row++)
			{
				for (long col = 0; col < matrix[row].Length; col++)
				{
					if (row == col)
					{
						firstDiagonal += matrix[row][col];
					}
					if (col == n - (row + 1))
					{
						secondDiagonal += matrix[row][col];
					}
					//Console.Write(matrix[row][col] + " ");
				}
				//Console.WriteLine();
			}

			//Console.WriteLine("first "+firstDiagonal);
			//Console.WriteLine("second "+secondDiagonal);

			Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));

			//for (int row = 0; row < matrix.GetLength(0); row++)
			//{
			//	for (int col = 0; col < matrix[row].Length; col++)
			//	{
			//		Console.Write(matrix[row][col]+" ");
			//	}
			//	Console.WriteLine();
			//}

		}
	}
}
