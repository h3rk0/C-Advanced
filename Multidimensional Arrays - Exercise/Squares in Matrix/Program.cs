using System;
using System.Linq;

namespace _2x2_Squares_in_Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] rowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int rows = rowsAndCols[0];

			int cols = rowsAndCols[1];

			char[][] matrix = new char[rows][];

			for (int row = 0; row < matrix.Length; row++)
			{
				matrix[row] = Console.ReadLine()
					.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(char.Parse)
					.ToArray();
			}

			var count = 0;

			for (int row = 0; row < matrix.GetLength(0) - 1; row++)
			{
				for (int col = 0; col < matrix[row].Length - 1; col++)
				{
					if (matrix[row][col] == matrix[row][col + 1] &&
						matrix[row][col] == matrix[row + 1][col] &&
						matrix[row][col] == matrix[row + 1][col + 1])
					{
						count++;
					}
				}

			}

			Console.WriteLine(count);

			//for (int row = 0; row < matrix.GetLength(0); row++)
			//{
			//	for (int col = 0; col < matrix[row].Length; col++)
			//	{
			//		Console.Write(matrix[row][col]+ " ");
			//	}
			//	Console.WriteLine();
			//}
		}
	}
}
