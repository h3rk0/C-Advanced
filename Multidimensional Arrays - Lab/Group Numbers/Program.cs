using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine()
				.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			StringBuilder firstRow = new StringBuilder();

			StringBuilder secondRow = new StringBuilder();

			StringBuilder thirdRow = new StringBuilder();

			foreach (var number in numbers)
			{
				if (number % 3 == 0)
				{
					firstRow.Append(number + " ");
				}
				else if (number % 3 == 1 || number % 3 == -1)
				{
					secondRow.Append(number + " ");
				}
				else if (number % 3 == 2 || number % 3 == -2)
				{
					thirdRow.Append(number + " ");
				}
			}

			var firstRowArray = firstRow.ToString().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			var secondRowArray = secondRow.ToString().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			var thirdRowArray = thirdRow.ToString().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			List<int[]> arrays = new List<int[]>();

			arrays.Add(firstRowArray);

			arrays.Add(secondRowArray);

			arrays.Add(thirdRowArray);

			var jaggedArray = new int[3][];

			for (int row = 0; row < jaggedArray.Length; row++)
			{
				jaggedArray[row] = arrays[row];

			}


			for (int i = 0; i < jaggedArray.Length; i++)
			{
				for (int j = 0; j < jaggedArray[i].Length; j++)
				{
					Console.Write(jaggedArray[i][j] + " ");
				}

				Console.WriteLine();

			}
		}
	}
}
