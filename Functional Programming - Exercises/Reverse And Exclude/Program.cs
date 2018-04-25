using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_And_Exclude
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();

			int divisible = int.Parse(Console.ReadLine());

			Func<int, bool> exclude = nums => nums % divisible != 0;

			numbers = numbers.Where(exclude).Reverse().ToList();

			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}
