using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Min_Function
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine()
				.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			Func<List<int>, int> min = numbers => numbers.Min();
			Console.WriteLine(min(input));

		}
	}
}
