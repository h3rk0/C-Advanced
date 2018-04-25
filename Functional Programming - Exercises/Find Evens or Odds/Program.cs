using System;
using System.Linq;

namespace Find_Evens_or_Odds
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();

			string condition = Console.ReadLine();

			var filter = GetFilter(condition, input);

			for (int i = input[0]; i <= input[1]; i++)
			{
				if (filter(i))
				{
					Console.Write(i + " ");
				}
			}
			Console.WriteLine();

		}



		static Func<int, bool> GetFilter(string condition, int[] boundaries)
		{
			int lower = boundaries[0];
			int upper = boundaries[1];
			if (condition == "odd")
			{
				return x => x >= lower && x <= upper && x % 2 != 0;
			}
			else
			{
				return x => x >= lower && x <= upper && x % 2 == 0;
			}
		}
	}
}
