using System;
using System.Linq;

namespace Sum_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine()
				.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(n => int.Parse(n))
				.ToArray();

			Func<int[], int> count = list => list.Count();

			Func<int[], int> sum = list => list.Sum();

			Console.WriteLine(count(input));
			Console.WriteLine(sum(input));

		}
	}
}
