using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_sum_of_2x2_submatrix
{
	class Program
	{
		static void Main(string[] args)
		{
			var matrixSizes = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			var matrixRows = matrixSizes[0];

			var matrixCols = matrixSizes[1];

			var matrix = new int[matrixRows][];

			for (int row = 0; row < matrixRows; row++)
			{
				matrix[row] = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			}

			var maxSubmatrixSum = int.MinValue;

			var maxSubmatrixRow = 0;

			var maxSubmatrixCol = 0;

			for (int row = 0; row < matrix.Length - 1; row++)
			{
				for (int col = 0; col < matrix[row].Length - 1; col++)
				{
					var currentSubmatrixSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] + matrix[row + 1][col + 1];

					if (currentSubmatrixSum > maxSubmatrixSum)
					{
						maxSubmatrixSum = currentSubmatrixSum;

						maxSubmatrixRow = row;

						maxSubmatrixCol = col;

					}

				}
			}

			Console.WriteLine($"{matrix[maxSubmatrixRow][maxSubmatrixCol]} {matrix[maxSubmatrixRow][maxSubmatrixCol + 1]}\n{matrix[maxSubmatrixRow + 1][maxSubmatrixCol]} {matrix[maxSubmatrixRow + 1][maxSubmatrixCol + 1]}");

			Console.WriteLine(maxSubmatrixSum);

			//Console.WriteLine("\\\\\\\\\\\\\\\\");

			//for (int row = 0; row < matrix.Length; row++)
			//{
			//	for (int col = 0; col < matrix[row].Length; col++)
			//	{
			//		Console.Write($"{matrix[row][col]} ");
			//	}

			//	Console.WriteLine();

			//}
		}
	}
}
