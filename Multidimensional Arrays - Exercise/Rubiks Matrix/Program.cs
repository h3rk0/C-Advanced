using System;
using System.Collections.Generic;
using System.Linq;

namespace Rubiks_Matrix
{
	class Program
	{
		static void Main()
		{
			int[] rowsAndCols = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();


			int rows = rowsAndCols[0];

			int cols = rowsAndCols[1];

			int[][] matrix = new int[rows][];

			var initializer = 1;

			for (int row = 0; row < matrix.GetLength(0); row++)
			{

				int[] array = new int[cols];

				for (int i = 0; i < array.Length; i++)
				{
					array[i] = initializer;
					initializer++;
				}

				matrix[row] = array;
			}

			//commands
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string[] args = Console.ReadLine().Split(' ').ToArray();

				if (args[1] == "up")
				{
					ShiftUp(int.Parse(args[0]), int.Parse(args[2]), matrix);
					//PrintMatrix(matrix);
				}
				else if (args[1] == "down")
				{
					ShiftDown(int.Parse(args[0]), int.Parse(args[2]), matrix);
					//PrintMatrix(matrix);
				}
				else if (args[1] == "right")
				{
					ShiftRight(int.Parse(args[0]), int.Parse(args[2]), matrix);
					//PrintMatrix(matrix);
				}
				else if (args[1] == "left")
				{
					ShiftLeft(int.Parse(args[0]), int.Parse(args[2]), matrix);
					//PrintMatrix(matrix);
				}
			}

			//initialize
			//PrintMatrix(matrix);
			RearrangeMatrix(matrix);



		}

		private static void RearrangeMatrix(int[][] matrix)
		{
			int counter = 1;

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix[row].Length; col++)
				{
					if (counter != matrix[row][col])
					{
						int[] cords = FindNumber(matrix, counter);
						var swapRow = cords[0];
						var swapCol = cords[1];

						Console.WriteLine($"Swap ({row}, {col}) with ({swapRow}, {swapCol})");

						int switcher = matrix[row][col];

						matrix[row][col] = matrix[swapRow][swapCol];

						matrix[swapRow][swapCol] = switcher;
					}
					else
					{
						Console.WriteLine("No swap required");
					}

					counter++;
				}

			}
		}

		private static int[] FindNumber(int[][] matrix, int counter)
		{
			int[] coords = new int[2];


			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix[row].Length; col++)
				{
					if (matrix[row][col] == counter)
					{
						coords[0] = row;

						coords[1] = col;
						break;
					}
				}

			}

			return coords;
		}

		private static void ShiftLeft(int row, int moves, int[][] matrix)
		{
			moves = moves % matrix[row].Length;

			for (int move = 0; move < moves; move++)
			{
				var firstRow = matrix[row][0];

				for (int col = 0; col < matrix[row].Length - 1; col++)
				{
					matrix[row][col] = matrix[row][col + 1];
				}

				matrix[row][matrix[row].Length - 1] = firstRow;
			}
		}

		private static void ShiftRight(int row, int moves, int[][] matrix)
		{
			moves = moves % matrix[row].Length;

			for (int move = 0; move < moves; move++)
			{

				var lastRow = matrix[row][matrix[row].Length - 1];

				for (int col = matrix[row].Length - 1; col >= 1; col--)
				{
					matrix[row][col] = matrix[row][col - 1];
				}

				matrix[row][0] = lastRow;
			}
		}

		private static void ShiftDown(int col, int moves, int[][] matrix)
		{
			moves = moves % matrix.Length;

			for (int move = 0; move < moves; move++)
			{
				var lastRow = matrix[matrix.GetLength(0) - 1][col];

				for (int row = matrix.GetLength(0) - 1; row >= 1; row--)
				{
					matrix[row][col] = matrix[row - 1][col];
				}

				matrix[0][col] = lastRow;
			}

		}

		private static void ShiftUp(int col, int moves, int[][] matrix)
		{
			moves = moves % matrix.Length;

			for (int move = 0; move < moves; move++)
			{
				var firstRow = matrix[0][col];

				for (int row = 0; row < matrix.GetLength(0) - 1; row++)
				{
					matrix[row][col] = matrix[row + 1][col];

				}

				matrix[matrix.GetLength(0) - 1][col] = firstRow;
			}

		}

		private static void PrintMatrix(int[][] matrix)
		{
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix[row].Length; col++)
				{
					Console.Write(matrix[row][col] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
