using System;
using System.Linq;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			var rows = input[0];

			var cols = input[1];

			char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

			string[][] matrix = new string[rows][];

			string[,] matrix2 = new string[rows, cols];

			for (int row = 0; row < matrix2.GetLength(0); row++)
			{
				for (int col = 0; col < matrix2.GetLength(1); col++)
				{
					char startEnd;
					char middle;
					startEnd = alphabet[row];
					middle = alphabet[row + col];
					char[] result = new char[3];
					result[0] = startEnd;
					result[1] = middle;
					result[2] = startEnd;
					var str = new string(result);
					matrix2[row, col] = str;
				}
			}

			for (int i = 0; i < matrix2.GetLength(0); i++)
			{
				for (int j = 0; j < matrix2.GetLength(1); j++)
				{
					Console.Write(matrix2[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
