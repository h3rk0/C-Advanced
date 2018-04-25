using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	class Program
	{

		static void Main()
		{
			int[] rowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int rows = rowsAndCols[0];

			int cols = rowsAndCols[1];

			string snake = Console.ReadLine();

			char[][] matrix = new char[rows][];

			//initializing
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				char[] array = new char[cols];
				matrix[row] = array;
			}

			//filling matrix
			FillingMatrix(matrix, snake);

			int[] shot = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			//PrintMatrix(matrix);

			//blasting
			BlastMatrix(matrix, shot, rows);


			//PrintMatrix(matrix);

			//falling down leftovers
			GravityMatrix(matrix);

			//print matrix
			PrintMatrix(matrix);
		}

		private static void GravityMatrix(char[][] matrix)
		{
			for (int col = 0; col < matrix[0].Length; col++)
			{
				char[] array = new char[matrix.GetLength(0)];

				Stack<char> chars = new Stack<char>();

				for (int row = 0; row < matrix.GetLength(0); row++)
				{
					if (matrix[row][col] != ' ')
					{
						chars.Push(matrix[row][col]);
					}

				}

				for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
				{
					if (chars.Count > 0)
					{
						array[i] = chars.Pop();
					}
					else
					{
						array[i] = ' ';
					}
				}

				for (int row = 0; row < matrix.GetLength(0); row++)
				{
					matrix[row][col] = array[row];
				}

			}

		}

		private static void FillingMatrix(char[][] matrix, string snake)
		{
			//setting matrix
			bool switchWay = true;

			Queue<char> queue = new Queue<char>(snake);

			for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
			{
				if (switchWay)
				{
					for (int col = matrix[row].Length - 1; col >= 0; col--)
					{
						matrix[row][col] = queue.Dequeue();

						queue.Enqueue(matrix[row][col]);

					}
					switchWay = false;
				}
				else
				{
					for (int col = 0; col < matrix[row].Length; col++)
					{
						matrix[row][col] = queue.Dequeue();

						queue.Enqueue(matrix[row][col]);
					}
					switchWay = true;
				}


			}
		}

		private static void BlastMatrix(char[][] matrix, int[] shot, int rows)
		{
			int impactRow = shot[0];
			int impactCol = shot[1];
			int radius = shot[2];

			if (radius == 0)
			{
				matrix[impactRow][impactCol] = ' ';
			}
			else if (radius == 1)
			{
				MatrixBlastRadiusOne(matrix, impactRow, impactCol);

			}
			else if (radius == 2)
			{
				MatrixBlastRadiusOne(matrix, impactRow, impactCol);

				MatrixBlastRadiusTwo(matrix, impactRow, impactCol);
				//

			}
			else if (radius == 3)
			{
				MatrixBlastRadiusOne(matrix, impactRow, impactCol);

				MatrixBlastRadiusTwo(matrix, impactRow, impactCol);

				MatrixBlastRadiusThree(matrix, impactRow, impactCol);

			}
			else if (radius == 4)
			{
				MatrixBlastRadiusOne(matrix, impactRow, impactCol);

				MatrixBlastRadiusTwo(matrix, impactRow, impactCol);

				MatrixBlastRadiusThree(matrix, impactRow, impactCol);

				MatrixBlastRadiusFour(matrix, impactRow, impactCol);
			}
		}

		private static void MatrixBlastRadiusFour(char[][] matrix, int impactRow, int impactCol)
		{
			//vertical and horizontal
			if (impactRow - 4 >= 0)
			{
				matrix[impactRow - 4][impactCol] = ' ';
			}
			if (impactRow + 4 <= matrix.GetLength(0) - 1)
			{
				matrix[impactRow + 4][impactCol] = ' ';
			}
			if (impactCol - 4 >= 0)
			{
				matrix[impactRow][impactCol - 4] = ' ';
			}
			if (impactCol + 4 <= matrix[0].Length)
			{
				matrix[impactRow][impactCol + 4] = ' ';
			}

			//upper left diagonals
			if (impactRow - 3 >= 0 && impactCol - 1 >= 0)
			{
				matrix[impactRow - 3][impactCol - 1] = ' ';
			}
			if (impactRow - 2 >= 0 && impactCol - 2 >= 0)
			{
				matrix[impactRow - 2][impactCol - 2] = ' ';
			}
			if (impactRow - 1 >= 0 && impactCol - 3 >= 0)
			{
				matrix[impactRow - 1][impactCol - 3] = ' ';
			}

			//upper right diagonals
			if (impactRow - 1 >= 0 && impactCol + 3 <= matrix[0].Length - 1)
			{
				matrix[impactRow - 1][impactCol + 3] = ' ';
			}
			if (impactRow - 2 >= 0 && impactCol + 2 <= matrix[0].Length - 1)
			{
				matrix[impactRow - 2][impactCol + 2] = ' ';
			}
			if (impactRow - 3 >= 0 && impactCol + 1 <= matrix[0].Length - 1)
			{
				matrix[impactRow - 3][impactCol + 1] = ' ';
			}

			//lower right diagonals
			if (impactRow + 3 <= matrix.GetLength(0) - 1 && impactCol + 1 <= matrix[0].Length - 1)
			{
				matrix[impactRow + 3][impactCol + 1] = ' ';
			}
			if (impactRow + 2 <= matrix.GetLength(0) - 1 && impactCol + 2 <= matrix[0].Length - 1)
			{
				matrix[impactRow + 2][impactCol + 2] = ' ';
			}
			if (impactRow + 1 <= matrix.GetLength(0) - 1 && impactCol + 3 <= matrix[0].Length - 1)
			{
				matrix[impactRow + 1][impactCol + 3] = ' ';
			}

			//lower left diagonals
			if (impactRow + 3 <= matrix.GetLength(0) - 1 && impactCol - 1 >= 0)
			{
				matrix[impactRow + 3][impactCol - 1] = ' ';
			}
			if (impactRow + 2 <= matrix.GetLength(0) - 1 && impactCol - 2 >= 0)
			{
				matrix[impactRow + 2][impactCol - 2] = ' ';
			}
			if (impactRow + 1 <= matrix.GetLength(0) - 1 && impactCol - 3 >= 0)
			{
				matrix[impactRow + 1][impactCol - 3] = ' ';
			}
		}

		private static void MatrixBlastRadiusThree(char[][] matrix, int impactRow, int impactCol)
		{
			//horizontal and vertical 
			if (impactRow - 3 >= 0)
			{
				matrix[impactRow - 3][impactCol] = ' ';
			}
			if (impactRow + 3 <= matrix.GetLength(0) - 1)
			{
				matrix[impactRow + 3][impactCol] = ' ';
			}
			if (impactCol - 3 >= 0)
			{
				matrix[impactRow][impactCol - 3] = ' ';
			}
			if (impactCol + 3 <= matrix[0].Length - 1)
			{
				matrix[impactRow][impactCol + 3] = ' ';
			}

			//upper diagonal shots
			if (impactRow - 2 > 0 && impactCol - 1 > 0)
			{
				//Console.WriteLine(matrix[impactRow - 2][impactCol - 1]);
				matrix[impactRow - 2][impactCol - 1] = ' ';
			}
			if (impactRow - 2 > 0 && impactCol + 1 < matrix[0].Length - 1)
			{
				matrix[impactRow - 2][impactCol + 1] = ' ';
			}
			if (impactRow - 1 > 0 && impactCol + 2 < matrix[0].Length - 1)
			{
				matrix[impactRow - 1][impactCol + 2] = ' ';
			}
			if (impactRow - 1 > 0 && impactCol - 2 > 0)
			{
				matrix[impactRow - 1][impactCol - 2] = ' ';
			}
			//lower diagonal shots
			if (impactRow + 1 < matrix.GetLength(0) - 1 && impactCol - 2 > 0)
			{
				matrix[impactRow + 1][impactCol - 2] = ' ';
			}
			if (impactRow + 2 < matrix.GetLength(0) - 1 && impactCol - 1 > 0)
			{
				matrix[impactRow + 2][impactCol - 1] = ' ';
			}
			if (impactRow + 2 < matrix.GetLength(0) - 1 && impactCol + 1 < matrix[0].Length - 1)
			{
				matrix[impactRow + 2][impactCol + 1] = ' ';
			}
			if (impactRow + 1 < matrix.GetLength(0) - 1 && impactCol + 2 > 0)
			{
				matrix[impactRow + 1][impactCol + 2] = ' ';
			}
		}

		private static void MatrixBlastRadiusTwo(char[][] matrix, int impactRow, int impactCol)
		{
			if (impactRow - 2 >= 0)
			{
				matrix[impactRow - 2][impactCol] = ' ';
			}
			if (impactRow + 2 <= matrix.GetLength(0) - 1)
			{
				matrix[impactRow + 2][impactCol] = ' ';
			}
			if (impactCol - 2 >= 0)
			{
				matrix[impactRow][impactCol - 2] = ' ';
			}
			if (impactCol + 2 <= matrix[0].Length - 1)
			{
				matrix[impactRow][impactCol + 2] = ' ';
			}
			//
			if (impactRow + 1 <= matrix.GetLength(0) - 1
				&& impactCol - 1 >= 0)
			{
				matrix[impactRow + 1][impactCol - 1] = ' ';
			}
			if (impactRow + 1 <= matrix.GetLength(0) - 1
				&& impactCol + 1 <= matrix[0].Length - 1)
			{
				matrix[impactRow + 1][impactCol + 1] = ' ';
			}
			if (impactRow - 1 >= 0
				&& impactCol + 1 <= matrix[0].Length - 1)
			{
				matrix[impactRow - 1][impactCol + 1] = ' ';
			}
			if (impactRow - 1 >= 0
				&& impactCol - 1 >= 0)
			{
				matrix[impactRow - 1][impactCol - 1] = ' ';
			}
		}

		private static void MatrixBlastRadiusOne(char[][] matrix, int impactRow, int impactCol)
		{
			matrix[impactRow][impactCol] = ' ';

			if (impactRow - 1 >= 0)
			{
				matrix[impactRow - 1][impactCol] = ' ';
			}
			if (impactRow + 1 <= matrix.GetLength(0) - 1)
			{
				matrix[impactRow + 1][impactCol] = ' ';
			}
			if (impactCol - 1 >= 0)
			{
				matrix[impactRow][impactCol - 1] = ' ';
			}
			if (impactCol + 1 <= matrix[0].Length - 1)
			{
				matrix[impactRow][impactCol + 1] = ' ';
			}
		}

		private static void PrintMatrix(char[][] matrix)
		{
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix[row].Length; col++)
				{
					Console.Write(matrix[row][col] + "");
				}
				Console.WriteLine();
			}
		}
	}
}
