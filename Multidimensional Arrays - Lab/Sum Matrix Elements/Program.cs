using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices___Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			var matrixSizes = Console.ReadLine()
				.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse).ToArray();

			var rowsCount = matrixSizes[0];

			var columnsCount = matrixSizes[1];

			int[][] matrix = new int[rowsCount][];

			for (int row = 0; row < matrix.Length; row++)
			{
				matrix[row] = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			}

			var sum = 0;

			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[i].Length; j++)
				{
					sum += matrix[i][j];
				}
			}

			Console.WriteLine(rowsCount);
			Console.WriteLine(columnsCount);
			Console.WriteLine(sum);


		}
	}
}
