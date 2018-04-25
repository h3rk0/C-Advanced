using System;
using System.Linq;

namespace Maximal_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] rowsAndCols = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int rows = rowsAndCols[0];

			int cols = rowsAndCols[1];

			int[][] matrix = new int[rows][];

			int maxSum = int.MinValue;

			int startRow = 0;

			int startCol = 0;

			for (int row = 0; row < matrix.GetLength(0); row++)
			{

				matrix[row] = Console.ReadLine()
					.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

			}

			for (int row = 0; row < matrix.GetLength(0) - 2; row++)
			{
				for (int col = 0; col < matrix[row].Length - 2; col++)
				{
					int sum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2]
							+ matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2]
							+ matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

					if (sum > maxSum)
					{
						maxSum = sum;
						startRow = row;
						startCol = col;
					}
				}

			}

			Console.WriteLine($"Sum = {maxSum}");

			Console.WriteLine($"{matrix[startRow][startCol]} {matrix[startRow][startCol + 1]} {matrix[startRow][startCol + 2]}");

			Console.WriteLine($"{matrix[startRow + 1][startCol]} {matrix[startRow + 1][startCol + 1]} {matrix[startRow + 1][startCol + 2]}");

			Console.WriteLine($"{matrix[startRow + 2][startCol]} {matrix[startRow + 2][startCol + 1]} {matrix[startRow + 2][startCol + 2]}");


		}
	}
}
